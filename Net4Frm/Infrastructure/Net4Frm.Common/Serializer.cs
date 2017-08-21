using ServiceStack.Text;

namespace System
{
    public class Serializer
    {
        public static string SerializerToString<T>(T value)
        {
            return TypeSerializer.SerializeToString<T>(value);
        }

        public static T DeserializeFromString<T>(string value)
        {
            return TypeSerializer.DeserializeFromString<T>(value);
        }
    }
}
