using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggextension
{
    public interface ILoggingRepository
    {
         List<LogTable> GetAllErrors();

       public int InsertError(LogTable logs);

        // List<LogTable> GetAllErrors();
    }
}
