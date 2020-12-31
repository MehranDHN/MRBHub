
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;
using Piranha.Extend.Fields;
using System.Collections;
using System.Collections.Generic;

namespace MRBHub.Models
{
    /// <summary>
    /// Basic page with main content in markdown.
    /// </summary>
    [SiteType(Title = "Standard Site")]
    public class StandardSite : SiteContent<StandardSite>
    {
        public StandardSite()
        {
            SectionsTitle = new List<StringField>();
        }
        [Region]
        public HtmlField Footer { get; set; }

        [Region]
        public StringField MainLayout { get; set; }

        [Region(Title = "Single Page?")]
        public CheckBoxField SinglePage { get; set; }

        [Region(Title = "Sections Caption", ListTitle ="Section List")]
        public List<StringField> SectionsTitle { get; set; }
    }
}
