using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccountingNote.DBSource;

namespace TryWebForm
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //如果Session的UserLoginInfo 為 null = 沒有登入的狀態
            if (this.Session["UserLoginInfo"] is null) 
            {
                this.plcLogin.Visible = true;
            }
            else
            {
                this.plcLogin.Visible = false;
                Response.Redirect("/SystemAdmin/UserInfo.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            ////宣告 測試用帳號
            //string db_Account = "Admin";
            //string db_Password = "12345";

            //頁面TEXTBOX
            string inp_Account = this.txtAccount.Text;
            string inp_PWD = this.txtPWD.Text;

            //檢查是否有輸入帳密
            if (string.IsNullOrWhiteSpace(inp_Account) || string.IsNullOrWhiteSpace(inp_PWD))
            {
                this.ltlMsg.Text = "Account / PWD is required.";
                return;
            }

            var dr = UserInfoManager.GetUserInfoByAccount(inp_Account);

            //檢查帳密是否符合，密碼大小血檢查
            if (string.Compare(dr["Account"].ToString(),inp_Account,true) == 0 && 
                string.Compare(dr["PWD"].ToString(),inp_PWD,false) == 0)
            {
                this.Session["UserLoginInfo"] = dr["Account"].ToString();
                Response.Redirect("/SystemAdmin/UserInfo.aspx");
            }
            else//否則回傳錯誤訊息
            {
                this.ltlMsg.Text = "Login fail. Please check Account / PWD.";
                return;
            }

        }
    }
}