using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Logging;
using ModuleTracking;

namespace ModularityUnityTest.Desktop
{
    //[Module(ModuleName=WellKnownModuleName.ModuleA)]
    //[ModuleDependency(WellKnownModuleName.ModuleD)]
    public class ModuleA: IModule
    {
        private readonly ILoggerFacade logger;
        private readonly IModuleTracker moduleTracker;

        public ModuleA(ILoggerFacade logger, IModuleTracker tracker)
        {
            if (logger == null)
                throw new ArgumentNullException("logger");

            if (tracker == null)
                throw new ArgumentNullException("moduleTracker");

            this.logger = logger;
            this.moduleTracker = tracker;
            this.moduleTracker.RecordModuleConstructed(WellKnownModuleName.ModuleA);
        }

        void IModule.Initialize()
        {
            this.logger.Log("ModuleA demonstrates logging during initialize()..", Category.Info, Priority.Low);
            this.moduleTracker.RecordModuleInitialized(WellKnownModuleName.ModuleA);
        }
    }
}
