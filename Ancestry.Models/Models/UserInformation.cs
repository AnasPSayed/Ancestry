using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ancestry.Models
{
    public class UserInformation : BaseModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Sex { get; set; }
        public string DOB { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Profession { get; set; }
        public string HouseName { get; set; }
        public int SpouseId { get; set; }
        public int SiblingsId { get; set; }
        public int ChildId { get; set; }

        /*
         * ID int IDENTITY(1,1) primary key,
Name varchar(200),
Sex varchar(50),
DOB varchar(200),
Mobile varchar(200),
Email varchar(200),
Profession varchar(200),
HouseName varchar(200),
SpouseId int,
SiblingsId int,
ChildId int
         */
    }
}
