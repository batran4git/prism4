using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Practices.Prism.Logging;

namespace ModularityUnityTest.Desktop
{
    class CallbackLogger : ILoggerFacade
    {
        private Queue<Tuple<string, Category, Priority>> savedLogs = new Queue<Tuple<string, Category, Priority>>();
        
        public void Log(string message, Category category, Priority priority)
        {
            if (this.savedLogs == null)
            throw new NotImplementedException();
        }
    }
}
