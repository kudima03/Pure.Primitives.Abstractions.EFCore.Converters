using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Abstractions.EFCore.Converters;

public sealed class UIntTypeConverter : ValueConverter<INumber<uint>, uint>
{
    public UIntTypeConverter()
        : base(x => x.NumberValue, x => new Primitives.Number.UInt(x)) { }
}
