using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace zopsdk_net_VS2015
{
    public class ZopRequest
    {
        public string url { set; get; }
        public NameValueCollection requestParams { get; }
        public int timeout = 2000;

        public ZopRequest()
        {
            this.requestParams = new NameValueCollection();
        }

        public ZopRequest addParam(string k, string v)
        {
            requestParams.Add(k, v);
            return this;
        }

    }
}
