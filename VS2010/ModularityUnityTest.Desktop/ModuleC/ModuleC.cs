﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Logging;
using ModuleTracking;

namespace ModularityUnityTest.Desktop
{
    [Module(ModuleName=WellKnownModuleName.ModuleC)]
    public class ModuleC: IModule
    {
        private readonly ILoggerFacade logger;
        private readonly IModuleTracker moduleTracker;

        public ModuleC(ILoggerFacade logger, IModuleTracker tracker)
        {
            if (logger == null)
                throw new ArgumentNullException("logger");

            if (tracker == null)
                throw new ArgumentNullException("moduleTracker");

            this.logger = logger;
            this.moduleTracker = tracker;
            this.moduleTracker.RecordModuleConstructed(WellKnownModuleName.ModuleC);
        }

        public void Initialize()
        {
            this.logger.Log("Module C demonstartes logging during initialize()..", Category.Info, Priority.Low);
            this.moduleTracker.RecordModuleInitialized(WellKnownModuleName.ModuleC);
        }
    }
}
