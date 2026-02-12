using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Abstractions.EFCore.Converters;

public sealed class UShortTypeConverter : ValueConverter<INumber<ushort>, ushort>
{
    public UShortTypeConverter()
        : base(x => x.NumberValue, x => new Primitives.Number.UShort(x)) { }
}
