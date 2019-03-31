using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Cache;
namespace Weather.net
{
    public class WeatherRequest
    {
        HttpWebRequest httpRequest;

        string URL = null;
        private Stream resultStream;
        /// <summary>
        /// 获取响应数据流
        /// </summary>
        public Stream ResponseStream
        {
            get
            {
                return this.resultStream;
            }
        }
        /// <summary>
        /// 数据流是否为null
        /// </summary>
        public bool SreamIsNull
        {
            get
            {
                return null == resultStream;
            }
        }

        public WeatherRequest(string url)
        {

            URL = url;
        }
        /// <summary>
        ///获取网络数据流和响应对象
        /// </summary>
        public Stream GetResponseStream()
        {
            httpRequest = (HttpWebRequest)HttpWebRequest.CreateHttp(URL);
            httpRequest.Method = "get";
            httpRequest.Accept = "text/html,application/xhtml+xm…plication/xml;q=0.9,*/*;q=0.8";
            httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; …) Gecko/20100101 Firefox/63.0";
            httpRequest.Timeout = 3000;
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)httpRequest.GetResponse();
            }
            catch (WebException ) { return null; }
            catch (Exception)
            {
                return null;
            }
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return response.GetResponseStream();
            }
            return null;
        }

        public bool ServerValidity()
        {
            httpRequest = (HttpWebRequest)HttpWebRequest.CreateHttp(URL);
            httpRequest.Method = "HEAD";
            httpRequest.Accept = "text/html,application/xhtml+xm…plication/xml;q=0.9,*/*;q=0.8";
            httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; …) Gecko/20100101 Firefox/63.0";
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)httpRequest.GetResponse();
            }
            catch (WebException) { return false; }
            catch (Exception)
            {
                return false;
            }
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 异步获取网络数据流和响应对象
        /// </summary>
        public void AsyGetResponseStream()
        {
            httpRequest.BeginGetResponse(new AsyncCallback(GetrResponseCallback), httpRequest);
        }

        private void GetrResponseCallback(IAsyncResult ar)
        {
            IAsyncResult result = ar;
            HttpWebRequest request = ar.AsyncState as HttpWebRequest;
            request.Timeout = 3000;
            HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(ar);
            this.resultStream = (Stream)response.GetResponseStream();
        }
    }
}
