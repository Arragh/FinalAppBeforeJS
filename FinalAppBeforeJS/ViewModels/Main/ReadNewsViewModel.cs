using FinalAppBeforeJS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAppBeforeJS.ViewModels.Main
{
    public class ReadNewsViewModel
    {
        public IEnumerable<News> News { get; set; }
        //public Pagination Pagination { get; set; }
    }
}
