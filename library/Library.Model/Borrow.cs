using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Model
{
    [Serializable]
    public class Borrow
    {
        public Borrow() { }

        #region Borrow表
        public uint borrowId { get; set; }//借书事务id
        public int rdId { get; set; }//读者ID
        public int bkId { get; set; }//书籍ID
        public int ldContinueTimes { get; set; }//续借次数
        public string ldDateOut { get; set; }//借书日期
        public string ldDateRetPlan { get; set; }//应还日期
        public string ldDateRetAct { get; set; }//实际还书日期
        public int ldOverDay { get; set; }//超期天数
        public float ldOverMoney { get; set; }//超期金额
        public float ldPunishMoney { get; set; }//罚款金额
        public bool IsHasReturn { get; set; }//是否已经还书，缺省为0-未还
        public int OperatorLendId { get; set; }//借书操作员
        public int OperatorRetId { get; set; }//还书操作员
        #endregion
    }
}
