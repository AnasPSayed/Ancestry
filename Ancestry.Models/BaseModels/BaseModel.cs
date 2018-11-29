using Ancestry.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ancestry.Models.BaseModels
{
    public class BaseModel
    {
        public string CreatedDate { get; set; } = DateTime.Now.ToTimeZoneTime().ToString("MM/dd/yyyy HH:mm:ss.fff");
        public string ModifiedDate { get; set; } = DateTime.Now.ToTimeZoneTime().ToString("MM/dd/yyyy HH:mm:ss.fff");
    }
}
