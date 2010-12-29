using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Practices.Prism.Modularity;
using ModuleTracking;
using System.Collections.ObjectModel;

namespace ModularityUnityTest.Desktop
{
    class AggregateModuleCatalog : IModuleCatalog
    {
        private List<IModuleCatalog> catalogs = new List<IModuleCatalog>();

        public AggregateModuleCatalog()
        {
            this.catalogs.Add(new ModuleCatalog());
        }

        public ReadOnlyCollection<IModuleCatalog> catalog
        {
            get
            {
                return this.catalogs.AsReadOnly();
            }
        }

        public void AddCatalog(IModuleCatalog catalog)
        {
            if (catalog == null)
                throw new ArgumentNullException("catalog");

            this.catalogs.Add(catalog);
        }

        public IEnumerable<ModuleInfo> Modules
        {
            get
            {
                return this.catalogs.SelectMany(x => x.Modules);
            }
        }

        public IEnumerable<ModuleInfo> GetDependentModules(ModuleInfo moduleInfo)
        {
            var catalog = this.catalogs.Single(x => x.Modules.Contains(moduleInfo));
            return catalog.GetDependentModules(moduleInfo);
        }

        public IEnumerable<ModuleInfo> CompleteListWithDependencies(IEnumerable<ModuleInfo> moduleInfos)
        {
            var modulesGroupbyCatalog = moduleInfos.GroupBy<ModuleInfo, IModuleCatalog>(module => this.catalogs.Single(catalog => catalog.Modules.Contains(module)));
            return modulesGroupbyCatalog.SelectMany(x => x.Key.CompleteListWithDependencies(x));
        }

        public void Initialize()
        {
            foreach(var catalog in this.catalogs)
            {
                catalog.Initialize();
            }
        }

        public void AddModule(ModuleInfo module)
        {
            this.catalogs[0].AddModule(module);
        }
    }
}
