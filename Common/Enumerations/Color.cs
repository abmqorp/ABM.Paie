using System.ComponentModel;

namespace Common.Enumerations;

public enum Color
{
    [Description("black")]
    Black,
    [Description("white")]
    White,
    [Description("primary")]
    Primary,
    [Description("primary-dark")]
    PrimaryDark,
    [Description("danger")]
    Danger,
    [Description("warning")]
    Warning,
    [Description("success")]
    Success,
    [Description("gray")]
    Gray,
    [Description("gray-light")]
    GrayLight,
    [Description("gray-dark")]
    GrayDark,
}
