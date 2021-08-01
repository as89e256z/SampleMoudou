using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryWebForm.SystemAdmin
{
    public partial class UserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //如果Session的UserLoginInfo 為 null = 沒有登入的狀態
            if (this.Session["UserLoginInfo"] is null)
            {
                Response.Redirect("/Login.aspx");
            }
        }
    }
}