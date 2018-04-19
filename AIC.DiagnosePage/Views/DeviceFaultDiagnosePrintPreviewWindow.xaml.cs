﻿using AIC.Core.DiagnosticBaseModels;
using AIC.Core.FlowDoc;
using AIC.Core.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Windows.Xps;
using System.Windows.Xps.Packaging;

namespace AIC.DiagnosePage.Views
{
    /// <summary>
    /// PrintPreviewWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DeviceFaultDiagnosePrintPreviewWindow : Window
    {
        public DeviceFaultDiagnosePrintPreviewWindow()
        {
            InitializeComponent();
            Closed += DeviceFaultDiagnosePrintPreviewWindow_Closed;
        }

        private void DeviceFaultDiagnosePrintPreviewWindow_Closed(object sender, EventArgs e)
        {
            var p = docViewer.Document;
        }

        public static FlowDocument LoadDocumentAndRender(string strTmplName, Object data, IDocumentRenderer renderer = null)
        {
            FlowDocument doc = (FlowDocument)Application.LoadComponent(new Uri(strTmplName, UriKind.RelativeOrAbsolute));
            doc.PagePadding = new Thickness(50);
            doc.DataContext = data;
            if (renderer != null)
            {
                renderer.Render(doc, data);
                DocumentPaginator paginator = ((IDocumentPaginatorSource)doc).DocumentPaginator;
                paginator.PageSize = new Size(1188, 840);
                //doc.PagePadding = new Thickness(50, 50, 50, 50);
                doc.ColumnWidth = double.PositiveInfinity;
            }
            return doc;
        }
        public DeviceFaultDiagnosePrintPreviewWindow(string strTmplName, Object data, IDocumentRenderer renderer = null) : this()
        {
            if (data is List<DiagnoseResult>)
            {
                List<DiagnoseResult> resultList = data as List<DiagnoseResult>;
                var m_doclist = new List<FlowDocument>();
                foreach (var result in resultList)
                {
                    m_doclist.Add(LoadDocumentAndRender(strTmplName, result, renderer));
                }
                Dispatcher.BeginInvoke(new PrintHelper.LoadManyXpsMethod(PrintHelper.LoadManyXps), DispatcherPriority.ApplicationIdle, m_doclist, docViewer);
            }
            else
            {
                var m_doc = LoadDocumentAndRender(strTmplName, data, renderer);
                Dispatcher.BeginInvoke(new PrintHelper.LoadXpsMethod(PrintHelper.LoadXps), DispatcherPriority.ApplicationIdle, m_doc, docViewer);
            }
           
        }     
    }
}