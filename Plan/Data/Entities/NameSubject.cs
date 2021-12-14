using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.Data.Entities
{
    public class NameSubject
    {
        [Key]
        public int Id { get; set; }       
        public string NameSubjects { get; set; }
    }
}
