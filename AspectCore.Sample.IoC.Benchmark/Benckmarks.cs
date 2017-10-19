using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using Autofac;
using AspectCore.Injector;
using AspectCore.Sample.IoC.Classes;

namespace AspectCore.Sample.IoC.Benchmark
{
    [AllStatisticsColumn]
    [MemoryDiagnoser]
    public class Benckmarks
    {
        private readonly IServiceResolver serviceResolver;
        private readonly IContainer container;

        public Benckmarks()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<Logger>().As<ILogger>().InstancePerDependency();
            containerBuilder.RegisterType<TaskService>().As<ITaskService>().InstancePerDependency();
            containerBuilder.RegisterType<SampleRepository>().As<ISampleRepository>().InstancePerDependency().PropertiesAutowired();
            containerBuilder.RegisterType<SampleService2>().As<ISampleService>().InstancePerDependency();
            container = containerBuilder.Build();

            var serviceContainer = new ServiceContainer();
            serviceContainer.AddType<ILogger, Logger>(Lifetime.Transient);
            serviceContainer.AddType<ITaskService, TaskService>(Lifetime.Transient);
            serviceContainer.AddType<ISampleRepository, SampleRepository>(Lifetime.Transient);
            serviceContainer.AddType<ISampleService, SampleService2>(Lifetime.Transient);
            serviceResolver = serviceContainer.Build();
        }

        [Benchmark]
        public object Autofac_Sample_Resolve()
        {
            return container.Resolve<ITaskService>();
        }

        [Benchmark]
        public object AspectCore_Sample_Resolve()
        {
            return serviceResolver.Resolve<ITaskService>();
        }

        [Benchmark]
        public object Autofac_PropertyInjection()
        {
            return container.Resolve<ISampleRepository>();
        }

        [Benchmark]
        public object AspectCore_PropertyInjection()
        {
            return serviceResolver.Resolve<ISampleRepository>();
        }

        [Benchmark]
        public object Autofac_ConstructorInjection()
        {
            return container.Resolve<ISampleService>();
        }

        [Benchmark]
        public object AspectCore_ConstructorInjection()
        {
            return serviceResolver.Resolve<ISampleService>();
        }
    }
}
