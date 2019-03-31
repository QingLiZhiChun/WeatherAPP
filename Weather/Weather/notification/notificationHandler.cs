using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Weather.notification {
    public delegate void notificationHandle(MessageQueue msgQueue);
    public class NotifiationTask {
        /// <summary>
        /// 通知事件  
        /// </summary>
        public event notificationHandle notificationEvent = delegate { };
        Thread notif = null;
        public NotifiationTask() {
            notif = new Thread(new ThreadStart(workThread)) {
                Name = "notification",
                IsBackground = true
            };
        }

        public void SartMessageMonitor() {
            notif.Start();
        }
        public void CloseMonitor() {
            if (null != notif) {
                try {
                    notif.Abort();
                }
                catch (ThreadAbortException e) { }
                catch (Exception) {

                }
                finally {
                    notif = null;
                }
            }
        }
        private void workThread() {
            while (true) {
                if (Global.messageQueue.MessageLength > 0) {
                    notificationEvent?.Invoke(Global.messageQueue);
                }
                Thread.Sleep(2000);
            }
        }
    }
}
