using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MILS.Modules;
using System.Data.Linq;
using MILS.Connections;

namespace MILS.Class
{
    class LoginClass
    {
        public static int UserID = 0;
        public static int AreaId;

        public static Table<tbl_User>GetTbl_Users()
        {
            return LCon.db.GetTable<tbl_User>();
        }

        public static bool LoginUser(string User, string Pass)
        {
            bool exists = GetTbl_Users()
                .Any(p => p.UserCode == User &&
                          p.UserPass == Pass);
            return exists;
        }


        public static int GetUserID(string User, string Pass)
        {
            var p = (from s in GetTbl_Users()
                         where s.UserCode == User && s.UserPass== Pass
                         select s).FirstOrDefault();

            p.UserID = UserID;
            return p.UserID;
        }

        
        public static int GetAreaID(string User, string Pass)
        {
            var p = (from s in GetTbl_Users()
                     where s.UserCode == User && s.UserPass == Pass
                     select s).FirstOrDefault();
            return p.UserID;
        }







    }
}
