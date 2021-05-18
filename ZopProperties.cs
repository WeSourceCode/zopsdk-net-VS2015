using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zopsdk_net_VS2015
{
    public class ZopProperties
    {
        public string companyid { get; }
        public string key { get; }

        public ZopProperties(string companyid, string key)
        {
            this.companyid = companyid;
            this.key = key;
        }
    }
}
