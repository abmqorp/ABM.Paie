using Common.Enumerations;
using Common.Models;

namespace Common.Extensions;

public static class UriModelExtensions
{
    extension(UriModel model)
    {
        public OperationModel ToDefaultOperation(string? anchor = default, string? activatorClass = default)
            => new(model.ToBase(anchor, "en savoir plus"), new(EndIcon: IconPath.ArrowCircleRight, Class: activatorClass));
    }
}
