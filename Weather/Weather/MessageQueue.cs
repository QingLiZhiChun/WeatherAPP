using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public class MessageQueue
    {
        Queue<String> _message = new Queue<string>();
        public void EnqueueMessage(string msg)
        {
            _message.Enqueue(msg);
        }

        public int MessageLength
        {
            get
            {
                return _message.Count;
            }
        }
        public string DequeueMessage()
        {
            return _message.Dequeue();
        }
      
    }
}
