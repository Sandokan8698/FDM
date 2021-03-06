﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using Data.Abstract;
using Data.Implementations;
using WebIU.Infrastructure.Abstract;
using WebIU.Infrastructure.Concrete;

namespace WebIU.Infrastructure
{
    public class NinjectDependencyResolver:IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            
        }
    }
}