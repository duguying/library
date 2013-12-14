using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public static decimal Borrow(Borrow br) {
            decimal result=0;
            int rdId = br.rdId;
            int bkId = br.bkId;

            result = BorrowDAL.Add(br);
            string sql = @"update TB_Book set
bkStatus='借出'
where bkId="+bkId;
            if (result == 0) { return 0; }
            result=SqlHelper.ExecuteNonQuery(sql);
            if (result == 0) { return 0; }
            sql = @"update TB_Reader set
rdHaveBorrowNum=(select rdHaveBorrowNum from TB_Reader where rdID="+rdId+@")+1
where rdID="+rdId;
            result=SqlHelper.ExecuteNonQuery(sql);
            if (result == 0) { return 0; }
            
            return result;
        }
        /// <summary>
        /// 续借
        /// </summary>
        /// <param name="br"></param>
        /// <returns></returns>
        public static int Renew(Borrow br) {
            //int result = 0;
            //int rdId = br.rdId;
            //int bkId = br.bkId;

            //result = BorrowDAL.Add(br);
//            string sql = @"update TB_Book set
//bkStatus='借出'
//where bkId=" + bkId;
            return 1;
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

            string sql = @"update TB_Book set
bkStatus='在馆'
where bkId=" + bkId;
            result = SqlHelper.ExecuteNonQuery(sql);
            if (result == 0) { return 0; }
            sql = @"update TB_Reader set
rdHaveBorrowNum=(select rdHaveBorrowNum from TB_Reader where rdID=" + rdId + @")-1
where rdID=" + rdId;
            result = SqlHelper.ExecuteNonQuery(sql);
            if (result == 0) { return 0; }

            return result;
        }
    }
}
