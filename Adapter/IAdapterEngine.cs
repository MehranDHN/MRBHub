using MRBHub.Models.TEI.Walters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MRBHub.Adapter
{
    public interface IAdapterEngine
    {
        Task<WaltersTEIModel> WaltersParse(string targetUrl);
    }
}
