﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Log4netDemo
{
    public class LogMessage
    {
        public LogMessage(string message, string platform, string browser, string company, string user)
        {
            Message = message;
            Platform = platform;
            Browser = browser;
            Company = company;
            User = user;
        }

        public string Message { get; set; }

        public string Platform { get; set; }

        public string Browser { get; set; }

        public string Company { get; set; }

        public string User { get; set; }

        public override string ToString()
        {
            return Message;
        }
    }
}