<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tb.aspx.cs" Inherits="guestbook_tb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body style="font-size: 12px; line-height: 30px">
    <form id="form1" runat="server">
    <div>
        <table style="width: 700px">
            <tr>
                <td style="width: 94px; text-align: center;">
        留言标题：</td>
                <td style="width:580px">
                <asp:TextBox ID="TextBox1" runat="server" Width="526px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 94px; text-align: center;">
        留言内容：</td>
                <td style="width:580px">
                <asp:TextBox ID="TextBox2" runat="server" Height="184px" TextMode="MultiLine"
            Width="530px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 94px; text-align: center;">
                    首页是否显示此条留言记录：</td>
                <td style="width:580px"><asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>是</asp:ListItem>
                        <asp:ListItem>否</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td style="width: 94px">
                    管理员回复：</td>
                <td style="width:580px">
                    <asp:TextBox ID="TextBox3" runat="server" Height="184px" TextMode="MultiLine" Width="530px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 94px">
                </td>
                <td style="width:580px">
                    <asp:Button ID="Button1" runat="server" Text="回复留言" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="删除留言"  OnClientClick="javascript:return confirm('确定删除吗？')"/></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
