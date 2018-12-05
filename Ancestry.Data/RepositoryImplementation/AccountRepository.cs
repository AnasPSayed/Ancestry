using Ancestry.DB.BaseRepo;
using Ancestry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ancestry.Data
{
    public class AccountRepository  : BaseRepository
    {
        public UserInformation GetUserDetails(LoginViewModel model)
        {
            UserInformation info = null;
            info = Select<UserInformation>(string.Format(ApplicationConstants.QUERY_USER_SELECT,model.UserName,model.Password)).FirstOrDefault();
            return info;
        }
    }
}
