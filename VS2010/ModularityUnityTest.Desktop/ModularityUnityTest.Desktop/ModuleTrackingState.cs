using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using System.ComponentModel;

namespace ModularityUnityTest.Desktop
{
    class ModuleTrackingState : INotifyPropertyChanged
    {
        private string moduleName;
        private ModuleInitializationStatus moduleInitializationStatus;
        private DiscoveryMethod expectedDiscoveryMethod;
        private InitializationMode expectedInitializationMode;
        private DownloadTiming expectedDownloadTiming;
        private string dependencyModuleName;
        private string configuredDependencies = "(none)";
        private long bytesReceived;
        private long totalBytesToReceive;

        public string ModuleName
        {
            get { return this.moduleName; }
            set
            {
                if (this.moduleName != value)
                {
                    this.moduleName = value;
                    this.RaisePropertyChanged(PropertyNames.ModuleName);
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public static class PropertyNames
        {
            public const string ModuleName = "ModuleName";
            public const string ModuleInitializationStatus = "ModuleInitializationStatus";
            public const string expectedDiscoveryMethod = "expectedDiscoveryMethod";
            public const string expectedInitializationMode = "expectedInitializationMode";
            public const string expectedDownloadTiming = "expectedDownloadTiming";
            public const string configuredDepencies = "configuredDepencies";
            public const string bytesReceived = "bytesReceived";
            public const string totalBytesToReceive = "totalBytesToReceive";
            public const string DownloadProgressPercentage = "DownloadProgressPercentage";
        }
    }
}
