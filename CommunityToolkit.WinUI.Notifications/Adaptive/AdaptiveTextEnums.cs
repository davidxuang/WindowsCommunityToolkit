// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace CommunityToolkit.WinUI.Notifications
{
    /// <summary>
    /// Text style controls font size, weight, and opacity.
    /// </summary>
    public enum AdaptiveTextStyle
    {
        /// <summary>
        /// Style is determined by the renderer.
        /// </summary>
        Default,

        /// <summary>
        /// Default value. Paragraph font size, normal weight and opacity.
        /// </summary>
        [EnumString("caption")]
        Caption,

        /// <summary>
        /// Same as Caption but with subtle opacity.
        /// </summary>
        [EnumString("captionSubtle")]
        CaptionSubtle,

        /// <summary>
        /// H5 font size.
        /// </summary>
        [EnumString("body")]
        Body,

        /// <summary>
        /// Same as Body but with subtle opacity.
        /// </summary>
        [EnumString("bodySubtle")]
        BodySubtle,

        /// <summary>
        /// H5 font size, bold weight. Essentially the bold version of Body.
        /// </summary>
        [EnumString("base")]
        Base,

        /// <summary>
        /// Same as Base but with subtle opacity.
        /// </summary>
        [EnumString("baseSubtle")]
        BaseSubtle,

        /// <summary>
        /// H4 font size.
        /// </summary>
        [EnumString("subtitle")]
        Subtitle,

        /// <summary>
        /// Same as Subtitle but with subtle opacity.
        /// </summary>
        [EnumString("subtitleSubtle")]
        SubtitleSubtle,

        /// <summary>
        /// H3 font size.
        /// </summary>
        [EnumString("title")]
        Title,

        /// <summary>
        /// Same as Title but with subtle opacity.
        /// </summary>
        [EnumString("titleSubtle")]
        TitleSubtle,

        /// <summary>
        /// Same as Title but with top/bottom padding removed.
        /// </summary>
        [EnumString("titleNumeral")]
        TitleNumeral,

        /// <summary>
        /// H2 font size.
        /// </summary>
        [EnumString("subheader")]
        Subheader,

        /// <summary>
        /// Same as Subheader but with subtle opacity.
        /// </summary>
        [EnumString("subheaderSubtle")]
        SubheaderSubtle,

        /// <summary>
        /// Same as Subheader but with top/bottom padding removed.
        /// </summary>
        [EnumString("subheaderNumeral")]
        SubheaderNumeral,

        /// <summary>
        /// H1 font size.
        /// </summary>
        [EnumString("header")]
        Header,

        /// <summary>
        /// Same as Header but with subtle opacity.
        /// </summary>
        [EnumString("headerSubtle")]
        HeaderSubtle,

        /// <summary>
        /// Same as Header but with top/bottom padding removed.
        /// </summary>
        [EnumString("headerNumeral")]
        HeaderNumeral
    }

    /// <summary>
    /// Controls the horizontal alignment of text.
    /// </summary>
    public enum AdaptiveTextAlign
    {
        /// <summary>
        /// Alignment is automatically determined by
        /// </summary>
        Default,

        /// <summary>
        /// The system automatically decides the alignment based on the language and culture.
        /// </summary>
        [EnumString("auto")]
        Auto,

        /// <summary>
        /// Horizontally align the text to the left.
        /// </summary>
        [EnumString("left")]
        Left,

        /// <summary>
        /// Horizontally align the text in the center.
        /// </summary>
        [EnumString("center")]
        Center,

        /// <summary>
        /// Horizontally align the text to the right.
        /// </summary>
        [EnumString("right")]
        Right
    }

    internal enum AdaptiveTextPlacement
    {
        /// <summary>
        /// Default value
        /// </summary>
        Inline,

        [EnumString("attribution")]
        Attribution
    }
}