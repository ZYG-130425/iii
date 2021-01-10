using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swagger
{
    public class Teacher : IPerson
    {
        public string show(string nm)
        {
            return "我是一名老师我是" + nm;
        }
    }
}
