using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.jsonobj
{
    public class Data
    {
        /// <summary>
        /// 空气湿度
        /// </summary>

        public string shidu { get; set; }
        /// <summary>
        /// pm2.5
        /// </summary>

        public string pm25 { get; set; }
        /// <summary>
        /// pm10
        /// </summary>

        public string pm10 { get; set; }
        /// <summary>
        /// 空气质量
        /// </summary>

        public string quality { get; set; }
        /// <summary>
        /// 温度
        /// </summary>

        public string wendu { get; set; }
        /// <summary>
        /// 极少数敏感人群应减少户外活动
        /// </summary>

        public string ganmao { get; set; }
        /// <summary>
        /// 昨天
        /// </summary>

        public Yesterday yesterday { get; set; }
        /// <summary>
        /// 天气预报集合
        /// </summary>

        public List<Forecast> forecast { get; set; }
    }
}
