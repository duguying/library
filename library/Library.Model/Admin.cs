using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Model
{
    [Serializable]
    public class Admin
    {
        public Admin() { }

        //private int _adminId;
        private string _adminUsername = "";
        private string _adminPassword = "";
        private string _adminEmail = "";

        #region 管理员表
        public int adminId { get; set; }//管理员ID

        public string adminUsername {
            get { return _adminUsername; } 
            set { _adminUsername = value.Trim(); }
        }//管理员用户名

        public string adminPassword { 
            get { return _adminPassword; }
            set { _adminPassword = value.Trim(); }
        }//管理员密码

        public string adminEmail {
            get { return _adminEmail; } set {
                _adminEmail = value.Trim();
            } 
        }//Email
        public DateTime adminLastLoginDate { get; set; }//管理员最后登录时间
        #endregion
    }
}
