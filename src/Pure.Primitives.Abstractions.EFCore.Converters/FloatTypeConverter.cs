using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Abstractions.EFCore.Converters;

public sealed class FloatTypeConverter : ValueConverter<INumber<float>, float>
{
    public FloatTypeConverter()
        : base(x => x.NumberValue, x => new Primitives.Number.Float(x)) { }
}
