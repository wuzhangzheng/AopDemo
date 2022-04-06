using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AopDemo.Api.Filters
{
    public class CtmActionFilterOnActionAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            System.Console.WriteLine("CtmActionFilterOnActionExecuted");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            System.Console.WriteLine("CtmActionFilterOnActionExecuting");       
        }
    }
}