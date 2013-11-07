using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VariableListForm.ViewModels
{
    public class ParentVM
    {
        public ParentVM()
        {
        }

        public string ParName { get; set; }
        public List<ChildVM> ChildVms { get; set; }

    }
}