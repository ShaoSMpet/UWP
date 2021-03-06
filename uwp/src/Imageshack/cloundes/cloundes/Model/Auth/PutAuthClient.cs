﻿// lindexi
// 16:34

using System.IO;
using System.Net;
using lindexi.uwp.ImageShack.Thirdqiniucs.Model.RPC;

namespace lindexi.uwp.ImageShack.Thirdqiniucs.Model.Auth
{
    internal class PutAuthClient : Client
    {
        public PutAuthClient(string upToken)
        {
            UpToken = upToken;
        }

        public string UpToken
        {
            set;
            get;
        }

        /// <summary>
        /// </summary>
        /// <param name="request"></param>
        /// <param name="body"></param>
        public override void SetAuth(HttpWebRequest request, Stream body)
        {
            string authHead = "UpToken " + UpToken;
            request.Headers["Authorization"] = authHead;
        }
    }
}