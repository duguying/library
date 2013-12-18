using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Library.Model;
using Library.DAL;

namespace Library.BLL
{
    public class BorrowAction
    {
        /// <summary>
        /// 借书
        /// </summary>
        /// <param name="br"></param>
        /// <returns></returns>
        public static int Borrow(Borrow br) {
            int result=0;
            string sql = @"exec borrow @bkId,@rdId,@opId";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@bkId",br.bkId),
                                            new SqlParameter("@rdId",br.rdId),
                                            new SqlParameter("@opId",br.OperatorRetId),
                                        };

            result = SqlHelper.ExecuteNonQuery(sql, parameters);
            if (result == 0)
            {
                return 0;
            }

            return result;
        }
        /// <summary>
        /// 续借
        /// </summary>
        /// <param name="br"></param>
        /// <returns></returns>
        public static int Renew(Borrow br) {
            int result = 0;
            int rdId = br.rdId;
            int bkId = br.bkId;

            string sql = @"exec renew @bkId,@rdId,@opId";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@bkId",br.bkId),
                                            new SqlParameter("@rdId",br.rdId),
                                            new SqlParameter("@opId",br.OperatorRetId),
                                        };

            result = SqlHelper.ExecuteNonQuery(sql, parameters);
            if (result == 0)
            {
                return 0;
            }

            return result;
        }
        /// <summary>
        /// 还书
        /// </summary>
        /// <param name="br"></param>
        /// <returns></returns>
        public static int Back(Borrow br) {
            int result = 0;
            int rdId = br.rdId;
            int bkId = br.bkId;

            string sql = @"exec back @bkId,@rdId,@opId";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@bkId",br.bkId),
                                            new SqlParameter("@rdId",br.rdId),
                                            new SqlParameter("@opId",br.OperatorRetId),
                                        };

            result = SqlHelper.ExecuteNonQuery(sql,parameters);
            if (result == 0) { 
                return 0; 
            }

            return result;
        }
    }
}
