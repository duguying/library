using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Model
{
    [Serializable]
    public class ReaderType
    {
        public ReaderType() { }

        private string _rdTypeName = "";

        #region 读者类型表
        public short rdType { get; set; }
        public string rdTypeName { get { return _rdTypeName; } set { _rdTypeName = value.Trim(); } }
        public int maxBorrowNum { get; set; }
        public int maxBorrowDay { get; set; }
        public int maxContinueTimes { get; set; }
        #endregion
    }
}
