<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage.aspx.cs" Inherits="guestbook_Manage" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body style="font-size: 12px">
    <form id="form1" runat="server">
    <div style="text-align: center">
        <asp:Repeater ID="rp_yan" runat="server">
            <ItemTemplate>
                <table bgcolor="#666666" border="0" cellpadding="0" cellspacing="1" style="width: 800px;
                    font-size: 12px; line-height: 30px;">
                    <tr>
                        <td bgcolor="#FFFFFF" style="width: 140px">
                           【留言操作<a href ='tb.aspx?id=<%#Eval("id")%>'><strong>删除/审核</strong></a>】</td>
                        <td bgcolor="#FFFFFF" colspan="2" style="width: 400px; text-align: left;">
                            留言标题：<%#Eval("title")%></td>
                        <td bgcolor="#FFFFFF" style="width: 180px; text-align: left;">
                            留言时间:<%#Eval("tjtime")%></td>
                    </tr>
                    <tr>
                        <td bgcolor="#FFFFFF" style="width: 120px">
                            留言人信息</td>
                        <td bgcolor="#FFFFFF" colspan="3" style="text-align: left; width: 580px">
                            <img alt="您的邮箱" src="face/mail.gif" />
                            ：<%#Eval("aemail")%>
                            &nbsp;<img alt="您的QQ" src="face/tux.gif" />
                            ：<%#Eval("qq")%>
                            &nbsp;<img alt="您的地址" src="face/comments.gif" />
                            ：<%#Eval("address")%>
                            &nbsp;
                            <img alt="留言IP" src="face/monitor.gif" />：
                            <%#Eval("Ip")%>&nbsp;&nbsp;首页是否显示：<%#Eval("flag")%>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#FFFFFF" rowspan="3" style="width: 120px">
                            <img alt="用户头像" src='face/<%#Eval("userface")%>' /></td>
                        <td bgcolor="#FFFFFF" colspan="3" rowspan="3" style="width: 580px; text-align: left;"
                            valign="top">
                            <%#FormatString(Eval("content").ToString())%>
                        </td>
                    </tr>
                    <tr>
                    </tr>
                    <tr>
                    </tr>
                    <tr>
                        <td bgcolor="#FFFFFF" style="width: 120px">
                            管理员回复<img src="face/reply.ico" /></td>
                        <td bgcolor="#FFFFFF" colspan="3" style="width: 580px; text-align: left; color: #660000;"
                            valign="top">
                            <%#Eval("reply")%><br />回复时间：<%#Eval("retime")%>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:Repeater>
        <br />
        <webdiyer:aspnetpager id="AspNetPager1" runat="server" firstpagetext="首页" lastpagetext="尾页"
            nextpagetext="后页" onpagechanging="AspNetPager1_PageChanging" pagesize="5" prevpagetext="前页"
            showpageindexbox="Always" submitbuttontext="Go" textafterpageindexbox="页" textbeforepageindexbox="转到"></webdiyer:aspnetpager>
    
    </div>
    </form>
</body>
</html>
