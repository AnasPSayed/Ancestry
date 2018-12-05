using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ancestry.Data
{
    public static class ApplicationConstants
    {
        public const string QUERY_USER_SELECT = "select * from UserInformation where UserName='{0}' and Password='{2}'";
    }
}
