using System;


namespace R5T.Y0000
{
    /// <summary>
    /// Documentation for .NET, C# language, and standard library concepts.
    /// </summary>
    public static partial class Documentation
    {
        /// <summary>
        /// "C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.21\"
        /// </summary>
        public static readonly object Example_RuntimeDirectoryPath;

        /// <summary>
        /// "Microsoft.NETCore.App"
        /// </summary>
        public static readonly object Example_RuntimeName;

        /// <summary>
        /// "C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.21\System.Private.CoreLib.dll"
        /// </summary>
        public static readonly object Example_CoreAssemblyFilePath;

        /// <summary>
        /// "6.0.21"
        /// </summary>
        public static readonly object Example_RuntimeVersion;

        /// <summary>
        /// Search pattern strings are used by <see cref="System.IO.Directory.EnumerateDirectories(string, string)"/>,
        /// for example.
        /// <para>
        /// Because search pattern functionality is so limited, it's better to just enumerate all files,
        /// then use a regex on the file path to be more specific.
        /// </para>
        /// </summary>
        /// <remarks>
        /// The search pattern is pretty minimal, it offers only two wildcard characters:
        /// <para>* - Matches zero-or-more characters.</para>
        /// <para>? - Matches exactly one character.</para>
        /// See "Remarks" here: <see href="https://learn.microsoft.com/en-us/dotnet/api/system.io.directory.getfiles?view=net-7.0"/>
        /// </remarks>
        public static readonly object For_SearchPattern;
    }
}