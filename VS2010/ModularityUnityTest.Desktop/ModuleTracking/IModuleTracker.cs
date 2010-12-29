using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuleTracking
{
    public interface IModuleTracker
    {
        void RecordModuleConstructed(string moduleName);
        void RecordModuleInitialized(string moduleName);
    }
}
