using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.ViewModels
{
    public class AllUserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
    }

    public class ListAllUserViewModel
    {
        public int Page { get; set; }
        public int MaxPage { get; set; }
        public Filter Filter { get; set; }
        public List<AllUserViewModel> listAllUser { get; set; }
    }

    public class Filter
    {
        public string Name { get; set; }
    }
}
