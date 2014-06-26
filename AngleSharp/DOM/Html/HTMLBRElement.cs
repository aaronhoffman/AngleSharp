﻿namespace AngleSharp.DOM.Html
{
    using System;

    /// <summary>
    /// Represents the HTML br element.
    /// </summary>
    sealed class HTMLBRElement : HTMLElement, IHtmlBreakRowElement
    {
        #region ctor

        /// <summary>
        /// Creates a new HTML br element
        /// </summary>
        internal HTMLBRElement()
        {
            _name = Tags.Br;
        }

        #endregion

        #region Internal properties

        /// <summary>
        /// Gets if the node is in the special category.
        /// </summary>
        protected internal override Boolean IsSpecial
        {
            get { return true; }
        }

        #endregion
    }
}
