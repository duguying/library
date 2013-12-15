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
    public class ReaderDAL
    {
        #region 表基本操作
        /// <summary>
        /// 添加读者
        /// </summary>
        /// <param name="reader_record"></param>
        /// <returns></returns>
        public static int Add(Reader reader_record)
        {
            int rows = 0;

            #region SQL 语句准备
            string sql = @"insert into TB_Reader(
rdUsername,
rdPassword,
rdName,
rdSex,
rdType,
rdDept,
rdPhone,
rdEmail,
rdDateReg,
rdPhoto,
rdStatus,
rdHaveBorrowNum
) values(
@rdUsername,
@rdPassword,
@rdName,
@rdSex,
@rdType,
@rdDept,
@rdPhone,
@rdEmail,
@rdDateReg,
@rdPhoto,
@rdStatus,
@rdHaveBorrowNum
)";
            SqlParameter[] parameters = { 
                                            //new SqlParameter("@rdID",reader_record.rdID),
                                            new SqlParameter("@rdUsername",reader_record.rdUsername),
                                            new SqlParameter("@rdPassword",reader_record.rdPassword),
                                            new SqlParameter("@rdName",reader_record.rdName),
                                            new SqlParameter("@rdSex",reader_record.rdSex),
                                            new SqlParameter("@rdType",reader_record.rdType),
                                            new SqlParameter("@rdDept",reader_record.rdDept),
                                            new SqlParameter("@rdPhone",reader_record.rdPhone),
                                            new SqlParameter("@rdEmail",reader_record.rdEmail),
                                            new SqlParameter("@rdDateReg",reader_record.rdDateReg),
                                            new SqlParameter("@rdPhoto",reader_record.rdPhoto),
                                            new SqlParameter("@rdStatus",reader_record.rdStatus),
                                            new SqlParameter("@rdHaveBorrowNum",reader_record.rdHaveBorrowNum),
                                        };
            string sqlGetId = @"select rdID from TB_Reader where
rdUsername=@rdUsername and
rdPassword=@rdPassword and
rdName=@rdName and
rdSex=@rdSex and
rdType=@rdType and
rdDept=@rdDept and
rdPhone=@rdPhone and
rdEmail=@rdEmail and
rdDateReg=@rdDateReg and
rdStatus=@rdStatus and
rdHaveBorrowNum=@rdHaveBorrowNum
";
            SqlParameter[] parameters1 = { 
                                            //new SqlParameter("@rdID",reader_record.rdID),
                                            new SqlParameter("@rdUsername",reader_record.rdUsername),
                                            new SqlParameter("@rdPassword",reader_record.rdPassword),
                                            new SqlParameter("@rdName",reader_record.rdName),
                                            new SqlParameter("@rdSex",reader_record.rdSex),
                                            new SqlParameter("@rdType",reader_record.rdType),
                                            new SqlParameter("@rdDept",reader_record.rdDept),
                                            new SqlParameter("@rdPhone",reader_record.rdPhone),
                                            new SqlParameter("@rdEmail",reader_record.rdEmail),
                                            new SqlParameter("@rdDateReg",reader_record.rdDateReg),
                                            //new SqlParameter("@rdPhoto",reader_record.rdPhoto),
                                            new SqlParameter("@rdStatus",reader_record.rdStatus),
                                            new SqlParameter("@rdHaveBorrowNum",reader_record.rdHaveBorrowNum),
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

            if (rows > 0)
            {
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
        /// 删除读者
        /// </summary>
        /// <param name="reader_record"></param>
        /// <returns></returns>
        public static int Delete(Reader reader_record)
        {
            int rows = 0;

            #region SQL 语句准备
            string sql = @"delete from TB_Reader where rdID=@rdID";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@rdID",reader_record.rdID),
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
        /// 修改读者信息
        /// </summary>
        /// <param name="reader_record"></param>
        /// <returns></returns>
        public static int Update(Reader reader_record)
        {
            int rows = 0;

            #region SQL 语句准备
            string sql = @"update TB_Reader set 
rdUsername=@rdUsername,
rdPassword=@rdPassword,
rdName=@rdName,
rdSex=@rdSex,
rdType=@rdType,
rdDept=@rdDept,
rdPhone=@rdPhone,
rdEmail=@rdEmail,
rdDateReg=@rdDateReg,
rdPhoto=@rdPhoto,
rdStatus=@rdStatus,
rdHaveBorrowNum=@rdHaveBorrowNum
where rdID=@rdID";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@rdID",reader_record.rdID),
                                            new SqlParameter("@rdUsername",reader_record.rdUsername),
                                            new SqlParameter("@rdPassword",reader_record.rdPassword),
                                            new SqlParameter("@rdName",reader_record.rdName),
                                            new SqlParameter("@rdSex",reader_record.rdSex),
                                            new SqlParameter("@rdType",reader_record.rdType),
                                            new SqlParameter("@rdDept",reader_record.rdDept),
                                            new SqlParameter("@rdPhone",reader_record.rdPhone),
                                            new SqlParameter("@rdEmail",reader_record.rdEmail),
                                            new SqlParameter("@rdDateReg",reader_record.rdDateReg),
                                            new SqlParameter("@rdPhoto",reader_record.rdPhoto),
                                            new SqlParameter("@rdStatus",reader_record.rdStatus),
                                            new SqlParameter("@rdHaveBorrowNum",reader_record.rdHaveBorrowNum),
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
        #region 扩展操作
        public static DataTable GetReaderByID(int rdID) {
            string sql=@"select * from TB_Reader where rdId="+rdID;
            DataTable rt = SqlHelper.GetDataTable(sql,null,"tmpReaderTable");
            //rt.Rows[0].ItemArray[0].ToString().Trim();
            return rt;
        }

        public static int UpdateInfo(Reader reader_record)
        {
            int rows = 0;
            string sql = @"update TB_Reader set 
rdName=@rdName,
rdSex=@rdSex,
rdType=@rdType,
rdDept=@rdDept,
rdPhone=@rdPhone,
rdEmail=@rdEmail

where rdID=@rdID
";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@rdID",reader_record.rdID),
                                            new SqlParameter("@rdName",reader_record.rdName),
                                            new SqlParameter("@rdSex",reader_record.rdSex),
                                            new SqlParameter("@rdType",reader_record.rdType),
                                            new SqlParameter("@rdDept",reader_record.rdDept),
                                            new SqlParameter("@rdPhone",reader_record.rdPhone),
                                            new SqlParameter("@rdEmail",reader_record.rdEmail),
                                        };
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
