using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.Entities;

namespace WebIU.ViewModels
{
    public class CoachEditCreateViewModel
    {
        public Coach Coach { get; set; }

        public IEnumerable<Sport> Sports { get; set; }

        public IEnumerable<string> HomeTowns { get; set; }
    }
}