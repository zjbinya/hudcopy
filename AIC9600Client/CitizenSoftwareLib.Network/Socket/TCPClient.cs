﻿using CitizenSoftwareLib.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CitizenSoftwareLib.Network.Socket
{
    public class TCPClient : IDisposable
    {
        public int Port { get; private set; }
        public string IPAddress { get; private set; }
        public bool UseTLS { get; private set; }
        public string ClientCertPath { get; private set; }
        public string ClientCertPassword { get; private set; }
        public string ServerHostName { get; private set; }

        private TCPContext _currentContext = null;

        public bool Connected
        {
            get
            {
                lock (this)
                {
                    return _currentContext != null && _currentContext.Client != null && _currentContext.Client.Connected;
                }
            }
        }

        public TCPClient(string ipAddress, int port,bool useTLS = false, string serverHostName = null, string clientCertPath = null, string clientCertPassword = null)
        {
            this.UseTLS = useTLS;
            this.ClientCertPath = clientCertPath;
            this.ClientCertPassword = clientCertPassword;
            this.IPAddress = ipAddress;
            this.Port = port;
            this.ServerHostName = serverHostName;
        }

        public void Connect()
        {
            lock (this)
            {
                TcpClient client = new TcpClient();
                client.ReceiveBufferSize = 8192;
                client.SendBufferSize = 8192;
                TCPContext context = null;
                try
                {
                    try
                    {
                        bool connected = client.Connect(IPAddress, Port, 5000);
                        if(!connected)
                        {
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        LogFactory.Get().Error(ex.ToString());
                        return;
                    }

                    if (UseTLS)
                    {
                        SslStream stream = new SslStream(client.GetStream(), false);
                        if (!string.IsNullOrWhiteSpace(ClientCertPath) && File.Exists(ClientCertPath))
                        {
                            if (string.IsNullOrWhiteSpace(ClientCertPassword))
                            {
                                stream.AuthenticateAsClient(ServerHostName, new X509CertificateCollection(new X509Certificate[] { new X509Certificate2(ClientCertPath) }), System.Security.Authentication.SslProtocols.Tls, false);
                            }
                            else
                            {
                                stream.AuthenticateAsClient(ServerHostName, new X509CertificateCollection(new X509Certificate[] { new X509Certificate2(ClientCertPath, ClientCertPassword) }), System.Security.Authentication.SslProtocols.Tls, false);
                            }
                        }
                        else
                        {
                            stream.AuthenticateAsClient(ServerHostName);
                        }

                        if (stream.IsAuthenticated)
                        {
                            context = new TCPContext(client, stream);
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        context = new TCPContext(client, client.GetStream());
                    }
                }
                catch (ThreadAbortException)
                {
                    return;
                }
                catch (Exception ex)
                {
                    LogFactory.Get().Error(ex.ToString());
                }
                finally
                {
                    if (context != null)
                    {
                        _currentContext = context;
                    }
                }
            }
        }

        public void Close()
        {
            lock (this)
            {
                if (_currentContext != null)
                {
                    _currentContext.Dispose();
                    _currentContext = null;
                }
            }
        }

        public TCPMessage Send(TCPMessage message, TimeSpan? timeout = null)
        {
            lock (this)
            {
                if (Connected)
                {
                    SendContext context = new SendContext()
                    {
                        Request = message
                    };
                    Thread thread = new Thread(new ParameterizedThreadStart(Request));
                    thread.IsBackground = true;
                    thread.Start(context);
                    thread.Join(timeout.HasValue ? (int)timeout.Value.TotalMilliseconds : 8000);
                    return context.Response;
                }
                return null;
            }
        }

        private void Request(object obj)
        {
            SendContext context = obj as SendContext;
            try
            {
                context.Request.WriteToStream(_currentContext.Stream);
                byte[] lenData = _currentContext.Stream.Read(4);
                if (lenData != null && lenData.Length == 4)
                {
                    _currentContext.AddCache(lenData);
                    int len = BitConverter.ToInt32(lenData, 0);
                    byte[] bodyData = _currentContext.Stream.Read(len);
                    if (bodyData != null && bodyData.Length == len)
                    {
                        _currentContext.AddCache(bodyData);
                        var responses = _currentContext.ExtractMessage();
                        if (responses != null && responses.Count != 0)
                        {
                            context.Response = responses[0];
                        }
                    }
                }
            }
            catch { }
        }

        public void Dispose()
        {
            this.Close();
        }
    }

    class SendContext
    {
        public TCPMessage Request { get; set; }
        public TCPMessage Response { get; set; }

    }
}