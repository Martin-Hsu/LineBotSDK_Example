using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineBotSDK.Utility;

namespace LineBotSDK_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = "";
            string userid = "";
            string image_url = "https://i0.wp.com/blog.patw.me/wp-content/uploads/2017/05/ZcNMMLg.png?fit=800%2C416&ssl=1";

            MessageUtility.PushTextMessage(token, userid, "Hi");

            MessageUtility.PushImageMessage(token, userid, image_url, image_url);
        }
    }
}
