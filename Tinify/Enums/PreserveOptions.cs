namespace Tinify.Enums
{
    [Flags]
    public enum PreserveOptions
    {
        None = 0,
        Copyright = 1 << 0,
        Creation = 1 << 1,
        Location = 1 << 2
    }
}