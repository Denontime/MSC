<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="guestbook_index" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>留言首页</title>
</head>
<body style="text-align: center; font-size: 12px;">
    <form id="form1" runat="server">
    <div style="text-align: center; line-height :30px">
        <table style="width: 800px; background-color: whitesmoke;">
            <tr>
                <td style="width: 800px; height: 32px;">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/guestbook/face/头.jpg" Width="800px" /></td>
            </tr>
            <tr>
                <td style="width: 800px; height: 32px; text-align: left;">
                    <a href="../index.aspx">网首首页</a>----<a href ="add.aspx" >给我留言</a>-----查看留言</td>
            </tr>
        </table>
     <asp:Repeater ID ="rp_yan" runat ="server" ><ItemTemplate>
      <table border="0" cellpadding="0" cellspacing="1" bgcolor="#666666" style="width: 800px; font-size: 12px; line-height: 30px;">
            <tr>
                <td bgcolor="#FFFFFF" style="width:120px">
                    留言人</td>
                <td colspan="2" bgcolor="#FFFFFF" style="width:400px; text-align: left;">
                    留言标题：<%#Eval("title")%></td>
                <td bgcolor="#FFFFFF" style="width:180px; text-align: left;">
                    留言时间:<%#Eval("tjtime")%></td>
            </tr>
            <tr>
                <td bgcolor="#FFFFFF" style="width: 120px">
                    留言人信息</td>
                <td colspan="3" bgcolor="#FFFFFF" style="text-align: left; width:480px">
                    <img src ="face/mail.gif" alt ="您的邮箱" />
                    ：<%#Eval("aemail")%>&nbsp;&nbsp;<img src ="face/tux.gif" alt ="您的QQ" />
                    ：<%#Eval("qq")%>&nbsp;&nbsp;<img src ="face/comments.gif" alt ="您的地址" />
                    ：<%#Eval("address")%>&nbsp;&nbsp;
                    <img src ="face/monitor.gif" alt ="留言IP" />： <%#Eval("Ip")%>&nbsp;&nbsp;<img src ='face/xin/<%#Eval("xinqing")%>'  alt ="留言心情" />
                    </td>
            </tr>
            <tr>
                <td rowspan="3" bgcolor="#FFFFFF" style="width:120px" valign="top">
                   <img src ='face/<%#Eval("userface")%>' alt ="用户头像" /></td>
                <td colspan="3" rowspan="3" valign="top" bgcolor="#FFFFFF"  style="width:680px; text-align: left;"> <%#FormatString(Eval("content").ToString())%>              </td>
            </tr>
            <tr>
            </tr>
            <tr>
            </tr>
            <tr>
                <td bgcolor="#FFFFFF" style="width:120px">
                    管理员回复<img src ="face/reply.ico" /></td>
                <td colspan="3" valign="top" bgcolor="#FFFFFF" style="width:580px; text-align: left; color: #660000;"> <%#Eval("reply")%><br />回复时间：<%#Eval("retime")%></td>
            </tr>
            <tr><td style ="wdith:800px"></td></tr>
</table>
     </ItemTemplate></asp:Repeater>
       </div>
       <table style="width: 800px;">
        <tr>
            <td style="width: 800px; height: 32px;">
              <webdiyer:aspnetpager id="AspNetPager1" runat="server" firstpagetext="首页"
                    lastpagetext="尾页" nextpagetext="下一页" onpagechanging="AspNetPager1_PageChanging"
                    pagesize="5" prevpagetext="上一页" showpageindexbox="Always" submitbuttontext="Go"
                    textafterpageindexbox="页" textbeforepageindexbox="转到"></webdiyer:aspnetpager></td>
        </tr>
    </table>
       <table style="width: 800px; background-color: whitesmoke;">
        <tr>
            <td style="width: 800px; height: 32px;">
                版权所有&copy外地人在郑州版权所有©外地人在郑州-858487123</td>
        </tr>
    </table>
    </form>
</body>
</html>
