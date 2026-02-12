using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Abstractions.EFCore.Converters;

public sealed class DecimalTypeConverter : ValueConverter<INumber<decimal>, decimal>
{
    public DecimalTypeConverter()
        : base(x => x.NumberValue, x => new Primitives.Number.Decimal(x)) { }
}
