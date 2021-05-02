using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FTC.Data.Models
{
   public class SectionDbEntity:BaseDbEntity
    {
        public string Titel { get; set; }
        public string Discerption { get; set; }
        public string Image { get; set; }
        [ForeignKey("InformationId")]
        public InformationDbEntity Information { get; set; }
    }
}
