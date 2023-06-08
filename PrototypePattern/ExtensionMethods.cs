using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace PrototypePattern
{
    public static class ExtensionMethods
    {
        // Copying obects using this method requires classes to have [Serializable] attribute
        public static T DeepCopy<T>(this T self)
        {
            using var ms = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, self);
            ms.Seek(0, SeekOrigin.Begin);
            object copy = formatter.Deserialize(ms);
            return (T)copy;
        }

        // Copying obects using this method requires classes to have parameterless constructors
        public static T DeepCopyXml<T>(this T self)
        {
            using var ms = new MemoryStream();
            var serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(ms, self);
            ms.Position = 0;
            return (T)serializer.Deserialize(ms);
        }
    }
}
