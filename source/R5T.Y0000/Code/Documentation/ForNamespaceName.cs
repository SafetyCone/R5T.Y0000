using System;

using R5T.T0156;


namespace R5T.Y0000
{
    public static partial class Documentation
    {
        [DocumentationMarker]
        public static class ForNamespaceName
        {
            /// <summary>
            /// <inheritdoc cref="InvalidNamespaceName" path="/definition"/>
            /// </summary>
            /// <definition>Invalid namespace names contain invalid characters, are unescaped (non-contextual) keywords, or have the verbatim specifier (@) after the leading character.</definition>
            public static readonly object InvalidNamespaceName;

            /// <summary>
            /// <inheritdoc cref="RecommendedNamespaceName" path="/definition"/>
            /// </summary>
            /// <definition>Recommended namespace names start with a capital letter, and then have either uppercase and lowercase letters, digits, or underscores.</definition>
            public static readonly object RecommendedNamespaceName;

            /// <summary>
            /// <inheritdoc cref="UnrecommendedNamespaceName" path="/definition"/>
            /// </summary>
            /// <definition>Unrecommended namespace names are valid, but start with something other than a capital letter.</definition>
            public static readonly object UnrecommendedNamespaceName;

            /// <summary>
            /// <inheritdoc cref="ValidNamespaceName" path="/definition"/>
            /// </summary>
            /// <definition>Valid namespace names contain only valid characters, are escaped keywords, or have the verbatim specifier as the leading character.</definition>
            public static readonly object ValidNamespaceName;
        }
    }
}
