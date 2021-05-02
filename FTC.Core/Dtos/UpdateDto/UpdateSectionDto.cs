using System;
using System.Collections.Generic;
using System.Text;

namespace FTC.Core.Dto.UpdateDto
{
   public class UpdateSectionDto
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Discerption { get; set; }
        public string Image { get; set; }
        public int InformationId { get; set; }

    }
}
