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
        internal Database DbContect { get; set; }
        public BaseRepository()
        {
            DbContect = new Database("Ancestry");
        }

        public int Insert<T>(T tableData)
        {
            int result = 0;
            Convert.ToInt32(DbContect.Insert(tableData));
            return result;
        }

        public List<T> Select<T>(string query)
        {
            List<T> outputList = null;
            outputList =  DbContect.Fetch<T>(query).ToList();
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
