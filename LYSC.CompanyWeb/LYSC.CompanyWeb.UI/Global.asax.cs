using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using LYSC.CompanyWeb.UI;
using System.IO;
using System.Text;

namespace LYSC.CompanyWeb.UI
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // 在应用程序启动时运行的代码
        }

        void Application_End(object sender, EventArgs e)
        {
            //  在应用程序关闭时运行的代码

        }

        void Application_Error(object sender, EventArgs e)
        {
            // 在出现未处理的错误时运行的代码

            //string str = Context.Error.ToString();
            //在此方法里面，获取错误信息，记录错误日志
            string str = Server.GetLastError().ToString();

            //写入到文本文件里面去
            File.WriteAllText(Server.MapPath("log.txt"), str, Encoding.Default);

            //页面跳转执行
            Response.Write("Error.html");
        }
    }
}
