using LYSC.CompanyWeb.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LYSC.CompanyWeb.UI.admin.Login
{
    public partial class Login : System.Web.UI.Page
    {
        public string ErrorMsg = string.Empty;
        public string userName = string.Empty;
        public string Js = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                userName = Request.Cookies["userName"] == null ? string.Empty : Request.Cookies["userName"].Value;
            }
        }

        protected void btnLogin_Click(object sender, ImageClickEventArgs e)
        {
            #region 验证码判断
            //先取得验证码，判断验证码是否正确，如果不正确就不用到数据库中查找内容了
            string code = Session["ValidateCode"] == null ? string.Empty : Session["ValidateCode"].ToString();
            string fromCode = Request["txtCode"];
            if (code != fromCode)
            {
                //名字保留
                userName = Request["txtClientID"];
                //提醒用户
                ErrorMsg = "验证码有误！";
                return;
            }
            #endregion

            #region 获取提交过来的用户信息，到数据库查询

            string strLoginName = Request["txtClientID"].Trim();
            string strUserPwd = Request["txtPassword"];

            BLL.HKSJ_USERS userInfoService = new BLL.HKSJ_USERS();
            Model.HKSJ_USERS user = new Model.HKSJ_USERS();
            LoginResult result = userInfoService.GetUserLoginUserModel(strLoginName, strUserPwd);
            //判断返回结果
            if (result == LoginResult.userIsNull)
            {
                Js = "<script>alert('用户名不能为空！')</script>";
                return;
            }
            else if (result == LoginResult.pwdIsNull)
            {
                Js = "<script>alert('密码不能为空！')</script>";
                return;
            }
            else if (result == LoginResult.userNotExist)
            {
                Js = "<script>alert('用户名不存在！')</script>";
                //名字保留
                userName = Request["txtClientID"];
                return;
            }
            else if (result == LoginResult.pwdError)
            {
                Js = "<script>alert('密码错误！')</script>";
                //名字保留
                userName = Request["txtClientID"];
                return;
            }
            else if (result == LoginResult.OK)
            {
                //验证通过后把用户名保存到session里面
                Session["user"] = user;

                //把登录成功的用户名保存到cookie中
                if (!String.IsNullOrEmpty(strLoginName))
                {
                    Response.Cookies["userName"].Value = strLoginName;
                    Response.Cookies["userName"].Expires = DateTime.Now.AddDays(5);
                }
                //验证都通过，转到后台页面
                Response.Redirect("~/admin/users/adminUser.html");
            }
            else
            {
                Js = "<script>alert('未知错误！')</script>";
                return;
            }
            #endregion
        }
    }
}