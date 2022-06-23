using System;


namespace R5T.Y0000
{
    public static partial class Documentation
    {
        public static partial class ForGuid
        {
            /// <summary>
            /// <para>The B format is the D format, enclosed in braces:</para>
            /// <para>{9a19103f-16f7-4668-be54-9a1e7a4f7556}</para>
            /// <inheritdoc cref="ForGuid.GuidFormatsUrl"/>
            /// </summary>
            public static readonly object B_Format;

            /// <summary>
            /// <para>The B uppercase format is the D uppercase format, enclosed in braces:</para>
            /// <para>{9A19103F-16F7-4668-BE54-9A1E7A4F7556}</para>
            /// <inheritdoc cref="ForGuid.GuidFormatsUrl"/>
            /// </summary>
            public static readonly object B_Uppercase_Format;

            /// <summary>
            /// <para>The D format is 32 lower-case characters digits in groups of 8, 4, 4, 4, 12, separated by hyphens:</para>
            /// <para>9a19103f-16f7-4668-be54-9a1e7a4f7556</para>
            /// <para>This is the default format.</para>
            /// <inheritdoc cref="ForGuid.GuidFormatsUrl"/>
            /// </summary>
            public static readonly object D_Format;

            /// <summary>
            /// <para>The D uppercase format is 32 upper-case characters digits in groups of 8, 4, 4, 4, 12, separated by hyphens:</para>
            /// <para>9A19103F-16F7-4668-BE54-9A1E7A4F7556</para>
            /// <para>This is the default format.</para>
            /// <inheritdoc cref="ForGuid.GuidFormatsUrl"/>
            /// </summary>
            public static readonly object D_Uppercase_Format;

            /// <summary>
            /// <para>The N format is 32 consecutive lower-case characters and digits:</para>
            /// <para>9a19103f16f74668be549a1e7a4f7556</para>
            /// <inheritdoc cref="ForGuid.GuidFormatsUrl"/>
            /// </summary>
            public static readonly object N_Format;

            /// <summary>
            /// <para>The P format is the D format, enclosed in parentheses:</para>
            /// <para>(9a19103f-16f7-4668-be54-9a1e7a4f7556)</para>
            /// <inheritdoc cref="ForGuid.GuidFormatsUrl"/>
            /// </summary>
            public static readonly object P_Format;

            /// <summary>
            /// <para>The X format uses hexadecimal values enclosed in braces:</para>
            /// <para>{0x9a19103f,0x16f7,0x4668,{0xbe,0x54,0x9a,0x1e,0x7a,0x4f,0x75,0x56}}</para>
            /// <inheritdoc cref="ForGuid.GuidFormatsUrl"/>
            /// </summary>
            public static readonly object X_Format;

            /// <summary>
            /// Guid formats: <see href="https://docs.microsoft.com/en-us/dotnet/api/system.guid.tostring"/>
            /// </summary>
            public static readonly object GuidFormatsUrl;
        }
    }
}
