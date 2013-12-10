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
    public class BorrowDAL
    {
        #region 表基本操作
        /// <summary>
        /// 添加借书记录
        /// </summary>
        /// <param name="borrow_record"></param>
        /// <returns>long: 当前事务编号</returns>
        public static decimal Add(Borrow borrow_record)
        {
            decimal rows = 0;

            #region SQL 语句准备
            string sql = @"insert into TB_Borrow(
rdId,
bkId,
ldContinueTimes,
ldDateOut,
ldDateRetPlan,
ldDateRetAct,
ldOverDay,
ldOverMoney,
ldPunishMoney,
IsHasReturn,
OperatorLendId,
OperatorRetId
) values(
@rdId,
@bkId,
@ldContinueTimes,
@ldDateOut,
@ldDateRetPlan,
@ldDateRetAct,
@ldOverDay,
@ldOverMoney,
@ldPunishMoney,
@IsHasReturn,
@OperatorLendId,
@OperatorRetId
)";
            SqlParameter[] parameters = { 
                                            //new SqlParameter("@borrowId",borrow_record.borrowId),
                                            new SqlParameter("@rdID",borrow_record.rdId),
                                            new SqlParameter("@bkId",borrow_record.bkId),
                                            new SqlParameter("@ldContinueTimes",borrow_record.ldContinueTimes),
                                            new SqlParameter("@ldDateOut",borrow_record.ldDateOut),
                                            new SqlParameter("@ldDateRetPlan",borrow_record.ldDateRetPlan),
                                            new SqlParameter("@ldDateRetAct",borrow_record.ldDateRetAct),
                                            new SqlParameter("@ldOverDay",borrow_record.ldOverDay),
                                            new SqlParameter("@ldOverMoney",borrow_record.ldOverMoney),
                                            new SqlParameter("@ldPunishMoney",borrow_record.ldPunishMoney),
                                            new SqlParameter("@IsHasReturn",borrow_record.IsHasReturn),
                                            new SqlParameter("@OperatorLendId",borrow_record.OperatorLendId),
                                            new SqlParameter("@OperatorRetId",borrow_record.OperatorRetId),
                                        };

            string sqlGetId = @"select borrowId from TB_Borrow where
rdId=@rdId and
bkId=@bkId and
ldContinueTimes=@ldContinueTimes and
ldDateOut=@ldDateOut and
ldDateRetPlan=@ldDateRetPlan and
ldDateRetAct=@ldDateRetAct and
ldOverDay=@ldOverDay and
ldOverMoney=@ldOverMoney and
ldPunishMoney=@ldPunishMoney and
IsHasReturn=@IsHasReturn and
OperatorLendId=@OperatorLendId and
OperatorRetId=@OperatorRetId
";
            SqlParameter[] parameters1 = { 
                                            //new SqlParameter("@borrowId",borrow_record.borrowId),
                                            new SqlParameter("@rdID",borrow_record.rdId),
                                            new SqlParameter("@bkId",borrow_record.bkId),
                                            new SqlParameter("@ldContinueTimes",borrow_record.ldContinueTimes),
                                            new SqlParameter("@ldDateOut",borrow_record.ldDateOut),
                                            new SqlParameter("@ldDateRetPlan",borrow_record.ldDateRetPlan),
                                            new SqlParameter("@ldDateRetAct",borrow_record.ldDateRetAct),
                                            new SqlParameter("@ldOverDay",borrow_record.ldOverDay),
                                            new SqlParameter("@ldOverMoney",borrow_record.ldOverMoney),
                                            new SqlParameter("@ldPunishMoney",borrow_record.ldPunishMoney),
                                            new SqlParameter("@IsHasReturn",borrow_record.IsHasReturn),
                                            new SqlParameter("@OperatorLendId",borrow_record.OperatorLendId),
                                            new SqlParameter("@OperatorRetId",borrow_record.OperatorRetId),
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
            if (rows>0) {
                try
                {
                    rows = (decimal)SqlHelper.ExecuteScalar(sqlGetId, parameters1);
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);
                }
            }
            
            return rows;
        }
        /// <summary>
        /// 删除借书记录
        /// </summary>
        /// <param name="borrow_record"></param>
        /// <returns></returns>
        public static int Delete(Borrow borrow_record)
        {
            int rows = 0;

            #region SQL 语句准备
            string sql = @"delete from TB_Borrow where borrowId=@borrowId";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@borrowId",borrow_record.borrowId),
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
        /// 修改借书记录
        /// </summary>
        /// <param name="borrow_record"></param>
        /// <returns></returns>
        public static int Update(Borrow borrow_record)
        {
            int rows = 0;

            #region SQL 语句准备
            string sql = @"update TB_Borrow set
rdId=@rdId,
bkId=@bkId,
ldContinueTimes=@ldContinueTimes,
ldDateOut=@ldDateOut,
ldDateRetPlan=@ldDateRetPlan,
ldDateRetAct=@ldDateRetAct,
ldOverDay=@ldOverDay,
ldOverMoney=@ldOverMoney,
ldPunishMoney=@ldPunishMoney,
IsHasReturn=@IsHasReturn,
OperatorLendId=@OperatorLendId,
OperatorRetId=@OperatorRetId
where borrowId=@borrowId
";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@borrowId",borrow_record.borrowId),
                                            new SqlParameter("@rdID",borrow_record.rdId),
                                            new SqlParameter("@bkId",borrow_record.bkId),
                                            new SqlParameter("@ldContinueTimes",borrow_record.ldContinueTimes),
                                            new SqlParameter("@ldDateOut",borrow_record.ldDateOut),
                                            new SqlParameter("@ldDateRetPlan",borrow_record.ldDateRetPlan),
                                            new SqlParameter("@ldDateRetAct",borrow_record.ldDateRetAct),
                                            new SqlParameter("@ldOverDay",borrow_record.ldOverDay),
                                            new SqlParameter("@ldOverMoney",borrow_record.ldOverMoney),
                                            new SqlParameter("@ldPunishMoney",borrow_record.ldPunishMoney),
                                            new SqlParameter("@IsHasReturn",borrow_record.IsHasReturn),
                                            new SqlParameter("@OperatorLendId",borrow_record.OperatorLendId),
                                            new SqlParameter("@OperatorRetId",borrow_record.OperatorRetId),
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
