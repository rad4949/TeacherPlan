using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.Data.Entities
{
    public class WorkloadSum
    {
        [Key]
        [BindNever]
        public int Id { get; set; }
        public string NameWorkloadSum { get; set; }       

        public double TeachingBudPl { get; set; }
        public double TeachingBudVuc { get; set; }
        public double TeachingConPl { get; set; }
        public double TeachingConVuc { get; set; }

        public double OtherBudPl { get; set; }
        public double OtherBudVuc { get; set; }
        public double OtherConPl { get; set; }
        public double OtherConVuc { get; set; }

        public double AllBudPl { get; set; }
        public double AllBudVuc { get; set; }
        public double AllConPl { get; set; }
        public double AllConVuc { get; set; }

        public string EmailTeacher { get; set; }
        public int ColumId { get; set; }
    }
}
