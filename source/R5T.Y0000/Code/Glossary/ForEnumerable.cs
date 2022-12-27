using System;

using R5T.T0156;


namespace R5T.Y0000
{
    public static partial class Glossary
    {
        [DocumentationMarker]
        public static partial class ForEnumerable
        {
            /// <summary>
            /// <inheritdoc cref="Comparison_EnumerationBehavior" path="/definition"/>
            /// </summary>
            /// <definition>
            /// When comparing enumerables (like for equality) should you stop on the first instance that is unequal, or should you continue through all elements?
            /// </definition>
            /// <name><i>enumeration behavior</i></name>
            public static readonly object Comparison_EnumerationBehavior;

            /// <summary>
            /// <inheritdoc cref="Comparison_OkIfUnequalLength" path="/definition"/>
            /// </summary>
            /// <definition>
            /// It's ok if the enumerables have different lengths.
            /// Only the common first number of elements are compared.
            /// <inheritdoc cref="Comparison_UnequalLengthBehavior" path="/definition"/>
            /// </definition>
            /// <name><i>ok-if-unequal length</i></name>
            public static readonly object Comparison_OkIfUnequalLength;

            /// <summary>
            /// <inheritdoc cref="Comparison_StopOnFirst" path="/definition"/>
            /// </summary>
            /// <definition>
            /// Stop on the first item of interest (do not enumerate all items).
            /// <inheritdoc cref="Comparison_EnumerationBehavior" path="/definition"/>
            /// </definition>
            /// <name><i>stop-on-first</i></name>
            public static readonly object Comparison_StopOnFirst;

            /// <summary>
            /// <inheritdoc cref="Comparison_ThroughAll" path="/definition"/>
            /// </summary>
            /// <definition>
            /// Enumerate all items (do not stop of the first item of interest).
            /// <inheritdoc cref="Comparison_EnumerationBehavior" path="/definition"/>
            /// </definition>
            /// <name><i>continue-through-all</i></name>
            public static readonly object Comparison_ThroughAll;

            /// <summary>
            /// <inheritdoc cref="Comparison_ThrowIfUnequalLength" path="/definition"/>
            /// </summary>
            /// <definition>
            /// It is not ok if the enumerables have different lengths.
            /// An exception is thrown if the enumerables are found to have differing lengths.
            /// <inheritdoc cref="Comparison_UnequalLengthBehavior" path="/definition"/>
            /// </definition>
            /// <name><i>throw-if-unequal length</i></name>
            public static readonly object Comparison_ThrowIfUnequalLength;

            /// <summary>
            /// <inheritdoc cref="Comparison_UnequalLengthBehavior" path="/definition"/>
            /// </summary>
            /// <definition>
            /// When comparing enumerables (like for equality) what should you do if the enumerables are found to have different lengths?
            /// </definition>
            /// <name><i>unequal length behavior</i></name>
            public static readonly object Comparison_UnequalLengthBehavior;
        }
    }
}
