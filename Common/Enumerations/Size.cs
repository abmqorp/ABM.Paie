using System.ComponentModel;

namespace Common.Enumerations;
public enum Size
{
    [Description("1rem")]
    NormalSize,
    [Description("0.125rem")]
    Tiny,
    [Description("0.25rem")]
    ScriptSize,
    [Description("0.5rem")]
    FootNoteSize,
    [Description("0.75rem")]
    Small,
    [Description("1.5rem")]
    Large,
    [Description("2rem")]
    Larger,
    [Description("2.5rem")]
    Huge,
    [Description("3rem")]
    Huger,
}
