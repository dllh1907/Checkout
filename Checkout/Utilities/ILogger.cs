﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Checkout.Utilities
{
    public interface ILogger
    {
        void Log(string message);
    }
}