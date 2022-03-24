using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loggextension;

namespace Loggextension
{
    public class LoggingRepository : ILoggingRepository
    {
        public List<LogTable> GetAllErrors()
        {
            List<LogTable> ErrorLogs = new List<LogTable>();
            //Get the Employees from the Database
            //for now we are hard coded the employees
            ErrorLogs.Add(new LogTable() { ErrorMessage = "Out of memory exception", ErrorTime =DateTime.Now});
            
            return ErrorLogs;
        }

        public int InsertError(LogTable logs)
        {
            return 0;
            //Write insertion logic into table
        }
    }
}
