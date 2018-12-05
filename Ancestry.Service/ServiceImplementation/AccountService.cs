using Ancestry.Data;
using Ancestry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ancestry.Service
{
    public class AccountService : IAccountService
    {
        private IRepositoryManager repoManager;
        public AccountService()
        {
            repoManager = new RepositoryManager();
        }
        public UserInformation ValidateUserData(LoginViewModel data) => ProcessUserData(data);

        #region PrivateMethods
        private UserInformation ProcessUserData(LoginViewModel data)
        {
            UserInformation info = null;
            info = repoManager.GetUserData(data);
            return info;
        }
        #endregion
    }
}
