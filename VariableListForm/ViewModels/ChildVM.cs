using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VariableListForm.ViewModels
{
    public class ChildVM
    {
        [Required]
        public string Name { get; set; }
        public string Other { get; set; }

    }
}