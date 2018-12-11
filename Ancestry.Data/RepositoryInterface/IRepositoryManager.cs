using Ancestry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ancestry.Data
{
    public interface IRepositoryManager
    {
        UserInformation GetUserData(LoginViewModel data);
        int Register(UserInformation data);
    }
}
