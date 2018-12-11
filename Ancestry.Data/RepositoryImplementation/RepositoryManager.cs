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
        public int Register(UserInformation data) => ProcessRegistration(data);

        #region PrivateMethods
        private UserInformation ProcessGetUserData(LoginViewModel data)
        {
            UserInformation info = null;
            info = repo.GetUserDetails(data);
            return info;
        }

        private int ProcessRegistration(UserInformation data)
        {
            int id = 0;
            id = repo.Insert(data);
            return id;
        }
            #endregion
        }
}
