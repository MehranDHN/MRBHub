using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MRBHub.Models.Common
{
    [Flags]
    public enum DAStandardType
    {
        Unknown = 1 << 0,
        WaltersArtTEIXML = 1 << 1,   
        PhyladelphiaTEIXML = 1 << 2,  
        IIIF = 1 << 3,   
        DublicCore = 1 << 4,
        MARCXML = 1 << 5,
        MODS = 1<< 6
    }
    public class Constants
    {

    }
}
