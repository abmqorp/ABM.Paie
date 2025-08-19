using System.ComponentModel;

namespace Common.Enumerations;
public enum Color
{
    [Description("--shade")]
    Shade,
    [Description("--shade-dark")]
    ShadeDark,
    [Description("--black")]
    Black,
    [Description("--white")]
    White,
    [Description("--primary")]
    Primary,
    [Description("--primary-dark")]
    PrimaryDark,
    [Description("--danger")]
    Danger,
    [Description("--warning")]
    Warning,
    [Description("--success")]
    Success,
    [Description("--gray-light")]
    GrayLight,
    [Description("--gray-dark")]
    GrayDark,
    [Description("--gray")]
    Gray,
    [Description("--partner")]
    Partner,
}
