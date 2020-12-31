using MRBHub.Models.Common;
using MRBHub.Models.TEI.Walters;
using Piranha.AttributeBuilder;
using Piranha.Models;
using System.Collections.Generic;

namespace MRBHub.Models
{
    [PageType(Title = "Standard page")]
    public class StandardPage  : Page<StandardPage>
    {
        public List<EntryPoint> EntryPoints { get; set; }
        public WaltersTEIModel ItemInfo { get; set; }
    }
}