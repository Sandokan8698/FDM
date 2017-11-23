using System.Collections.Generic;
using Domain.Entities;

namespace WebUI.ViewModels
{
    public class CoachEditCreateViewModel
    {
        public Coach Coach { get; set; }

        public IEnumerable<Sport> Sports { get; set; }

        public IEnumerable<string> HomeTowns { get; set; }
    }
}