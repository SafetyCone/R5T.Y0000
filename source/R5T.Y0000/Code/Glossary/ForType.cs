using System;


namespace R5T.Y0000
{
    public static partial class Glossary
    {
        public static class ForType
        {
            /// <summary>
            /// <inheritdoc cref="ClosedGeneric" path="/definition"/>
            /// </summary>
            /// <definition>A closed generic is a generic type that has all of it's type parameters specified. For example: List&lt;string&gt;, as opposed to the <inheritdoc cref="OpenGeneric" path="/name"/> List&lt;&gt;.</definition>
            /// <name><i>closed generic</i></name>
            public static readonly object ClosedGeneric;

            /// <summary>
            /// <inheritdoc cref="ConstructedGeneric" path="/definition"/>
            /// </summary>
            /// <definition>
            /// A constructed generic type is a <inheritdoc cref="GenericDefinition" path="/name"/> that has any of its generic type parameters filled-in.
            /// The process of "constructing" a generic type takes a <see cref="GenericDefinition" path="/name"/> and fills-in its generic type parameters.
            /// </definition>
            /// <name><i>closed generic</i></name>
            public static readonly object ConstructedGeneric;

            /// <summary>
            /// <inheritdoc cref="OpenGeneric" path="/definition"/>
            /// </summary>
            /// <definition>An open generic is a generic type that does not have any of it's type parameters specified. For example: List&lt;&gt;, as opposed to the <inheritdoc cref="ClosedGeneric" path="/name"/> List&lt;string&gt;.</definition>
            /// <name><i>open generic</i></name>
            public static readonly object OpenGeneric;

            /// <summary>
            /// <inheritdoc cref="PartiallyClosedGeneric" path="/definition"/>
            /// </summary>
            /// <definition>A partially closed generic is a generic type that has some of it's type parameters specified. For example: KeyValuePair&lt;string,&gt;, as opposed to the <inheritdoc cref="OpenGeneric" path="/name"/> KeyValuePair&lt;,&gt; or the <inheritdoc cref="ClosedGeneric" path="/name"/> KeyValuePair&lt;string,int&gt;.</definition>
            /// <name><i>closed generic</i></name>
            public static readonly object PartiallyClosedGeneric;

            /// <summary>
            /// <inheritdoc cref="PartiallyConstructedGeneric" path="/definition"/>
            /// </summary>
            /// <definition>A partially constructed generic is a generic type that has some of it's type parameters specified. For example: KeyValuePair&lt;string,&gt;, as opposed to the <inheritdoc cref="OpenGeneric" path="/name"/> KeyValuePair&lt;,&gt; or the <inheritdoc cref="ClosedGeneric" path="/name"/> KeyValuePair&lt;string,int&gt;.</definition>
            /// <name><i>closed generic</i></name>
            public static readonly object PartiallyConstructedGeneric;

            /// <summary>
            /// <inheritdoc cref="GenericDefinition" path="/definition"/>
            /// </summary>
            /// <definition>
            /// A generic definition type is a synonym for an <inheritdoc cref="OpenGeneric" path="/name"/> type, where none of the type parameters have been filled in.
            /// The process of filling-in the type parameters is called "constructing" the generic type, and results in a <inheritdoc cref="ConstructedGeneric" path="/name"/> type.
            /// </definition>
            /// <name><i>closed generic</i></name>
            public static readonly object GenericDefinition;
        }
    }
}
