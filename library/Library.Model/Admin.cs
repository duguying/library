using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Model
{
    [Serializable]
    class Admin
    {
        public Admin() { }

        #region 管理员表
        public int adminId { get; set; }//管理员ID
        public string adminUsername { get; set; }//管理员用户名
        public string adminPassword { get; set; }//管理员密码
        public string adminEmail { get; set; }//Email
        public string adminLastLoginDate { get; set; }//管理员最后登录时间
        #endregion
    }
}
