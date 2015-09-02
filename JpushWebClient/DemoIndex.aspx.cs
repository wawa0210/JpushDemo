using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using cn.jpush.api;
using cn.jpush.api.push.mode;

namespace JpushWebClient
{
    public partial class DemoIndex : System.Web.UI.Page
    {
        private string apikKey = JpushHelp.JHelpKey.ApiKey;
        private string secretKey = JpushHelp.JHelpKey.MasterSecretKey;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Send_Click(object sender, EventArgs e)
        {
            JPushClient pushClient = new JPushClient(apikKey, secretKey);
            //pushClient.SendPush("{aaa:'a}");
            try
            {
                pushClient.SendPush(PushPayload.AlertPersnoal("hello"));
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg.Message);
            }
        }
    }
}