using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pure.Primitives.Abstractions.Date;

namespace Pure.Primitives.Abstractions.EFCore.Converters;

public sealed class DateTypeConverter : ValueConverter<IDate, DateOnly>
{
    public DateTypeConverter()
        : base(
            x => new DateOnly(x.Year.NumberValue, x.Month.NumberValue, x.Day.NumberValue),
            x => new Primitives.Date.Date(x)
        )
    { }
}
