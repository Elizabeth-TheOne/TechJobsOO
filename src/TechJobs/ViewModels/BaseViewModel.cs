﻿using System;
using System.Collections.Generic;
using TechJobs.Models;
using System.Threading.Tasks;
using System.Linq;

namespace TechJobs.ViewModels
{
    public class BaseViewModel
    {
        public List<JobFieldType> Columns { get; set; }
        public string Title { get; set; } = "";

        public BaseViewModel()
        {
            Columns = new List<JobFieldType>();

            foreach (JobFieldType enumVal in Enum.GetValues(typeof(JobFieldType)))
            {
                Columns.Add(enumVal);
            }
        }
    }
    //public JobFieldType Column { get; set; } = JobFieldType.All;
}
