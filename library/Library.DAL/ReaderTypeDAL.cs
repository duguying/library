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
            int rows = 0;

            #region SQL 语句准备
            string sql = "insert into TB_ReaderType(rdType,rdTypeName,maxBorrowNum,maxBorrowDay,maxContinueTimes)values(@rdType,@rdTpyeName,@maxBorrowNum,@maxBorrowDay,@maxContinueTimes)";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@rdType",reader_type_record.rdType),
                                            new SqlParameter("@rdTypeName",reader_type_record.rdTypeName),
                                            new SqlParameter("@maxBorrowNum",reader_type_record.maxBorrowNum),
                                            new SqlParameter("@maxBorrowDay",reader_type_record.maxBorrowDay),
                                            new SqlParameter("@maxContinueTimes",reader_type_record.maxContinueTimes),
                                        };
            #endregion

            try {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }catch(SqlException e){
                throw new Exception(e.Message);
            }

            return rows;
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
