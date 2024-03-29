﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Practices.Prism.Modularity;
using ModuleTracking;
using System.Collections.ObjectModel;

namespace ModularityUnityTest.Desktop
{
    public class AggregateModuleCatalog : IModuleCatalog
    {
        private List<IModuleCatalog> catalogs = new List<IModuleCatalog>();

        public AggregateModuleCatalog()
        {
            this.catalogs.Add(new ModuleCatalog());
        }
 
        public AggregateModuleCatalog(List<IModuleCatalog> catalogs)
        {
            if (catalogs == null)
                throw new ArgumentNullException("catalogs");

            this.catalogs = catalogs;
        }
        public AggregateModuleCatalog(IModuleCatalog catalog)
        {
            if (catalog == null)
                throw new ArgumentNullException("catalog");

            this.catalogs.Add(catalog);
        }

        //public List<IModuleCatalog> Catalogs
        //{
        //    get { return this.catalogs; }
        //}
        public ReadOnlyCollection<IModuleCatalog> Catalogs
        {
            get { return this.catalogs.AsReadOnly(); }
        }

        public void AddModule(ModuleInfo moduleInfo)
        {
            if (moduleInfo == null)
                throw new ArgumentNullException("moduleInfo");

            this.catalogs[0].AddModule(moduleInfo);    
        }

        public IEnumerable<ModuleInfo> CompleteListWithDependencies(IEnumerable<ModuleInfo> modules)
        {
            //TODO: implement CompleteListWithDependencies(..)
            if (modules == null) throw new ArgumentNullException("modules");
            return null;
 //           var modulesGroupbyCatalog = modules.GroupBy<ModuleInfo, IModuleCatalog>(
//            return modulesGroupbyCatalog;
        }

        public IEnumerable<ModuleInfo> GetDependentModules(ModuleInfo moduleInfo)
        {
            var catalog = this.catalogs.Single(x => x.Modules.Contains(moduleInfo));
            return catalog.GetDependentModules(moduleInfo);
        }

        public void Initialize()
        {
            foreach (var catalog in this.catalogs)
            {
                catalog.Initialize();
            }
        }

        public IEnumerable<ModuleInfo> Modules
        {
            get  { return this.catalogs.SelectMany(x => x.Modules); }
        }
    }
}
