using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AopDemo.Api.CtmFilter
{
    public class CtmResourceFilterAttribute : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            System.Console.WriteLine("OK");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            System.Console.WriteLine("OK");
        }
    }
}