﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit.Engine.Services
{
    public class DriverFactory : IDriverFactory, IService
    {
        #region IDriverFactory Members

        public IFrameworkDriver GetDriver(AppDomain domain, string assemblyPath, IDictionary<string, object> settings)
        {
            return new NUnitFrameworkDriver(domain, assemblyPath, settings);
        }

        #endregion

        #region IService Members

        private ServiceContext services;
        public ServiceContext ServiceContext 
        {
            get { return services; }
            set { services = value; }
        }

        public void InitializeService()
        {
        }

        public void UnloadService()
        {
        }

        #endregion
    }

    public interface IDriverFactory
    {
        IFrameworkDriver GetDriver(AppDomain domain, string assemblyPath, IDictionary<string, object> settings);
    }
}
