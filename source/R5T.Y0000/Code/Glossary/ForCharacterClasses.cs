using System;


namespace R5T.Y0000
{
    public static partial class Glossary
    {
        public static partial class ForCharacterClasses
        {
            /// <summary>
            /// <inheritdoc cref="Alphanumeric" path="/definition"/>
            /// The Alphanumeric class uses the signifier 'X'.
            /// </summary>
            /// <definition>The Alphanumeric class all <inheritdoc cref="Alpha" path="/name"/>s and <inheritdoc cref="Numeric" path="/name"/>s.</definition>
            /// <name><i>alphanumeric</i></name>
            public static readonly object Alphanumeric;

            /// <summary>
            /// <inheritdoc cref="Alpha" path="/definition"/>
            /// The Alpha class uses the signifier '@'.
            /// </summary>
            /// <definition>The Alpha class contains the uppercase and lowercase latin letters (A-Z, and a-z)</definition>
            /// <name><i>alpha</i></name>
            public static readonly object Alpha;

            /// <summary>
            /// <inheritdoc cref="Character" path="/definition"/>
            /// </summary>
            /// <definition>The Character class contains all characters. Any character is in this class.</definition>
            /// <name><i>control</i></name>
            public static readonly object Character;

            /// <summary>
            /// <inheritdoc cref="Control" path="/definition"/>
            /// </summary>
            /// <definition>The Control class contains non-printing control characters (like new line, tab, etc.).</definition>
            /// <name><i>control</i></name>
            public static readonly object Control;

            /// <summary>
            /// <inheritdoc cref="Digit" path="/definition"/>
            /// </summary>
            /// <definition>The Digit class contains the numerical digits 0-9.</definition>
            /// <name><i>digit</i></name>
            public static readonly object Digit;

            /// <summary>
            /// <inheritdoc cref="Letter" path="/definition"/>
            /// </summary>
            /// <definition>The Letter class contains all uppercase (A-Z), lowercase (a-z), and accented (ª-ÿ) letters.</definition>
            /// <name><i>letter</i></name>
            public static readonly object Letter;

            /// <summary>
            /// <inheritdoc cref="Lowercase" path="/definition"/>
            /// The Uppercase class uses the signifier '_'.
            /// </summary>
            /// <definition>The Lowercase class contains all lowercase latin (a-z) and accented (µ-ÿ) letters.</definition>
            /// <name><i>lowercase</i></name>
            public static readonly object Lowercase;

            /// <summary>
            /// <inheritdoc cref="Number" path="/definition"/>
            /// </summary>
            /// <definition>The Number class contains the digits (0-9), the exponents (², ³, and ¹), and the fractions (¼, ½, and ¾).</definition>
            /// <name><i>number</i></name>
            public static readonly object Number;

            /// <summary>
            /// <inheritdoc cref="Numeric" path="/definition"/>
            /// </summary>
            /// <definition><inheritdoc cref="Digit" path="/definition"/></definition>
            /// The Numeric class uses the signifier '#'.
            /// <name><i>numeric</i></name>
            public static readonly object Numeric;

            /// <summary>
            /// <inheritdoc cref="Punctuation" path="/definition"/>
            /// </summary>
            /// <definition>The Punctuation class contains the punctuation marks (! through ¿).</definition>
            /// <name><i>punctuation</i></name>
            public static readonly object Punctuation;

            /// <summary>
            /// <inheritdoc cref="Separator" path="/definition"/>
            /// </summary>
            /// <definition>The Separator class contains the separators (' ', space, and '', the non-breaking space (A0)).</definition>
            /// <name><i>separator</i></name>
            public static readonly object Separator;

            /// <summary>
            /// <inheritdoc cref="Symbol" path="/definition"/>
            /// </summary>
            /// <definition>The Symbol class contains the symbols ($ through ÷).</definition>
            /// <name><i>symbol</i></name>
            public static readonly object Symbol;

            /// <summary>
            /// <inheritdoc cref="Uppercase" path="/definition"/>
            /// The Uppercase class uses the signifier '^'.
            /// </summary>
            /// <definition>The Uppercase class contains the uppercase latin (A-Z) and accented (À-Þ) letters.</definition>
            /// <name><i>uppercase</i></name>
            public static readonly object Uppercase;

            /// <summary>
            /// <inheritdoc cref="Whitespace" path="/definition"/>
            /// </summary>
            /// <definition>The Whitespace class contains the whitespace characters tab through non-breaking-space.</definition>
            /// <name><i>whitespace</i></name>
            public static readonly object Whitespace;

            /// <summary>
            /// <inheritdoc cref="None" path="/definition"/>
            /// </summary>
            /// <definition>The None class contains no characters. No character is in this class.</definition>
            /// <name><i>control</i></name>
            public static readonly object None;
        }
    }
}
