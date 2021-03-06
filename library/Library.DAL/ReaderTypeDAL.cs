﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Library.Model;

namespace Library.DAL
{
    [Serializable]
    public class ReaderTypeDAL
    {
        #region 表基本操作
        /// <summary>
        /// 添加读者类型
        /// </summary>
        /// <param name="reader_type_record"></param>
        /// <returns></returns>
        public static short Add(ReaderType reader_type_record)
        {
            short rows = 0;

            #region SQL 语句准备
            string sql = @"insert into TB_ReaderType(
rdTypeName,
maxBorrowNum,
maxBorrowDay,
maxContinueTimes
)values(
@rdTypeName,
@maxBorrowNum,
@maxBorrowDay,
@maxContinueTimes
)";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@rdTypeName",reader_type_record.rdTypeName),
                                            new SqlParameter("@maxBorrowNum",reader_type_record.maxBorrowNum),
                                            new SqlParameter("@maxBorrowDay",reader_type_record.maxBorrowDay),
                                            new SqlParameter("@maxContinueTimes",reader_type_record.maxContinueTimes),
                                        };
            string sqlGetId = @"select rdType from TB_ReaderType where
rdTypeName=@rdTypeName and
maxBorrowNum=@maxBorrowNum and
maxBorrowDay=@maxBorrowDay and
maxContinueTimes=@maxContinueTimes
";
            SqlParameter[] parameters1 = { 
                                            new SqlParameter("@rdTypeName",reader_type_record.rdTypeName),
                                            new SqlParameter("@maxBorrowNum",reader_type_record.maxBorrowNum),
                                            new SqlParameter("@maxBorrowDay",reader_type_record.maxBorrowDay),
                                            new SqlParameter("@maxContinueTimes",reader_type_record.maxContinueTimes),
                                        };
            #endregion

            try {
                rows = (short)SqlHelper.ExecuteNonQuery(sql, parameters);
            }catch(SqlException e){
                throw new Exception(e.Message);
            }

            if (rows > 0)
            {
                try
                {
                    rows = (short)SqlHelper.ExecuteScalar(sqlGetId, parameters1);
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);
                }
            }

            return rows;
        }
        /// <summary>
        /// 删除读者类型
        /// </summary>
        /// <param name="reader_type_record"></param>
        /// <returns></returns>
        public static int Delete(ReaderType reader_type_record)
        {
            int rows=0;
            #region SQL 语句准备
            string sql = @"delete from TB_ReaderType where rdType=@rdType";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@rdType",reader_type_record.rdType)
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
        /// 修改读者类型
        /// </summary>
        /// <param name="reader_type_record"></param>
        /// <returns></returns>
        public static int Update(ReaderType reader_type_record)
        {
            int rows = 0;
            #region SQL 语句准备
            string sql = @"update TB_ReaderType set 
rdTypeName=@rdTypeName,
maxBorrowNum=@maxBorrowNum,
maxBorrowDay=@maxBorrowDay,
maxContinueTimes=@maxContinueTimes 
where rdType=@rdType
";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@rdType",reader_type_record.rdType),
                                            new SqlParameter("@rdTypeName",reader_type_record.rdTypeName),
                                            new SqlParameter("@maxBorrowNum",reader_type_record.maxBorrowNum),
                                            new SqlParameter("@maxBorrowDay",reader_type_record.maxBorrowDay),
                                            new SqlParameter("@maxContinueTimes",reader_type_record.maxContinueTimes),
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

        #region ReaderType表扩展操作
        public static DataRow GetDRByID(int rdType)
        {
            return null;
        }
        public static ReaderType GetObjectById(int rdType) {
            return null;
        }

        public static DataTable GetAllReadertype() {
            #region SQL 语句准备
            string sql = @"select 
rdType as 读者类别ID,
rdTypeName as 类别名,
maxBorrowNum as 最大借书数目,
maxBorrowDay as 最大借书天数,
maxContinueTimes as 最大续借次数
    from TB_ReaderType where 1=1
";
            #endregion

            DataTable rstTbl;
            try
            {
                rstTbl = SqlHelper.GetDataTable(sql, null, "tmpTable");
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            
            return rstTbl;
        }
        #endregion

    }
}
