using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MRBHub.Models.Common
{
    public class EntryPoint
    {
        public int Pkid { get; set; }
        public string Title { get; set; }
        public string EnTitle { get; set; }
        public int StandardType { get; set; }
        public string ArchiveUniqueID { get; set; }
        public string Description { get; set; }
        public string ItemURL { get; set; }
        public string ReferenceID { get; set; }
    }
}
