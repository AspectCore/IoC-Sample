using System;
using System.Collections.Generic;
using System.Text;
using AspectCore.DependencyInjection;

namespace AspectCore.Sample.IoC.Classes
{
    public interface ISampleRepository
    {
    }

    public class SampleRepository : ISampleRepository
    {
        //属性注入。属性注入的条件为标记FromContainer特性，并且允许set。满足条件的属性自动注入
        [FromServiceContext]
        public ILogger Logger { get; set; }
    }
}