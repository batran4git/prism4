using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ModuleTracking;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Logging;

namespace ModularityUnityTest.Desktop
{
    class ModuleTracker : IModuleTracker
    {
        private readonly ModuleTrackingState ModuleATrackingStatus;
        private readonly ModuleTrackingState ModuleBTrackingStatus;
        private readonly ModuleTrackingState ModuleCTrackingStatus;
        private readonly ModuleTrackingState ModuleDTrackingStatus;
        private readonly ModuleTrackingState ModuleETrackingStatus;
        private readonly ModuleTrackingState ModuleFTrackingStatus;

        private ILoggerFacade logger;

        public ModuleTracker(ILoggerFacade logger)
        {
            if (logger == null)
                throw new ArgumentNullException("logger");
            this.logger = logger;

            this.ModuleATrackingStatus = new ModuleTrackingState

        }

        void IModuleTracker.RecordModuleConstructed(string moduleName)
        {
            throw new NotImplementedException();
        }

        void IModuleTracker.RecordModuleInitialized(string moduleName)
        {
            throw new NotImplementedException();
        }

        public void RecordModuleLoaded(string moduleName)
        {
            throw new NotImplementedException();
        }

        public void RecordModuleDownloaded(string moduleName, long bytesReceived, long totalBytesToReceive)
        {
            throw new NotImplementedException();
        }
    }
}
