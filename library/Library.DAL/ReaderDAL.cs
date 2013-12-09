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
        public static int Add(Reader reader_record)
        {
            int rows = 0;

            #region SQL 语句准备
            string sql = @"insert into TB_Reader(
rdID,
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
@rdID,
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

    }
}
