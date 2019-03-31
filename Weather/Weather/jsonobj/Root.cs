using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.jsonobj
{
    public class Root
    {
        /// <summary>
        /// 时间
        /// </summary>

        public string time { get; set; }
        /// <summary>
        /// 城市信息
        /// </summary>

        public CityInfo cityInfo { get; set; }
        /// <summary>
        /// 日期
        /// </summary>

        public string date { get; set; }
        /// <summary>
        /// 消息成功与否
        /// </summary>

        public string message { get; set; }
        /// <summary>
        /// 状态
        /// </summary>

        public string status { get; set; }
        /// <summary>
        /// 日期

        public Data data { get; set; }
    }
}
