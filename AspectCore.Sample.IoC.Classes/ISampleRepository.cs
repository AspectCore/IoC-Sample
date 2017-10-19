using System;
using System.Collections.Generic;
using System.Text;
using AspectCore.Injector;

namespace AspectCore.Sample.IoC.Classes
{
    public interface ISampleRepository
    {
    }

    public class SampleRepository : ISampleRepository
    {
        //属性注入。属性注入的条件为标记FromContainer特性，并且允许set。满足条件的属性自动注入
        [FromContainer]
        public ILogger Logger { get; set; }
    }
}