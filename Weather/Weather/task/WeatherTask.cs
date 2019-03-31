using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Weather.convert;
using Weather.net;

namespace Weather.task
{
    public class WeatherTask
    {

        WeatherRequest weatherRequest = new WeatherRequest(Global.UrlStr);

        public const int SLEEP_TIME = 60*1000;
        Thread weatherThread = null;
        public WeatherTask()
        {
            weatherThread = new Thread(new ThreadStart(weatherWork));
            weatherThread.IsBackground = true;
        }
        public void StartTask()
        {
            if (weatherThread != null)
            {
                if (!weatherThread.IsAlive)
                {
                    weatherThread.Start();
                }
            }
        }
        public void StopTask()
        {
            if (weatherThread != null)
            {
                try
                {
                    weatherThread.Abort();
                }
                catch (ThreadAbortException e)
                {
                }
                finally
                {
                    weatherThread = null;
                }
            }
        }
        string oldvalue = null;
        string current = null;
        private void weatherWork()
        {
            while (true)
            {
                if (weatherRequest.ServerValidity()==false)
                {
                    Thread.Sleep(SLEEP_TIME);
                    continue;
                }
                Stream stm = weatherRequest.GetResponseStream();
                if (stm == null)
                {
                    Thread.Sleep(SLEEP_TIME);
                    continue;
                }
                StreamReader reader = new StreamReader(stm);
                current = null;
                current = reader.ReadToEnd();
                if (current!=oldvalue)
                {
                    Global.messageQueue.EnqueueMessage(current);
                    oldvalue = current;
                }
                reader.Close();
                reader.Dispose();
                Thread.Sleep(SLEEP_TIME);
            }
        }
    }
}
