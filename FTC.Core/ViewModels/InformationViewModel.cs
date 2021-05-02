using System;
using System.Collections.Generic;
using System.Text;

namespace FTC.Core.ViewModel
{
   public class InformationViewModel
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Logo { get; set; }
        public string WhataApp { get; set; }
        public string linkedIn { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string phone { get; set; }
        public string ppolicyURL { get; set; }
        public List<SectionViewModel> Section { get; set; }

    }
}
