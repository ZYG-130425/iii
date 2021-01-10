using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Swagger
{
    public interface IDAL
    {
        string Del();
        DataTable datatable();
    }
}
