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
            string token = ""; // please input the line bot token
            string userid = "";// please input the user id
            string image_url = "https://i0.wp.com/blog.patw.me/wp-content/uploads/2017/05/ZcNMMLg.png?fit=800%2C416&ssl=1";
            string mp4_url = "https://www.legacyvet.com/sites/default/files/videos/Video%20%281%29.mp4";

            // Send the text message to user
            MessageUtility.PushTextMessage(token, userid, "Hi");

            // Send the image message to user
            MessageUtility.PushImageMessage(token, userid, image_url, image_url);

            // Send the video message to user
            MessageUtility.PushVideoMessage(token, userid, mp4_url, image_url);

            // Send the sticker message to user
            MessageUtility.PushStickerMessage(token, userid, "1", "1");
            
        }
    }
}
