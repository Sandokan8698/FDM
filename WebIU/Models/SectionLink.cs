using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebIU.Models
{
    public class SectionLink
    {
        public string Nombre { get; set; }

        public string Controller { get; set; }

        public string Action { get; set; }

        public object Parameters { get; set; }
    }
}