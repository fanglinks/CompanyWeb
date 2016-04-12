using LYSC.CompanyWeb.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYSC.CompanyWeb.BLL
{
    public partial class HKSJ_USERS
    {
        //使用存储过程进行分页,
        public List<Model.HKSJ_USERS> GetPageSizeNav(int pageIndex, int pageSize, out int totalCount)
        {
            return dal.GetPageSizeNav(pageIndex, pageSize, out totalCount);
        }

        public LoginResult GetUserLoginUserModel(string loginName, string userPwd)
        {
            //先对用户名或密码是否为空判断
            if (string.IsNullOrEmpty(loginName))
            {
                return LoginResult.userIsNull;
            }
            if (string.IsNullOrEmpty(userPwd))
            {
                return LoginResult.pwdIsNull;
            }
            //用户名密码不为空就到数据库中查询
            Model.HKSJ_USERS user = dal.GetLoginUser(loginName);
            //对返回的结果进行判断
            if (user.LoginName == null)
            {
                return LoginResult.userNotExist;
            }
            else if (userPwd != user.PassWord)
            {
                return LoginResult.pwdError;
            }
            else
            {
                return LoginResult.OK;
            }
        }

        #region ---自己写的方法判断但添加用户的时候是否存在同名用户----
        public bool ExistsLoginName(string LoginName)
        {
            return dal.ExistsLoginName(LoginName);
        }
        #endregion
    }
}