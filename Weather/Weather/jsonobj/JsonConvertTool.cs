using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Weather.jsonobj
{
    /// <summary>
    /// Json转换工具
    /// </summary>
    public class JsonConvertTool
    {
        static JsonConvertTool tool;
        public  Root root;
        private JsonConvertTool()
        {
        }
        public static JsonConvertTool CreateJsonRoot(string orgJsonStr)
        {
            tool = new JsonConvertTool();
            Root root = null;
             tool.GetJson(orgJsonStr,out root);
            return tool;
        }
        void  GetJson(string org,out Root root)
        {
            root = (Root)JsonConvert.DeserializeObject(org, typeof(Root));
            this.root = root;
        }
        /// <summary>
        /// 有效性
        /// </summary>
        /// <returns></returns>
        public bool Validity()
        {
            if (root == null)
            {
                return false;
            }
            if ("200" == root.status)
            {
                return true;
            }
            return false;
        }
    }
}
