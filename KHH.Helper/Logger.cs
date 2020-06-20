using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHH.Helper
{
    public class Logger
    {
        public static void LogError(string fromWhere, Exception ex)
        {
            try
            {
                string errorLogPath = ConfigurationManager.AppSettings["ErrorLogPath"];
                string FileName = "ErrorLog_" + Convert.ToString(DateTime.Now.ToShortTimeString()) + ".txt";
                using (StreamWriter file =
                File.AppendText(Path.Combine(errorLogPath, FileName)))
                {
                    file.WriteLine();
                    file.WriteLine("----------------------------------------------------");
                    file.WriteLine("\n\n\n****** Exception starts here  *************");
                    file.WriteLine("****** Location : " + fromWhere + "  *************");
                    file.WriteLine("****** Time: " + Convert.ToString(DateTime.Now) + "  *************");
                    file.WriteLine("Exception Message: " + ex.Message);
                    file.WriteLine("Inner Exception : " + Convert.ToString(ex.InnerException));
                    file.WriteLine("Stack Trace: " + ex.StackTrace);
                    file.WriteLine("****** ///Exception Ends here  *************\n\n\n\n\n");
                    file.WriteLine("----------------------------------------------------");
                    file.WriteLine();
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

    }
}
