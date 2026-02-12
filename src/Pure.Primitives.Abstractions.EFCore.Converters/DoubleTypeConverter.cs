using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Abstractions.EFCore.Converters;

public sealed class DoubleTypeConverter : ValueConverter<INumber<double>, double>
{
    public DoubleTypeConverter()
        : base(x => x.NumberValue, x => new Primitives.Number.Double(x)) { }
}
