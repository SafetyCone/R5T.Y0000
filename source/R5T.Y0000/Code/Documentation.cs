using System;


namespace R5T.Y0000
{
    /// <summary>
    /// Documentation for .NET, C# language, and standard library concepts.
    /// </summary>
    public static partial class Documentation
    {
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