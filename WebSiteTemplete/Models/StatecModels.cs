using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteTemplete.Models
{
    public class StatecModels
    {
        public IEnumerable<Titles> Titles { get; set; }
        public IEnumerable<ParaGraphes> ParaGraphes { get; set; }
        public IEnumerable<MediaTypes> MediaTypes { get; set; }
    }
}