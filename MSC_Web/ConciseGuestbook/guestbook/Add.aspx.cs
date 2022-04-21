using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net;
public partial class guestbook_Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindHeartList();
            bindFace();
        }
    }
    public void bindFace()
    {
        for (int ii = 1; ii < 20; ii++)
        {
            this.dlb2.Items.Add("<img alt=\"头像\" border=\"0\" src=\"face/xin/" + ii.ToString() + ".gif\" /> ");
            this.dlb2.Items[ii - 1].Value = ii.ToString() + ".gif";
        }
        this.dface.Items[0].Selected = true;
    }
    private void BindHeartList()
    {
        for (int i = 1; i <10; i++)
        {
            this.dface.Items.Add("<img alt=\"头像\" border=\"0\" src=\"face/" + i.ToString() + ".gif\" /> ");
            this.dface.Items[i - 1].Value = i.ToString() + ".gif";
        }
        this.dface.Items[0].Selected = true;
    }
    public string FormatString(string str)
    {
        str = str.Replace(" ", "&nbsp;&nbsp");//控制格式含数
        str = str.Replace("<", "&lt;");
        str = str.Replace(">", "&glt;");
        str = str.Replace('\n'.ToString(), "<br>");
        return str;


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DAL dl = new DAL();
        string sp = "否";
        string usrIp = Request.UserHostAddress.ToString();
        dl.ExecuteSQL("insert into guestbook(username,userface,xinqing,title,content,aemail,qq,address,Ip,flag) values('" + TextBox1.Text + "','" + this.dface.SelectedValue.ToString () + "','" + dlb2.SelectedValue.ToString () + "','" + TextBox6.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','"+usrIp+"','"+sp+"')");
        Response.Write("<script>alert('提交成功,管理员审核后，才会显示！');location.href='index.aspx'</script>");
    }
}
