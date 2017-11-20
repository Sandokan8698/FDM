using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.Entities;
using WebUI.Models;

namespace WebUI.ViewModels
{
    public class AthleteListViewModel
    {
        public IEnumerable<Athlete> Athletes { get; set; }

        public string CurrentSport { get; set; }
    }
}