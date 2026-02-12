using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pure.Primitives.Abstractions.Char;

namespace Pure.Primitives.Abstractions.EFCore.Converters;

public sealed class CharTypeConverter : ValueConverter<IChar, char>
{
    public CharTypeConverter()
        : base(x => x.CharValue, x => new Primitives.Char.Char(x)) { }
}
