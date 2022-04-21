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
using System.Data.OleDb;
public partial class guestbook_Manage : System.Web.UI.Page
{
    DAL dl = new DAL();
    OleDbConnection conn = DAL.Creation();
  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            //this.rp_yan.DataSource = dl.GetDataSet("select * from guestbook order by id desc", "guestbook");
            //rp_yan.DataBind();
            bind();
            bind1();
        }
    }
    public void bind()
    {
        OleDbCommand cmd = new OleDbCommand("select count(id) from guestbook ", conn);
        conn.Open();
        AspNetPager1.RecordCount = (int)cmd.ExecuteScalar();
        conn.Close();
    }
    public void bind1()
    {
        OleDbDataAdapter oda = new OleDbDataAdapter("select * from guestbook  order by id desc", conn);
        DataSet ds = new DataSet();
        oda.Fill(ds, AspNetPager1.PageSize * (AspNetPager1.CurrentPageIndex - 1), AspNetPager1.PageSize, "guestbook");
        rp_yan.DataSource = ds;
        rp_yan.DataBind();

    }
    public string FormatString(string str)
    {
        str = str.Replace(" ", "&nbsp;&nbsp");//控制格式含数
        str = str.Replace("<", "&lt;");
        str = str.Replace(">", "&glt;");//5+1+a+s+p+x
        str = str.Replace('\n'.ToString(), "<br>");
        return str;
    }
    protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
    {
        AspNetPager1.CurrentPageIndex = e.NewPageIndex;
        bind1();
    }
}
