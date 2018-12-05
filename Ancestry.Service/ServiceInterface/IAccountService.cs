using Ancestry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ancestry.Service
{
    public interface IAccountService
    {
        UserInformation ValidateUserData(LoginViewModel data);
    }
}
