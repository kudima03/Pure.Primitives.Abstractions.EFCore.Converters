using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pure.Primitives.Abstractions.DateTime;

namespace Pure.Primitives.Abstractions.EFCore.Converters;

public sealed class DateTimeTypeConverter : ValueConverter<IDateTime, System.DateTime>
{
    public DateTimeTypeConverter()
        : base(
            x => new System.DateTime(
                x.Year.NumberValue,
                x.Month.NumberValue,
                x.Day.NumberValue,
                x.Hour.NumberValue,
                x.Minute.NumberValue,
                x.Second.NumberValue,
                x.Millisecond.NumberValue,
                x.Microsecond.NumberValue
            ),
            x => new Primitives.DateTime.DateTime(
                new Primitives.Date.Date(DateOnly.FromDateTime(x)),
                new Primitives.Time.Time(TimeOnly.FromDateTime(x))
            )
        )
    { }
}
