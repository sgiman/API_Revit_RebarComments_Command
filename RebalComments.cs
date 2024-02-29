using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;

namespace RebarComments
{
    class RebarCollectorСomments
    {
        //*****************************
        // GetRebars_Class
        //*****************************
        public List<Rebar> GetRebars(Document doc)
        {
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            ICollection<Element> Rebars = collector.OfClass(typeof(Rebar)).ToElements();
            List<Rebar> List_Rebars = new List<Rebar>();
            foreach (Rebar r in Rebars)
            {
                List_Rebars.Add(r);
            }
            return List_Rebars;
        }
    }

}
