﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCloud.WeApp.SDK.Authorization
{
    internal class LoginResult
    {
        public string Id { get; set; }

        public string Skey { get; set; }

        public UserInfo UserInfo { get; set; }
    }
}
