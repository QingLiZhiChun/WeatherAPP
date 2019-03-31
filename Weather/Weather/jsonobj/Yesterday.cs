using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.jsonobj
{
    /// <summary>
    /// 昨天
    /// </summary>
    public class Yesterday
    {

        public string date { get; set; }

        public string sunrise { get; set; }//":"07:08",

        public string high { get; set; }//:"高温 9.0℃",

        public string low { get; set; }//":"低温 1.0℃",

        public string sunset { get; set; }//":"16:50",

        public string aqi { get; set; }//":75,
        public string ymd { get; set; }
        public string week { get; set; }

        public string fx { get; set; }//:"东风",

        public string fl { get; set; }//":"<3级",

        public string type { get; set; }//":"晴",

        public string notice { get; set; }//":"愿你拥有比阳光明媚的心情"
    }
}
