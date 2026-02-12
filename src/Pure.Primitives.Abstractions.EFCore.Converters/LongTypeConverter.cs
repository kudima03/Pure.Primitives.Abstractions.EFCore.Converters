using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Abstractions.EFCore.Converters;

public sealed class LongTypeConverter : ValueConverter<INumber<long>, long>
{
    public LongTypeConverter()
        : base(x => x.NumberValue, x => new Primitives.Number.Long(x)) { }
}
