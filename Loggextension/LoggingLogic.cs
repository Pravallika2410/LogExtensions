using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggextension
{

    //Dependency logic implented here. Injected repository to Business logic class.
    public class LoggingLogic {
        public ILoggingRepository loggingRepository;
        public LoggingLogic(ILoggingRepository loggingRepository)
        {
            this.loggingRepository = loggingRepository;
        }
        public List<LogTable> GetAllErrorsHere()
        {
            return loggingRepository.GetAllErrors();
        }
        public int InsertError(LogTable log)
        {
            return loggingRepository.InsertError(log);
        }
    }
}
