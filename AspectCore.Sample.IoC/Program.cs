using System;
using AspectCore.Configuration;
using AspectCore.DynamicProxy;
using AspectCore.Sample.IoC.Classes;
using System.Collections.Generic;
using System.ComponentModel.Design;
using AspectCore.DependencyInjection;

namespace AspectCore.Sample.IoC
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个容器
            var services = new ServiceContext();

            services.Configure(config =>
            {
                config.Interceptors.AddTyped<SampleInterceptor>();
            });
            
            services.AddType<ISampleService, SampleService>();
            services.AddType<ISampleRepository, SampleRepository>();

            //使用类型注册服务
            services.AddType<ILogger, Logger>();
            //使用实例注册服务，服务的生命周期限定为单例
            services.AddInstance<ITaskService>(new TaskService());
            //使用委托工厂注册服务
            services.AddDelegate<ITaskService, TaskService>(resolver => new TaskService());

            //创建服务解析器
            IServiceResolver serviceResolver = services.Build();

            //解析单个服务
            ISampleService sampleService = serviceResolver.Resolve<ISampleService>();

            //解析单个服务，并且验证是否为null，为null则抛出异常
            ISampleService sampleServiceRequired = serviceResolver.ResolveRequired<ISampleService>();

            //解析服务集合，如果未注册，则为空集合
            IEnumerable<ISampleService> sampleServices = serviceResolver.ResolveMany<ISampleService>();
        }
    }
}
