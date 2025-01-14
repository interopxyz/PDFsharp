// PDFsharp - A .NET library for processing PDF
// See the LICENSE file in the solution root for more information.

#if GDI
using System.Drawing;
using System.Drawing.Drawing2D;
#endif
#if WPF
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
#endif

namespace PdfSharp.Drawing
{
    /// <summary>
    /// Represents a combination of XFontFamily, XFontWeight, XFontStyleEx, and XFontStretch.
    /// </summary>
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + "}")]
    public class XTypeface
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XTypeface"/> class.
        /// </summary>
        /// <param name="typefaceName">Name of the typeface.</param>
        public XTypeface(string typefaceName) : 
            this(new XFontFamily(typefaceName), XFontStyles.Normal, XFontWeights.Normal, XFontStretches.Normal)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="XTypeface"/> class.
        /// </summary>
        /// <param name="family">The font family of the typeface.</param>
        /// <param name="style">The style of the typeface.</param>
        /// <param name="weight">The relative weight of the typeface.</param>
        /// <param name="stretch">The degree to which the typeface is stretched.</param>
        public XTypeface(XFontFamily family, XFontStyle style, XFontWeight weight, XFontStretch stretch)
        {
            Family = family;
            Style = style;
            Weight = weight;
            Stretch = stretch;
        }

        /// <summary>
        /// Gets the font family from which the typeface was constructed.
        /// </summary>
        public XFontFamily Family { get; }

        /// <summary>
        /// Gets the style of the Typeface.
        /// </summary>
        public XFontStyle Style { get; }

        /// <summary>
        /// Gets the relative weight of the typeface.
        /// </summary>
        public XFontWeight Weight { get; }

        /// <summary>
        /// Gets the stretch value for the Typeface.
        /// The stretch value determines whether a typeface is expanded or condensed when it is displayed.
        /// </summary>
        public XFontStretch Stretch { get; }

        /// <summary>
        /// Tries the get GlyphTypeface that corresponds to the Typeface.
        /// </summary>
        /// <param name="glyphTypeface">The glyph typeface that corresponds to this typeface,
        /// or null if the typeface was constructed from a composite font.
        /// </param>
        public bool TryGetGlyphTypeface(out XGlyphTypeface? glyphTypeface)
        {
            glyphTypeface = null;
            return false;
        }

        /// <summary>
        /// Gets the DebuggerDisplayAttribute text.
        /// </summary>
        string DebuggerDisplay => String.Format(CultureInfo.InvariantCulture, "XTypeface");
    }
}
