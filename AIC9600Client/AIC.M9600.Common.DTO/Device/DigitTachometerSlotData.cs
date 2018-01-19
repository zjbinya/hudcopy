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
    public class DigitTachometerSlotData : D_DigitTachometerSlot, ISlotData
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

        public double? RPM { get; set; }

        public void SetTestPointIdAndUploadTime(Guid itemGuid, DateTime uploadTime)
        {
            this.T_Item_Guid = itemGuid;
            this.UploadDatetime = uploadTime;
        }
    }
}
