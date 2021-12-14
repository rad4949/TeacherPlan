using Plan.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.ViewModels
{
    public class NameSubjectViewModel
    {
        public int Id { get; set; }
        public string NameSubjects { get; set; }
    }

    public class ListNameSubjectViewModel
    {
        public int Page { get; set; }
        public int MaxPage { get; set; }
        public Filter Filter { get; set; }
        public List<NameSubject> listNameSubject { get; set; }
    }   
}
