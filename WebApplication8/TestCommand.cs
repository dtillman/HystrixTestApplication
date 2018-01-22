using Microsoft.Extensions.Logging;
using Steeltoe.CircuitBreaker.Hystrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8
{
    public class TestCommand : HystrixCommand<bool>
    {
        private ILogger<TestCommand> _logger;

        public TestCommand(IHystrixCommandOptions options,
           ILogger<TestCommand> logger) : base(options)
        {
            _logger = logger;
            IsFallbackUserDefined = true;
        }
        protected override bool Run()
        {
            // throw new Exception("Bang!");
            return true;
        }

        protected override bool RunFallback()
        {
            return false;
        }
    }
}
