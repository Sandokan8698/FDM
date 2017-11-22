using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebIU.Models;

namespace WebIU.ViewModels
{
    public class PageHeadingViewModel
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }

        public IEnumerable<SectionLink> Sections { get; set; }
    }
}