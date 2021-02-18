using FinalAppBeforeJS.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAppBeforeJS.Components
{
    public class PagiComp : ViewComponent
    {
        public IViewComponentResult Invoke(Pagination model) => View(model);
    }
}
