<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DemoIndex.aspx.cs" Inherits="JpushWebClient.DemoIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" style="margin: 0 auto; margin-top: 100px; width: 80%;">
        <h1 class="bg-primary">发送测试页面</h1>

        <div class="form-group">
            <label class="radio-inline">
                <input type="radio" name="inlineRadioOptions" id="rbBrandCast" value="option1" checked runat="server" />
                广播
            </label>
            <label class="radio-inline">
                <input type="radio" name="inlineRadioOptions" id="rbBatch" value="option2" runat="server" />
                群发
            </label>
            <label class="radio-inline">
                <input type="radio" name="inlineRadioOptions" id="rbSingleDevice" value="option3"  runat="server" />
                单独设备
            </label>
        </div>
        <div class="form-group">
            <input class="form-control" id="txtTitle" runat="server" placeholder="send_Title" />
        </div>
        <div class="form-group">
            <textarea class="form-control" rows="3" id="txtContent" runat="server" placeholder="send_Content"></textarea>
        </div>
        <div class="form-group">
            <asp:Button ID="btn_Send" CssClass="btn btn-success" runat="server" Text="发送" OnClick="btn_Send_Click" />
        </div>
        <br />

        <div class="form-group">
            <textarea class="form-control" rows="3" id="txtResponse" style="height: 200px;" runat="server" placeholder="response"></textarea>

        </div>
    </form>
</body>
</html>
