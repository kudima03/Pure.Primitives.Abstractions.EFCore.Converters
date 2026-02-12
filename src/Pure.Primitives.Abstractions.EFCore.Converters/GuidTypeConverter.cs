using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pure.Primitives.Abstractions.Guid;

namespace Pure.Primitives.Abstractions.EFCore.Converters;

public sealed class GuidTypeConverter : ValueConverter<IGuid, System.Guid>
{
    public GuidTypeConverter()
        : base(x => x.GuidValue, x => new Primitives.Guid.Guid(x)) { }
}
