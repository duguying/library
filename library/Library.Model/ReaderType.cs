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
        
        #region 读者类型表
        public int rdType { get; set; }
        public string rdTypeName { get; set; }
        public int maxBorrowNum { get; set; }
        public int maxBorrowDay { get; set; }
        public int maxContinueTimes { get; set; }
        #endregion
    }
}
