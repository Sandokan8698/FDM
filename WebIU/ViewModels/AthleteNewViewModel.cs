using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.Entities;

namespace WebIU.ViewModels
{
    public class AthleteNewViewModel
    {
        public Athlete Athlete { get; set; }

        public IEnumerable<Sport> Sports { get; set; }
    }
}