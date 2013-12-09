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
    public class BookDAL
    {
        #region 表基本操作
        /// <summary>
        /// 添加书籍
        /// </summary>
        /// <param name="book_record"></param>
        /// <returns></returns>
        public static int Add(Book book_record)
        {
            int rows = 0;

            #region SQL 语句准备
            string sql = @"insert into TB_Book(
bkId,
bkCode,
bkName,
bkAuthor,
bkPress,
bkDatePress,
bkISBN,
bkCatalog,
bkLanguage,
bkPages,
bkPrice,
bkDateIn,
bkBrief,
bkCover,
bkStatus
) values(
@bkId,
@bkCode,
@bkName,
@bkAuthor,
@bkPress,
@bkDatePress,
@bkISBN,
@bkCatalog,
@bkLanguage,
@bkPages,
@bkPrice,
@bkDateIn,
@bkBrief,
@bkCover,
@bkStatus
)";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@bkId",book_record.bkId),
                                            new SqlParameter("@bkCode",book_record.bkCode),
                                            new SqlParameter("@bkName",book_record.bkName),
                                            new SqlParameter("@bkAuthor",book_record.bkAuthor),
                                            new SqlParameter("@bkPress",book_record.bkPress),
                                            new SqlParameter("@bkDatePress",book_record.bkDatePress),
                                            new SqlParameter("@bkISBN",book_record.bkISBN),
                                            new SqlParameter("@bkCatalog",book_record.bkCatalog),
                                            new SqlParameter("@bkLanguage",book_record.bkLanguage),
                                            new SqlParameter("@bkPages",book_record.bkPages),
                                            new SqlParameter("@bkPrice",book_record.bkPrice),
                                            new SqlParameter("@bkDateIn",book_record.bkDateIn),
                                            new SqlParameter("@bkBrief",book_record.bkBrief),
                                            new SqlParameter("@bkCover",book_record.bkCover),
                                            new SqlParameter("@bkStatus",book_record.bkStatus),
                                        };
            #endregion

            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }

            return rows;
        }
        /// <summary>
        /// 删除书籍
        /// </summary>
        /// <param name="book_record"></param>
        /// <returns></returns>
        public static int Delete(Book book_record)
        {
            int rows = 0;

            #region SQL 语句准备
            string sql = @"delete from TB_Book where bkId=@bkId";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@bkId",book_record.bkId),
                                        };
            #endregion

            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }

            return rows;
        }
        /// <summary>
        /// 修改书籍信息
        /// </summary>
        /// <param name="book_record"></param>
        /// <returns></returns>
        public static int Update(Book book_record)
        {
            int rows = 0;

            #region SQL 语句准备
            string sql = @"update TB_Book set 
bkCode=@bkCode,
bkName=@bkName,
bkAuthor=@bkAuthor,
bkPress=@bkPress,
bkDatePress=@bkDatePress,
bkISBN=@bkISBN,
bkCatalog=@bkCatalog,
bkLanguage=@bkLanguage,
bkPages=@bkPages,
bkPrice=@bkPrice,
bkDateIn=@bkDateIn,
bkBrief=@bkBrief,
bkCover=@bkCover,
bkStatus=@bkStatus
where bkId=@bkId
";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@bkId",book_record.bkId),
                                            new SqlParameter("@bkCode",book_record.bkCode),
                                            new SqlParameter("@bkName",book_record.bkName),
                                            new SqlParameter("@bkAuthor",book_record.bkAuthor),
                                            new SqlParameter("@bkPress",book_record.bkPress),
                                            new SqlParameter("@bkDatePress",book_record.bkDatePress),
                                            new SqlParameter("@bkISBN",book_record.bkISBN),
                                            new SqlParameter("@bkCatalog",book_record.bkCatalog),
                                            new SqlParameter("@bkLanguage",book_record.bkLanguage),
                                            new SqlParameter("@bkPages",book_record.bkPages),
                                            new SqlParameter("@bkPrice",book_record.bkPrice),
                                            new SqlParameter("@bkDateIn",book_record.bkDateIn),
                                            new SqlParameter("@bkBrief",book_record.bkBrief),
                                            new SqlParameter("@bkCover",book_record.bkCover),
                                            new SqlParameter("@bkStatus",book_record.bkStatus),
                                        };
            #endregion

            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }

            return rows;
        }
        #endregion

    }
}
