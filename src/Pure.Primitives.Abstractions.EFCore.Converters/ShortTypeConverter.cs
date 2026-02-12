using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Abstractions.EFCore.Converters;

public sealed class ShortTypeConverter : ValueConverter<INumber<short>, short>
{
    public ShortTypeConverter()
        : base(x => x.NumberValue, x => new Primitives.Number.Short(x)) { }
}
