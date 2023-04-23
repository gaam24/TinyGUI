using Tinify.Enums;

namespace Tinify.Operations
{
    public sealed record PreserveOperation
    {
        internal string[] Options { get; }

        public PreserveOperation(PreserveOptions options)
        {
            var list = new List<string>(3);

            if (options.HasFlag(PreserveOptions.Copyright))
                list.Add("copyright");
            if (options.HasFlag(PreserveOptions.Creation))
                list.Add("creation");
            if (options.HasFlag(PreserveOptions.Location))
                list.Add("location");

            Options = list.ToArray();
        }
    }
}