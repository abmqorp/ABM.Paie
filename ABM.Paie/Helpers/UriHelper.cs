using ABM.Paie.Enumerations;
using ABM.Paie.Resources;

namespace ABM.Paie.Helpers;

public static class UriHelper
{
    public static string Get(Section section)
    {
        return section switch
        {
            >= (Section)10 and < (Section)20 => Get(Constants.AbmPaie, section),
            >= (Section)30 and < (Section)40 => Get(Constants.Contact, section),
            >= (Section)40 and < (Section)50 => Get(Constants.Experience, section),
            >= (Section)50 and < (Section)60 => Get(Constants.Formation, section),
            _ => throw new ArgumentException($"{section} is not a valid section")
        };
    }

    public static string Get(string page, Section section) => Get(page, section.ToString());

    public static string Get(string page, string section) => $"/{page}/{section}";

    public static string Get(string page) => $"/{page}";
}
