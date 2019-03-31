using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather {
   public static class Global {
       public static string UrlStr = "http://t.weather.sojson.com/api/weather/city/101010700";// @"https://restapi.amap.com/v3/weather/weatherInfo?key=fedb317e66356b56727ab7067ba9a4e8&city=110114";

        public static MessageQueue messageQueue = new MessageQueue();
    }



   
}
