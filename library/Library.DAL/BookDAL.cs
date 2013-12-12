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
        /// <returns>返回当前书籍ID</returns>
        public static int Add(Book book_record)
        {
            int rows = 0;

            #region SQL 语句准备
            string sql = @"insert into TB_Book(
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
                                            //new SqlParameter("@bkId",book_record.bkId),
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
            
            string sqlGetId = @"select bkId from TB_Book where
bkCode=@bkCode and
bkName=@bkName and
bkAuthor=@bkAuthor and
bkPress=@bkPress and
bkDatePress=@bkDatePress and
bkISBN=@bkISBN and
bkCatalog=@bkCatalog and
bkLanguage=@bkLanguage and
bkPages=@bkPages and
bkPrice=@bkPrice and
bkDateIn=@bkDateIn and
bkStatus=@bkStatus
";
            SqlParameter[] parameters1= { 
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

            if(rows>0){
                try
                {
                    rows = (int)SqlHelper.ExecuteScalar(sqlGetId, parameters1);
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);
                }
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
        /// <summary>
        /// 书籍查询
        /// </summary>
        /// <param name="book_information"></param>
        /// <returns></returns>
        public static DataTable FindByKeyword(Book book_information) {

            #region SQL 语句准备
            string sql = @"
select 
bkId as 书籍编号,
bkCode as 馆藏条码,
bkName as 书籍名称,
bkAuthor as 作者,
bkPress as 出版社,
bkDatePress as 出版时间,
bkISBN as ISBN条码,
bkCatalog as 分类,
bkLanguage as 语种,
bkPages as 页数,
bkPrice as 价格,
bkDateIn as 收录时间,
bkBrief as 简介,
bkStatus as 书籍状态
from dbo.vague_search_book_by_code(
    @bkCode
)
";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@bkCode",book_information.bkCode),
                                        };
            #endregion
            DataTable tmpTable;
            try
            {
                tmpTable = SqlHelper.GetDataTable(sql, parameters, "tmpTable");
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            return tmpTable;
        }
        /// <summary>
        /// 通过ID查找书籍
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable GetBookById(int id) {
            #region SQL 语句准备
            string sql = @"
select 
bkId ,
bkCode ,
bkName ,
bkAuthor ,
bkPress ,
bkDatePress ,
bkISBN ,
bkCatalog ,
bkLanguage ,
bkPages ,
bkPrice ,
bkDateIn ,
bkBrief ,
bkCover,
bkStatus
from TB_Book where bkId=@bkId
";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@bkId",id),
                                        };
            #endregion

            DataTable tmpTable;
            try
            {
                tmpTable = SqlHelper.GetDataTable(sql, parameters, "tmpTable");
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            //object o=tmpTable.Rows[0].ItemArray[10];
            return tmpTable;
        }
        #endregion

    }
}
