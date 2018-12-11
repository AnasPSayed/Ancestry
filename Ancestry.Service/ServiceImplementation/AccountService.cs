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
        public int Register(RegistrationViewModel data) => ProcessRegistration(data);

        #region PrivateMethods
        private UserInformation ProcessUserData(LoginViewModel data)
        {
            UserInformation info = null;
            info = repoManager.GetUserData(data);
            return info;
        }

        private int ProcessRegistration(RegistrationViewModel data)
        {
            int id = 0;
            UserInformation info = new UserInformation();
            info.UserName = data.UserName;
            info.Password = data.Password;
            info.Email = data.Email;
            info.Sex = data.Sex;
            info.Mobile = data.Mobile;
            info.HouseName = data.HouseName;
            info.Profession = data.Profession;
            id = repoManager.Register(info);
                return id;
        }
            #endregion
        }
}
