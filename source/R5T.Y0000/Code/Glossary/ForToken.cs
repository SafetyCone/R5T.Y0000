using System;


namespace R5T.Y0000
{
    public static partial class Glossary
    {
        public static class ForToken
        {
            /// <summary>
            /// <inheritdoc cref="Token" path="/definition"/>
            /// </summary>
            /// <definition>A token is a part of a string that is separated from the rest of the string by one zero, one, or two <inheritdoc cref="TokenSeparator" path="/name"/>s.</definition>
            /// <name><i>token</i></name>
            public static readonly object Token;

            /// <summary>
            /// <inheritdoc cref="TokenSeparator" path="/definition"/>
            /// </summary>
            /// <definition>A token separator separates parts of a string into <inheritdoc cref="Token" path="/name"/>s.</definition>
            /// <name><i>token separator</i></name>
            public static readonly object TokenSeparator;
        }
    }
}
