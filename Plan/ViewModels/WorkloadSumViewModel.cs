using Plan.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.ViewModels
{
    public class WorkloadSumViewModel
    {
        public List<WorkloadSum> listWorkloadSum { get; set; }
        public AllUserViewModel userModel { get; set; }
    }
}
