using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AopDemo.Api.Filters;
using AopDemo.Api.CtmFilter;

namespace AopDemo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [CtmActionFilterOnClass]
    public class DoHomeworkController : ControllerBase
    {
        [HttpGet]
        [CtmActionFilterOnAction]
        [CtmAuthorizationFilter]
        [CtmResourceFilter]
        public void DoHomework(string time)
        {
           var car=BuyTicket(time);
           var cango= CheckTicket(car);
           if(cango)
           {
                GetInCar();
           }
        }

        private void GetInCar()
        {
            System.Console.WriteLine("上车");
        }

        private bool CheckTicket(string car)
        {
            return car=="D5656";
        }

        private string BuyTicket(string time)
        {
            if (time=="8:00")
            {
                return "D5656";
            }
            else
            {
                return "D5858";
            }
        }
    }
}