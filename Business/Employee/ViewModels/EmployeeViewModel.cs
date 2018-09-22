using System;
using System.Collections.Generic;

namespace Business.ViewModels
{
    public class EmployeeViewModel
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
    }


    public class EmployeeSearchViewModel
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
    }

    public class EmployeeSearchResultViewModel
    {
        public EmployeeSearchResultViewModel()
        {

        }

        public List<EmployeeViewModel> items { get; set; }
        public int numPerPage { get; set; }
        public int currentPage { get; set; }
        public int totalRpws { get; set; }
    }
}

