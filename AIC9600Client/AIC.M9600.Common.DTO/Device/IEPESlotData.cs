﻿/* Author : zhengyangyong */
using AIC.M9600.Common.SlaveDB;
using AIC.M9600.Common.SlaveDB.Generated;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC.M9600.Common.DTO.Device
{
    public class IEPESlotData : D_IEPESlot, ISlotData, ISlotWaveformData
    {
        public AlarmLimit[] AlarmLimit
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(this.AlarmLimitJSON))
                {
                    return JsonConvert.DeserializeObject<AlarmLimit[]>(this.AlarmLimitJSON);
                }
                else return null;
            }
            set
            {
                if (value == null) this.AlarmLimitJSON = null;
                else
                {
                    this.AlarmLimitJSON = JsonConvert.SerializeObject(value);
                }
            }
        }

        public ExtraInfo ExtraInfo
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(this.ExtraInfoJSON))
                {
                    if (this.ExtraInfoJSON.Substring(0, 1) == "\"")
                    {
                        return JsonConvert.DeserializeObject<ExtraInfo>(this.ExtraInfoJSON.Substring(1, this.ExtraInfoJSON.Length - 2));//return JsonConvert.DeserializeObject<ExtraInfo>(this.ExtraInfoJSON);
                    }
                    else
                    {
                        return JsonConvert.DeserializeObject<ExtraInfo>(this.ExtraInfoJSON);
                    }
                }
                else return null;
            }
            set
            {
                if (value == null) this.ExtraInfoJSON = null;
                else
                {
                    this.ExtraInfoJSON = JsonConvert.SerializeObject(value);
                }
            }
        }

        [JsonIgnore]
        public DateTime RegionACQDatetime
        {
            get { return new DateTime(ACQDatetime.Year, ACQDatetime.Month, 1); }
        }

        [JsonIgnore]
        public SignalType Type
        {
            get { return (SignalType)Enum.Parse(typeof(SignalType), this.GetType().Name); }
        }

        public Dictionary<string, double> StatisticsInfo { get; set; }

        public void SetTestPointIdAndUploadTime(Guid itemGuid, DateTime uploadTime)
        {
            this.T_Item_Guid = itemGuid;
            this.UploadDatetime = uploadTime;

            if(DivFreInfo != null && DivFreInfo.Length != 0)
            {
                DivFreInfo.AsParallel().ForAll(info =>
                {
                    info.SetTestPointIdAndUploadTime(itemGuid, uploadTime);
                    info.ChannelHDID = this.ChannelHDID;
                    info.ACQDatetime = this.ACQDatetime;
                    info.RecordLab = this.RecordLab;
                });
            }

            if (Waveform != null)
            {
                Waveform.T_Item_Guid = itemGuid;
                Waveform.ACQDatetime = this.ACQDatetime;
                Waveform.AlarmGrade = this.AlarmGrade;
                Waveform.ChannelHDID = this.ChannelHDID;
            }
        }

        public IEPESlotData_DivFreeInfo[] DivFreInfo { get; set; }

        [JsonIgnore]
        [WaveformType(Type = typeof(IEPESlotData_Waveform))]
        public IWaveformData Waveform { get; set; }

        public IWaveformData GenerateWaveformData()
        {
            return new IEPESlotData_Waveform();
        }
    }
}
