﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoSharp.Protocol.SystemMessages.Requests
{
    internal class GetNonceRequest
    {
        public bool getnonce { get { return true; } }
    }
}