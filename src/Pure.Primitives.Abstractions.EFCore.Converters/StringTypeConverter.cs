using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pure.Primitives.Abstractions.String;

namespace Pure.Primitives.Abstractions.EFCore.Converters;

public sealed class StringTypeConverter : ValueConverter<IString, string>
{
    public StringTypeConverter()
        : base(x => x.TextValue, x => new Primitives.String.String(x)) { }
}
