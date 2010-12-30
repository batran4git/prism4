using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ModuleTracking;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Logging;
using System.Globalization;
using ModularityUnityTest.Desktop.Properties;

namespace ModularityUnityTest.Desktop
{
    class ModuleTracker : IModuleTracker
    {
        private readonly ModuleTrackingState moduleATrackingStatus;
        private readonly ModuleTrackingState moduleBTrackingStatus;
        private readonly ModuleTrackingState moduleCTrackingStatus;
        private readonly ModuleTrackingState moduleDTrackingStatus;
        private readonly ModuleTrackingState moduleETrackingStatus;
        private readonly ModuleTrackingState moduleFTrackingStatus;

        private ILoggerFacade logger;

        public ModuleTracker(ILoggerFacade logger)
        {
            if (logger == null)
                throw new ArgumentNullException("logger");
            this.logger = logger;

            this.moduleATrackingStatus = new ModuleTrackingState
            {
                ModuleName = WellKnownModuleName.ModuleA,
                ExpectedDiscoveryMethod = DiscoveryMethod.ApplicationReference,
                ExpectedDownloadTiming = DownloadTiming.WithApplication,
                ExpectedInitializationMode = InitializationMode.WhenAvailable,
                ConfiguredDependencies = WellKnownModuleName.ModuleD,
            };

        }

        public ModuleTrackingState ModuleATrackingStatus
        {
            get { return this.moduleATrackingStatus; }
        }
        public ModuleTrackingState ModuleBTrackingStatus
        {
            get { return this.moduleBTrackingStatus; }
        }
       
        void IModuleTracker.RecordModuleConstructed(string moduleName)
        {
            ModuleTrackingState status = this.GetModuleTrackingState(moduleName);

            if (status != null)
                status.ModuleInitializationStatus = ModuleInitializationStatus.Constructed;

            this.logger.Log(string.Format(CultureInfo.CurrentCulture, Resources.ModuleConstructed, moduleName), Category.Debug, Priority.Low);
        }

        private ModuleTrackingState GetModuleTrackingState(string moduleName)
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
