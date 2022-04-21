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

public partial class guestbook_tb : System.Web.UI.Page
{
    DAL dl = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string DelId = Request.QueryString["id"];
            DataTable dt = new DataTable();
            dt = dl.GetDataSet("select * from guestbook where id=" + Convert.ToInt32(DelId) + "", "guestbook");
            TextBox1.Text = dt.Rows[0][4].ToString();
            TextBox2.Text = dt.Rows[0][5].ToString();
            TextBox3.Text = dt.Rows[0][10].ToString();
           
          
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string DelId = Request.QueryString["id"];
       
        dl.ExecuteSQL("delete from guestbook where id=" + Convert.ToInt32(DelId) + "");
        Response.Write("<script>alert('删除成功！');location.href='Manage.aspx'</script>");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         string DelId = Request.QueryString["id"];
        string dp=DateTime .Now .ToString ();
        dl.ExecuteSQL("update guestbook set reply='" + TextBox3.Text + "',retime='" + dp + "',flag='"+DropDownList1.SelectedItem.Text +"' where id=" + Convert.ToInt32(DelId) + "");
        Response.Write("<script>alert('操作成功！');location.href='Manage.aspx'</script>");
        
    }
}
