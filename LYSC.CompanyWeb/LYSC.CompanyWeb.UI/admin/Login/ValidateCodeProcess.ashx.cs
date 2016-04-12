using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace LYSC.CompanyWeb.UI.admin.Login
{
    /// <summary>
    /// ValidateCodeProcess 的摘要说明
    /// </summary>
    public class ValidateCodeProcess : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "image/jpeg";
            //生成验证码
            Common.ValidateCode validateCode = new Common.ValidateCode();
            string code = validateCode.CreateValidateCode(4);
            validateCode.CreateValidateGraphic(code, context);
            context.Session["ValidateCode"] = code;
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}