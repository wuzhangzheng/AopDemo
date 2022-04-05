using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AopDemo.Api.CtmFilter
{
    public class CtmActionFilterOnClassAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            System.Console.WriteLine("CtmActionFilterOnClassOnActionExecuted");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            System.Console.WriteLine("CtmActionFilterOnClassOnActionExecuting");
        }
    }
}