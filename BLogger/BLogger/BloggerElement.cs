namespace BLogger
{
    using System.Configuration;
    using System.Xml;

    public class BloggerElement : ConfigurationElement
    {
        public string Value { get; private set; }

        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
        {
            this.Value = reader.ReadElementContentAsString();
        }
    }
}
