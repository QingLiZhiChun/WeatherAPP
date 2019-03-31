using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.jsonobj
{
    public class CityInfo
    {
        /// <summary>
        /// 城市名称
        /// </summary>

        public string city { get; set; }
        /// <summary>
        /// 城市编号
        /// </summary>

        public string cityId { get; set; }
        /// <summary>
        /// 城市上级名称
        /// </summary>

        public string parent { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>

        public string updateTime { get; set; }
    }
}
