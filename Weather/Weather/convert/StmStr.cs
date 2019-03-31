using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.convert {
    public static class StmStr {
        static StreamReader reader;
        static string result;
        public static string StreamToString(Stream stm) {
            reader = new StreamReader(stm);
            result = reader.ReadToEnd();
            return result;
        }
    }
}
