using System;
using System.Linq;

namespace AreaCount
{
    class PubDbOperate
    {
        public static bool CheckUser(string sUser, string sPsw)
        {
            string sSQL = string.Format("Select count(*) from General_Oper_User where Base_OperCode = '{0}' and Base_Password='{1}'", sUser, sPsw);
            int ARecNum = Convert.ToInt32(SqlHelper.GetQryStringVal(sSQL));
            return ARecNum > 0;
        }
    }
}
