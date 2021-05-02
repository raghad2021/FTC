using System;
using System.Collections.Generic;
using System.Text;

namespace FTC.Data.Models
{
    public class BaseDbEntity
    {
        public int Id { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime CreateAt { get; set; }
        public bool IsDelete { get; set; }
    }
}
