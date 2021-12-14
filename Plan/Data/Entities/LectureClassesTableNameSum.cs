using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.Data.Entities
{
    public class LectureClassesTableNameSum
    {
        [Key]
        public int Id { get; set; }
        public string NameColum { get; set; }
    }
}
