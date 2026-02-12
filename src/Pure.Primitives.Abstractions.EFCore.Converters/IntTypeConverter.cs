using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Abstractions.EFCore.Converters;

public sealed class IntTypeConverter : ValueConverter<INumber<int>, int>
{
    public IntTypeConverter()
        : base(x => x.NumberValue, x => new Primitives.Number.Int(x)) { }
}
