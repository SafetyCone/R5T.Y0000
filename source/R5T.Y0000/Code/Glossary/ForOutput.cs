using System;

using R5T.T0156;


namespace R5T.Y0000
{
    public static partial class Glossary
    {
        [DocumentationMarker]
        public static partial class ForOutput
        {
            /// <summary>
            /// <inheritdoc cref="OutputByClosure" path="/definition"/>
            /// An action taking another action as a parameter does not *need* to declare and output type. Instead, outputs can be placed in variable references captured by the action parameter's closure.
            /// </summary>
            /// <definition>A closure can "pipe" it's outputs to output variables (like variable references or lists) by capturing them as part of its closure.</definition>
            /// <name><i>output-by-closure</i></name>
            public static readonly object OutputByClosure;
        }
    }
}
