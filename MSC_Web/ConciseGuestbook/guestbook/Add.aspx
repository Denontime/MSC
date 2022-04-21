<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="guestbook_Add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>添加留言</title>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
    <div style="text-align: center; line-height :30px; font-size:12px">
        <table style="width: 800px; background-color: whitesmoke;">
            <tr>
                <td style="width: 800px; height: 32px;">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/guestbook/face/头.jpg" Width="800px" /></td>
            </tr>
            <tr>
                <td style="width: 800px; height: 32px; text-align: left;">
                    <a href="../index.aspx">网首首页</a>---给我留言---<a href ="index.aspx" >查看留言</a></td>
            </tr>
        </table>
      <table border="0" cellpadding="0" cellspacing="1" bgcolor="#666666" style="width: 800px; font-size: 12px; line-height: 30px;">
            <tr>
                <td bgcolor="#FFFFFF" style="width:120px">
                    留言人：</td>
                <td bgcolor="#ffffff" colspan="3" style="text-align: left" valign="middle">
                    <asp:TextBox ID="TextBox1" runat="server" Width="127px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                        Display="Dynamic" ErrorMessage="用户名不能为空" ValidationGroup="g"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td bgcolor="#FFFFFF" style="width: 120px">
                    头像：</td>
                <td colspan="3" bgcolor="#FFFFFF" style="text-align: left; width:480px">
                    <asp:RadioButtonList ID="dface" runat="server" RepeatColumns="5" RepeatDirection="Horizontal">
                    </asp:RadioButtonList></td>
            </tr>
          <tr>
              <td bgcolor="#ffffff" style="width: 120px">
                  选择心情：</td>
              <td bgcolor="#ffffff" colspan="3" style="width: 480px; text-align: left">
                  <asp:RadioButtonList ID="dlb2" runat="server" RepeatColumns="10" RepeatDirection="Horizontal">
                  </asp:RadioButtonList></td>
          </tr>
          <tr>
              <td bgcolor="#ffffff" style="width: 120px">
                  留言标题：</td>
              <td bgcolor="#ffffff" colspan="3" style="width: 480px; text-align: left">
                  <asp:TextBox ID="TextBox6" runat="server" Width="513px"></asp:TextBox></td>
          </tr>
            <tr>
                <td rowspan="3" bgcolor="#FFFFFF" style="width:120px">
                    留言内容：</td>
                <td colspan="3" rowspan="3" valign="middle" bgcolor="#FFFFFF"  style="width:580px; text-align: left;">                
                    <asp:TextBox ID="TextBox2" runat="server" Height="112px" TextMode="MultiLine" Width="509px"></asp:TextBox></td>
            </tr>
            <tr>
            </tr>
            <tr>
            </tr>
            <tr>
                <td bgcolor="#FFFFFF" style="width:120px">
                    邮箱：</td>
                <td colspan="3" valign="middle" bgcolor="#FFFFFF" style="width:580px; text-align: left; color: #660000;">                
                    <asp:TextBox ID="TextBox3" runat="server" Width="299px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3"
                        Display="Dynamic" ErrorMessage="邮箱不能为空" ValidationGroup="g"></asp:RequiredFieldValidator>&nbsp;
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3"
                        Display="Dynamic" ErrorMessage="邮箱格式不正确" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                        ValidationGroup="g"></asp:RegularExpressionValidator></td>
            </tr>
          <tr>
              <td bgcolor="#ffffff" style="width: 120px; height: 30px">
                  QQ：</td>
              <td bgcolor="#ffffff" colspan="3" style="width: 580px; color: #660000; height: 30px;
                  text-align: left" valign="middle">
                  <asp:TextBox ID="TextBox4" runat="server" Width="203px"></asp:TextBox></td>
          </tr>
          <tr>
              <td bgcolor="#ffffff" style="width: 120px; height: 30px">
                  地址：</td>
              <td bgcolor="#ffffff" colspan="3" style="width: 580px; color: #660000; height: 30px;
                  text-align: left" valign="middle">
                  <asp:TextBox ID="TextBox5" runat="server" Width="577px"></asp:TextBox></td>
          </tr>
          <tr>
              <td bgcolor="#ffffff" style="width: 120px; height: 30px">
              </td>
              <td bgcolor="#ffffff" colspan="3" style="width: 580px; color: #660000; height: 30px;
                  text-align: left" valign="middle">
                  <asp:Button ID="Button1" runat="server" BackColor="#E0E0E0" BorderColor="Goldenrod"
                      BorderStyle="Solid" OnClick="Button1_Click" Text="提交" ValidationGroup="g" />
                  <asp:Button ID="Button2" runat="server" BackColor="#E0E0E0" BorderColor="Goldenrod"
                      BorderStyle="Solid" Text="取消" /></td>
          </tr>
          <tr>
              <td bgcolor="#ffffff" colspan="4" style="height: 30px; text-align: left">
                  <span style ="color :Red ">留言人不能为空<br />
                  请选择您的头像<br />
                  留言内容请输入不低于6个字符<br />
                  请输入您常用的邮箱<br />
                  QQ，地址如您方便，请输入。</span></td>
          </tr>
</table>
    </div><table style="width: 800px; background-color: whitesmoke; font-size: 12px;">
        <tr>
            <td style="width: 800px; height: 32px;">
                版权所有&copy外地人在郑州</td>
        </tr>
    </table>
    </form>
</body>
</html>
