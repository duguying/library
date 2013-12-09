using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Library.Model;

namespace Library.DAL
{
    [Serializable]
    class ReaderTypeDAL
    {
        #region 表基本操作
        public static int Add(ReaderType reader_type_record)
        {
            return 0;
        }
        public static int Delete(ReaderType reader_type_record)
        {
            return 0;
        }
        public static int Update(ReaderType reader_type_record)
        {
            return 0;
        }
        #endregion

        #region ReaderType表扩展操作
        public static DataRow GetDRByID() {
            return null;
        }
        #endregion

    }
}
