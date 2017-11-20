using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebIU.ViewModels
{
    public class NavViewModel
    {
        public IEnumerable<string> Sports { get; set; }

        public string SelectedSport { get; set; }


    }
}