using GymProject.Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymProject.Portal.Domain
{
    public class Data
    {
        public IEnumerable<Navbar> navbarItems()
        {
            var menu = new List<Navbar>();
            menu.Add(new Navbar { Id = 1, nameOption = "Home page", controller = "Home", action = "Index", imageClass = "fa fa-home fa-fw", status = true, isParent = false, parentId = 0 });
            menu.Add(new Navbar { Id = 2, nameOption = "Work Out Room", imageClass = "fa fa-bar-chart-o fa-fw", status = true, isParent = true, parentId = 0 });
            menu.Add(new Navbar { Id = 3, nameOption = "Page 1", controller = "Home", action = "Blank", status = true, isParent = false, parentId = 2 });
            menu.Add(new Navbar { Id = 4, nameOption = "Page 2", controller = "Home", action = "Blank", status = true, isParent = false, parentId = 2 });
            menu.Add(new Navbar { Id = 5, nameOption = "IFA Fitness", controller = "Home", action = "Blank", imageClass = "fa fa-bars fa-fw", status = true, isParent = false, parentId = 0 });
            menu.Add(new Navbar { Id = 16, nameOption = "Fitness Evaluation", imageClass = "fa fa-thumbs-up fa-fw", status = true, isParent = true, parentId = 0 });
            menu.Add(new Navbar { Id = 17, nameOption = "Evaluation 1", controller = "Home", action = "Blank", status = true, isParent = false, parentId = 16 });
            menu.Add(new Navbar { Id = 18, nameOption = "Evaluation 2", controller = "Home", action = "Blank", status = true, isParent = false, parentId = 16 });

            return menu.ToList();
        }
    }
}