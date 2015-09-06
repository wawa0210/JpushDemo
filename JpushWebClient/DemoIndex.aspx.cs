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
            try
            {
                Message msg = new Message(txtContent.Value, txtTitle.Value, "");

                //广播
                if (this.rbBrandCast.Checked)
                {
                    pushClient.SendPush(PushPayload.SendAndroidAlertPushToAll(msg));
                }
                //批量发送
                else if (this.rbBatch.Checked)
                {
                    string[] paramsId = new string[] { "0304819befc", "021032" };
                    pushClient.SendPush(PushPayload.SendAndroidAlertBatchPush(msg, paramsId));
                }
                //单独设备发送
                else if (rbSingleDevice.Checked)
                {
                    string registerId = "0304819befc";
                    pushClient.SendPush(PushPayload.SendAndroidAlertSinglePush(msg, registerId));

                }
            }
            catch (Exception msg)
            {
                txtResponse.Value = msg.Message;
            }
        }
    }
}