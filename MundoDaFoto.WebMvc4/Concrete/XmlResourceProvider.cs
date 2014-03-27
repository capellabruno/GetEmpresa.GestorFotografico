using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Resources.Abstract;
using Resources.Entities;

namespace Resources.Concrete
{
    public class XmlResourceProvider: BaseResourceProvider
    {
        // File path
        private static string filePath = null;
        

        public XmlResourceProvider(){}
        public XmlResourceProvider(string filePath)
        {            
            XmlResourceProvider.filePath = filePath;

            if (!File.Exists(filePath)) throw new FileNotFoundException(string.Format("XML Resource file {0} was not found", filePath));
        }

        protected override IList<ResourceEntry> ReadResources()
        {
           
            // Parse the XML file
            return XDocument.Parse(File.ReadAllText(filePath))
                .Element("resources")
                .Elements("resource")
                .Select(e => new ResourceEntry {
                    IdGlobalization = int.Parse(e.Attribute("IdGlobalization").Value.ToString()),
                    Lang = e.Attribute("Lang").Value,
                    label = e.Attribute("label").Value,
                    OriginalText = e.Attribute("OriginalText").Value,
                    TranslateText = e.Attribute("TranslateText").Value                    
                }).ToList();
        }

        protected override ResourceEntry ReadResource(string name, string culture)
        {
            // Parse the XML file
            return XDocument.Parse(File.ReadAllText(filePath))
                .Element("resources")
                .Elements("resource")
                .Where(e => e.Attribute("label").Value == name && e.Attribute("lang").Value == culture)
                .Select(e => new ResourceEntry {
                    IdGlobalization = int.Parse(e.Attribute("IdGlobalization").Value.ToString()),
                    Lang = e.Attribute("Lang").Value,
                    label = e.Attribute("label").Value,
                    OriginalText = e.Attribute("OriginalText").Value,
                    TranslateText = e.Attribute("TranslateText").Value                    
                }).FirstOrDefault();
        }
    }
}
