using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAppBeforeJS.ViewModels.Admin
{
    public class CreateCategoryViewModel
    {
        [Required(ErrorMessage = "Требуется ввести название категории")]
        [Display(Name = "Название категории")]
        [StringLength(64, ErrorMessage = "Длина строки не соответствует параметрам от {2} до {1}", MinimumLength = 4)]
        public string Name { get; set; }
    }
}
