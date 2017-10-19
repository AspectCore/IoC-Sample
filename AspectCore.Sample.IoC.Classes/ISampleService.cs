using System;
using System.Collections.Generic;
using System.Text;

namespace AspectCore.Sample.IoC.Classes
{
    public interface ISampleService
    {
    }

    public class SampleService : ISampleService
    {
        private readonly ISampleRepository _sampleRepository;
        private readonly ILogger _logger;
        
        //构造器注入
        public SampleService(ISampleRepository sampleRepository, ILogger logger)
        {
            _sampleRepository = sampleRepository;
            _logger = logger;
        }
    }

    public class SampleService2 : ISampleService
    {
        private readonly ITaskService _taskService;
        private readonly ILogger _logger;

        public SampleService2(ITaskService taskService, ILogger logger)
        {
            _taskService = taskService;
            _logger = logger;
        }
    }
}