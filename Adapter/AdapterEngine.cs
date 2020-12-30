using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using MRBHub.Models.TEI.Walters;

namespace MRBHub.Adapter
{
    public class AdapterEngine : IAdapterEngine
    {
        public Task<WaltersTEIModel> WaltersParse(string targetUrl)
        {
            var doc = new XmlDocument();
            doc.Load("https://www.thedigitalwalters.org/Data/WaltersManuscripts/ManuscriptDescriptions/W808_tei.xml");
            //doc.Load("https://www.thedigitalwalters.org/Data/WaltersManuscripts/ManuscriptDescriptions/W578_tei.xml");

            string json = JsonConvert.SerializeXmlNode(doc).Replace("@", "").Replace("#", "").Replace("xml:", "xml").Replace("?", "");
            //File.WriteAllText("c:\\Bak\\ToJson2.json", json);
            var archive = JsonConvert.DeserializeObject<WaltersTEIModel>(json);

            Task<WaltersTEIModel> teiModel = Task.Factory.StartNew(() => JsonConvert.DeserializeObject<WaltersTEIModel>(json));

            return teiModel;
        }
    }
}
