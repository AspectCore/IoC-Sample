using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AspectCore.DynamicProxy;

namespace AspectCore.Sample.IoC.Classes
{
    public class SampleInterceptor : AbstractInterceptor
    {
        public override Task Invoke(AspectContext context, AspectDelegate next)
        {
            return context.Invoke(next);
        }
    }
}
