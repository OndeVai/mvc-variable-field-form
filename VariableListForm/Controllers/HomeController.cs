using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VariableListForm.ViewModels;

namespace VariableListForm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var parent = new ParentVM
                {
                    ParName = "yo!!",
                    ChildVms =
                        new List<ChildVM>()
                            {
                                new ChildVM {Name = "frst", Other = "ot1"},
                                new ChildVM {Name = "frst1", Other = "ot12"},
                                new ChildVM {Name = "frst2", Other = "ot13"}
                            }
                };

            return View(parent);
        }


        public ActionResult NewChild()
        {
            
            return PartialView("EditorTemplates/ChildVM", new ChildVM());
        }


        [HttpPost]
        public ActionResult Index(ParentVM model)
        {
            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
