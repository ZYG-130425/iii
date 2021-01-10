using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swagger
{
    public class Student : IPerson
    {
        public string show(string nm)
        {
            return "我是" + nm;
        }
    }
}
