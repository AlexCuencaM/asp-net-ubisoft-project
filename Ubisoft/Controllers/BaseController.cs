using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ubisoft.Models;
using System.Diagnostics;

namespace Ubisoft.Controllers
{
    public class BaseController:Controller
    {
        public UbisoftContext Context { get; set; }
        public BaseController(UbisoftContext context)
        {
            Context = context;
        }

    }
}
