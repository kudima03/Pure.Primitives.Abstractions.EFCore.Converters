using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Abstractions.EFCore.Converters;

public sealed class ULongTypeConverter : ValueConverter<INumber<ulong>, ulong>
{
    public ULongTypeConverter()
        : base(x => x.NumberValue, x => new Primitives.Number.ULong(x)) { }
}
