using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.Data.Entities
{
    public class UserNames
    {
        [Key]
        [BindNever]
        public int Id { get; set; }

        [ForeignKey("AspNetUsers")]
        public int DbUserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool Status { get; set; }
    }
}
