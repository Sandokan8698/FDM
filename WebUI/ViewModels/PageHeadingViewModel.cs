using System.Collections.Generic;
using WebUI.Models;

namespace WebUI.ViewModels
{
    public class PageHeadingViewModel
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }

        public IEnumerable<SectionLink> Sections { get; set; }
    }
}