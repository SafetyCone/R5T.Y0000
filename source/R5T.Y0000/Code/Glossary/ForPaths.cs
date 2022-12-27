using System;

using R5T.T0156;


namespace R5T.Y0000
{
    public static partial class Glossary
    {
        [DocumentationMarker]
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

            /// <summary>
            /// <inheritdoc cref="Windows" path="/definition"/>
            /// </summary>
            /// <definition>Path uses the Windows directory separator.</definition>
            /// <name><i>windows</i></name>
            public static readonly object Windows;

            /// <summary>
            /// <inheritdoc cref="NonWindows" path="/definition"/>
            /// </summary>
            /// <definition>Path uses the Non-Windows directory separator.</definition>
            /// <name><i>non-windows</i></name>
            public static readonly object NonWindows;

            /// <summary>
            /// <inheritdoc cref="RootIndicated" path="/definition"/>
            /// </summary>
            /// <definition>A path is root-indicated if it starts with a directory separator.</definition>
            /// <name><i>root-indicated</i></name>
            public static readonly object RootIndicated;

            /// <summary>
            /// <inheritdoc cref="Strict" path="/definition"/>
            /// </summary>
            /// <definition>Many times, a path cannot be absolutely classified. (For example, is a path without any directory separators a Windows or non-Windows path?)</definition>
            /// <name><i>stric</i></name>
            public static readonly object Strict;
        }
    }
}
