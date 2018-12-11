using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ancestry.DB.BaseRepo
{
    public class BaseRepository
    {
        internal Database DbContext { get; set; }
        public BaseRepository()
        {
            DbContext = new Database("Ancestry");
        }

        public int Insert<T>(T tableData)
        {
            int result = 0;
            result = Convert.ToInt32(DbContext.Insert(tableData));
            return result;
        }

        public List<T> Select<T>(string query)
        {
            List<T> outputList = null;
            outputList =  DbContext.Fetch<T>(query).ToList();
            return outputList;
        }

        public int Update<T>(T tableName, int Id)
        {
            int flag = 0;
            flag = DbContext.Update(tableName, Id);
            return flag;
        }
    }
}
