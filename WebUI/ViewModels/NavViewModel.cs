using System.Collections.Generic;

namespace WebUI.ViewModels
{
    public class NavViewModel
    {
        public IEnumerable<string> Sports { get; set; }

        public string SelectedSport { get; set; }


    }
}