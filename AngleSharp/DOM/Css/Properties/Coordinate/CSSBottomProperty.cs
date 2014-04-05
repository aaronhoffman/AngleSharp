﻿namespace AngleSharp.DOM.Css
{
    /// <summary>
    /// Information can be found on MDN:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/bottom
    /// </summary>
    sealed class CSSBottomProperty : CSSCoordinateProperty
    {
        #region ctor

        public CSSBottomProperty()
            : base(PropertyNames.Bottom)
        {
        }

        #endregion
    }
}
