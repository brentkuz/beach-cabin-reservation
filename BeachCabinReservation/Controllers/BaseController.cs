
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeachCabinReservation.Controllers
{
    public abstract class BaseController<T> : Controller where T : class
    {
        protected ILogger<T> logger;

        public BaseController(ILogger<T> logger)
        {
            this.logger = logger;
        }
    }
}
