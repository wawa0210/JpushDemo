//------------------------------------------------------------------------------------------------
//
//
//         All rights reserved
//
//		   filename:JHelpKey
//		   desciption:
//
//		   created by 张潇 at 2015/9/2 11:14:08
//
//------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JpushHelp
{
    public static class JHelpKey
    {
        public static readonly string ApiKey = ConfigurationManager.AppSettings["ApiKey"];
        public static readonly string MasterSecretKey = ConfigurationManager.AppSettings["MasterSecret"];
    }
}
