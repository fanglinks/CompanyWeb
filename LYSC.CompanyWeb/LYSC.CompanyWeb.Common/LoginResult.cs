using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LYSC.CompanyWeb.Common
{
  public  enum  LoginResult
    {
      pwdError,
      userNotExist,
      userIsNull,
      pwdIsNull,
      OK
    }
}
