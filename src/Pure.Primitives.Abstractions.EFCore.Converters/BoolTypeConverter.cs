using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Bool;

namespace Pure.Primitives.Abstractions.EFCore.Converters;

public sealed class BoolTypeConverter : ValueConverter<IBool, bool>
{
    public BoolTypeConverter()
        : base(x => x.BoolValue, x => x ? new True() : new False()) { }
}
