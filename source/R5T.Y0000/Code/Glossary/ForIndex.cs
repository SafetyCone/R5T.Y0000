using System;


namespace R5T.Y0000
{
    public static partial class Glossary
    {
        public static partial class ForIndex
        {
            /// <summary>
            /// <inheritdoc cref="Index" path="/definition"/>
            /// Indices are usually positive (greater than zero), but ranges can be constructed to have negative indices (less than zero).
            /// Indices usually start at zero, but ranges can be constructed to start at indices both less than and greater than zero.
            /// </summary>
            /// <definition>An index is an integer that numerically indexes items in an ordered range from first to last.</definition>
            /// <name><i>index</i></name>
            public static readonly object Index;

            /// <summary>
            /// <inheritdoc cref="Exclusive" path="/definition"/>
            /// A range begins at the index one after the first exclusive index, and stops at the index one before the last exclusive index.
            /// <para><inheritdoc cref="ExclusiveInclusiveRelationship" path="/definition"/></para>
            /// </summary>
            /// <definition>An exclusive index is not included in a range.</definition>
            /// <name><i>exclusive</i></name>
            public static readonly object Exclusive;

            /// <summary> 
            /// <inheritdoc cref="Inclusive" path="/definition"/>
            /// A range beings at the first inclusive index, and stops at the last the inclusive index.
            /// <para><inheritdoc cref="ExclusiveInclusiveRelationship" path="/definition"/></para>
            /// </summary>
            /// <definition>An inclusive index is included in a range.</definition>
            /// <name><i>inclusive</i></name>
            public static readonly object Inclusive;

            /// <summary>
            /// <inheritdoc cref="ExclusiveInclusiveRelationship" path="/definition"/>
            /// </summary>
            /// <definition>The first <inheritdoc cref="Inclusive" path="/name"/> index begins one after the first <inheritdoc cref="Exclusive" path="/name"/> index, and the last <inheritdoc cref="Exclusive" path="/name"/> index begins one after the last <inheritdoc cref="Inclusive" path="/name"/> index.</definition>
            /// <name><i>exclusive-inclusive relationship</i></name>
            public static readonly object ExclusiveInclusiveRelationship;
        }
    }
}
