using System;
using StrawberryShake;
using StrawberryShake.Serializers;

namespace Demo
{
    public class UriValueSerializer: ValueSerializerBase<byte[], string>
    {
        public override string Name => "URI";

        public override ValueKind Kind => ValueKind.String;

        public override object? Serialize(object? value)
        {
            if (value is null)
            {
                return null;
            }

            if (value is string s)
            {
                return s;
            }

            throw new ArgumentException(
                "The specified value is of an invalid type. " +
                $"{ClrType.FullName} was expected.");
        }

        public override object? Deserialize(object? serialized)
        {
            if (serialized is null)
            {
                return null;
            }

            if (serialized is string s)
            {
                return s;
            }

            throw new ArgumentException(
                "The specified value is of an invalid type. " +
                $"{SerializationType.FullName} was expected.");
        }
    }
}
