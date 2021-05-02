using System;
using System.Collections.Generic;
using System.Text;

namespace FTC.Core.ViewModel
{
   public class SectionViewModel
    { public int Id { get; set; }
        public string Titel { get; set; }
        public string Discerption { get; set; }
        public string Image { get; set; }
        public InformationViewModel Information { get; set; }

    }
}
