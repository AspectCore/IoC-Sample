using System;
using System.Collections.Generic;
using System.Text;

namespace AspectCore.Sample.IoC.Classes
{
    public interface ILogger
    {
        void Info(string message);
    }

    public class Logger : ILogger
    {
        public void Info(string message)
        {
            Console.WriteLine("info:{0}", message);
        }
    }
}