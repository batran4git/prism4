using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModularityUnityTest.Desktop
{
    public enum ModuleInitializationStatus
    {
        NotStarted,

        /// <summary>
        /// The module is in the process of being downloaded.
        /// </summary>
        Downloading,

        Downloaded,

        Constructed,

        Initialized,
    }
}
