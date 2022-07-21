using System;


namespace R5T.Y0000
{
    public static partial class Glossary
    {
        public static partial class ForPaths
        {
            /// <summary>
            /// <inheritdoc cref="DirectoryIndicated" path="/definition"/>
            /// </summary>
            /// <definition>A path is directory indicated if it ends with either of the two directory separator characters.</definition>
            /// <name><i>directory indicated</i></name>
            public static readonly object DirectoryIndicated;

            /// <summary>
            /// <inheritdoc cref="DirectoryPath" path="/definition"/>
            /// </summary>
            /// <definition>The path to a directory.</definition>
            /// <name><i>directory path</i></name>
            public static readonly object DirectoryPath;

            /// <summary>
            /// <inheritdoc cref="FileIndicated" path="/definition"/>
            /// </summary>
            /// <definition>A path is file indicated if it does *not* end with either of the two directory separator characters.</definition>
            /// <name><i>file indicated</i></name>
            public static readonly object FileIndicated;

            /// <summary>
            /// <inheritdoc cref="FilePath" path="/definition"/>
            /// </summary>
            /// <definition>The path to a file.</definition>
            /// <name><i>file path</i></name>
            public static readonly object FilePath;
        }
    }
}
