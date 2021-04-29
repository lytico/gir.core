using System.Xml.Serialization;

namespace Repository.Xml
{
    public class ConstantInfo : Typed
    {
        [XmlAttribute("name")]
        public string? Name { get; set; }

        [XmlAttribute("value")]
        public string? Value { get; set; }

        [XmlElement("type")]
        public TypeInfo? Type { get; set; }
        
        [XmlElement("array")]
        public ArrayInfo? Array { get; set; }
        
        [XmlElement("doc")]
        public DocInfo? Doc { get; set; }
    }
}