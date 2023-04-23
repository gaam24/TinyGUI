using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Tinify.Internal
{
    internal static class Platform
    {
        public static readonly string UserAgent = $"{GetClientVersion()} {GetFrameworkVersion()}".Trim();

        private static string GetClientVersion()
        {
            var asmName = typeof(Platform).Assembly.GetName();
            return $"{asmName.Name}/{asmName.Version}";
        }

        private static string GetFrameworkVersion()
        {
            /* Parsing based on:
             * https://github.com/mono/mono/blob/master/mcs/class/referencesource/System/sys/system/runtime/versioning/FrameworkName.cs/
             * Additional edits/modifications by Jeff Shergalis - Aug 2022
             * Modified to make use of Span to reduce allocations in some of the trimming and formatting code
             * Added use of string interpolation. Modified the for loop to start at 1 instead of 0 since the first entry
             * is already parsed and so an unnecessary loop iteration is being performed which includes a split, which
             * adds string allocations, etc.
             */
            var framework = typeof(Platform).Assembly.GetCustomAttribute<TargetFrameworkAttribute>()?.FrameworkName;
            if (framework is null)
                return string.Empty;

            var components = framework.Split(',');

            var libFrameworkName = components[0].Trim();
            var libFrameworkVersion = GetFrameworkVersion(components.Skip(1));

            return $"{libFrameworkName}/{libFrameworkVersion} ({GetOSPlatform()} {RuntimeInformation.FrameworkDescription})";
        }

        private static string GetFrameworkVersion(IEnumerable<string> components)
        {
            var versionSpan = "Version".AsSpan();
            foreach (var component in components)
            {
                var pair = component.Split('=');
                if (pair.Length != 2)
                    continue;

                if (!pair[0].AsSpan().Trim().Equals(versionSpan, StringComparison.OrdinalIgnoreCase))
                    continue;

                return pair[1].AsSpan().Trim().TrimStart('v').ToString();
            }

            return "unknown";
        }

        private static string GetOSPlatform()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return "Windows";
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                return "OSX";
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                return "Linux";
            return "Unknown";
        }
    }
}