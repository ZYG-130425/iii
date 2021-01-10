using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Swagger.Controllers
{
    /// <summary>
    /// 控制器
    /// </summary>
    public class PersonController : BaseController
    {
        string str;
        public PersonController(Func<int,IDAL> funcFactory)
        {

            str = funcFactory(2).Del();
        }


        /// <summary>
        /// hlow
        /// </summary>
        /// <returns></returns>
        [Route("/api/show")]
        [HttpGet]
        public string Show()
        {
            return str;

        }


    }
}