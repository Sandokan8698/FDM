using System.Collections.Generic;
using Domain.Entities;

namespace WebUI.ViewModels
{
    public class AthleteNewViewModel
    {
        public Athlete Athlete { get; set; }

        public IEnumerable<Sport> Sports { get; set; }
    }
}