using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Practices.Prism.Modularity;
using ModuleTracking;

namespace ModularityUnityTest.Desktop
{
    [Module(ModuleName=WellKnownModuleName.ModuleC)]
    public class ModuleC: IModule
    {
        private readonly IModuleTracker moduleTracker;

        public ModuleC(IModuleTracker tracker)
        {
            if (tracker == null)
                throw new ArgumentNullException("moduleTracker");

            this.moduleTracker = tracker;
            this.moduleTracker.RecordModuleConstructed(WellKnownModuleName.ModuleC);
        }

        public void Initialize()
        {
            this.moduleTracker.RecordModuleInitialized(WellKnownModuleName.ModuleC);
        }
    }
}
