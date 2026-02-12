using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pure.Primitives.Abstractions.Time;

namespace Pure.Primitives.Abstractions.EFCore.Converters;

public sealed class TimeTypeConverter : ValueConverter<ITime, TimeOnly>
{
    public TimeTypeConverter()
        : base(
            x => new TimeOnly(
                x.Hour.NumberValue,
                x.Minute.NumberValue,
                x.Second.NumberValue,
                x.Millisecond.NumberValue,
                x.Microsecond.NumberValue
            ),
            x => new Primitives.Time.Time(x)
        )
    { }
}
