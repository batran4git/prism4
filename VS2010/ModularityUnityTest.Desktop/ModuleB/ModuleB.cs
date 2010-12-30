using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Logging;
using ModuleTracking;

namespace ModularityUnityTest.Desktop
{
    [Module(ModuleName=WellKnownModuleName.ModuleB, OnDemand=true)]
    class ModuleB : IModule
    {
        private readonly ILoggerFacade logger;
        private readonly IModuleTracker moduleTracker;

        public ModuleB(ILoggerFacade logger, IModuleTracker tracker)
        {
            if (logger == null)
                throw new ArgumentNullException("logger");
            if (tracker == null)
                throw new ArgumentNullException("moduleTracker");

            this.logger = logger;
            this.moduleTracker = tracker;
            this.moduleTracker.RecordModuleConstructed(WellKnownModuleName.ModuleB);
        }

        public void Initialize()
        {
            this.logger.Log("Module B demonstrates logging during initialize()..", Category.Info, Priority.Low);
            this.moduleTracker.RecordModuleInitialized(WellKnownModuleName.ModuleB);
        }
    }
}
