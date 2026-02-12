using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pure.Primitives.Abstractions.DayOfWeek;
using Pure.Primitives.DayOfWeek;

namespace Pure.Primitives.Abstractions.EFCore.Converters;

public sealed class DayOfWeekTypeConverter : ValueConverter<IDayOfWeek, System.DayOfWeek>
{
    public DayOfWeekTypeConverter()
        : base(x => ToSystemDayOfWeek(x), x => ToPureDayOfWeek(x)) { }

    private static System.DayOfWeek ToSystemDayOfWeek(IDayOfWeek dayOfWeek)
    {
        return dayOfWeek.DayNumberValue.NumberValue switch
        {
            1 => System.DayOfWeek.Monday,
            2 => System.DayOfWeek.Tuesday,
            3 => System.DayOfWeek.Wednesday,
            4 => System.DayOfWeek.Thursday,
            5 => System.DayOfWeek.Friday,
            6 => System.DayOfWeek.Saturday,
            7 => System.DayOfWeek.Sunday,
            _ => throw new ArgumentOutOfRangeException(
                nameof(dayOfWeek),
                dayOfWeek,
                null
            ),
        };
    }

    private static IDayOfWeek ToPureDayOfWeek(System.DayOfWeek dayOfWeek)
    {
        return dayOfWeek switch
        {
            System.DayOfWeek.Monday => new Monday(),
            System.DayOfWeek.Tuesday => new Tuesday(),
            System.DayOfWeek.Wednesday => new Wednesday(),
            System.DayOfWeek.Thursday => new Thursday(),
            System.DayOfWeek.Friday => new Friday(),
            System.DayOfWeek.Saturday => new Saturday(),
            System.DayOfWeek.Sunday => new Sunday(),
            _ => throw new ArgumentOutOfRangeException(
                nameof(dayOfWeek),
                dayOfWeek,
                null
            ),
        };
    }
}
