﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEmu.IntradayBarRequest
{
    internal class RequestIntradayBarElementTime : RequestIntradayBarElementString
    {
        private readonly DateTime? _instance;

        internal RequestIntradayBarElementTime(string elementName) : base(elementName, "")
        {
            this._instance = null;
        }

        internal RequestIntradayBarElementTime(string elementName, DateTime date) : base(elementName, date.ToString("yyyyMMdd"))
        {
            this._instance = date;
        }

        internal RequestIntradayBarElementTime(string elementName, Datetime date)
            : this(elementName, date.ToSystemDateTime())
        {
            this._instance = date.ToSystemDateTime();
        }

        //I can't override GetElementAsDatetime here because the Bloomberg Request object stores dates as strings, not Datetimes.  You can't convert the string to a Datetime
        internal DateTime? GetDate { get { return this._instance; } }    
    }
}
