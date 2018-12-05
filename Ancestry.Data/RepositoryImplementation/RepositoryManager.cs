using Ancestry.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ancestry.Models;

namespace Ancestry.Data
{
    public class RepositoryManager : IRepositoryManager
    {
        internal AccountRepository repo;
        public RepositoryManager()
        {
            repo = new AccountRepository();
        }
        public UserInformation GetUserData(LoginViewModel data) => ProcessGetUserData(data);

        #region PrivateMethods
        private UserInformation ProcessGetUserData(LoginViewModel data)
        {
            UserInformation info = null;
            info = repo.GetUserDetails(data);
            return info;
        }
        #endregion
    }
}
