using System;
using System.Collections.Generic;
using System.Text;

namespace FTC.Core.Dto.CreateDto
{
   public class CreateInformationDto
    {
        public string Titel { get; set; }
        public string Logo { get; set; }
        public string WhataApp { get; set; }
        public string linkedIn { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string phone { get; set; }
        public string ppolicyURL { get; set; }
        public List<int> SectionId { get; set; }

    }
}
