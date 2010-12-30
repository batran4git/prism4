using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Practices.Prism.Modularity;
using ModuleTracking;

namespace ModularityUnityTest.Desktop
{
    [Module(ModuleName=WellKnownModuleName.ModuleD)]
    class ModuleD
    {
        private readonly IModuleTracker moduleTracker;

        public ModuleD(IModuleTracker tracker)
        {
            if (tracker == null)
                throw new ArgumentNullException("moduleTracker");

            this.moduleTracker = tracker;
            this.moduleTracker.RecordModuleConstructed(WellKnownModuleName.ModuleD);
        }

        public void Initialize()
        {
            this.moduleTracker.RecordModuleInitialized(WellKnownModuleName.ModuleD);
        }
    }
}
