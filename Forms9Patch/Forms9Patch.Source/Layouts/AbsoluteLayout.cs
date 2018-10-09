﻿using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using static Xamarin.Forms.AbsoluteLayout;

namespace Forms9Patch
{
    /// <summary>
    /// Forms9Patch.AbsoluteLayout
    /// </summary>
    public class AbsoluteLayout : Layout<Xamarin.Forms.AbsoluteLayout>
    {
        /// <summary>
        /// Children of AbsoluteLayout
        /// </summary>
        public new IAbsoluteList<View> Children => ((Xamarin.Forms.AbsoluteLayout)_xfLayout).Children;

        /// <summary>
        /// Gets the layout bounds of element in AbsoluteLayout
        /// </summary>
        /// <returns>The layout bounds.</returns>
        /// <param name="bindable">Bindable.</param>
        [TypeConverter(typeof(BoundsTypeConverter))]
        public static Rectangle GetLayoutBounds(BindableObject bindable) => Xamarin.Forms.AbsoluteLayout.GetLayoutBounds(bindable);

        /// <summary>
        /// Gets the layout flags of element in AbsoluteLayout
        /// </summary>
        /// <returns>The layout flags.</returns>
        /// <param name="bindable">Bindable.</param>
        public static AbsoluteLayoutFlags GetLayoutFlags(BindableObject bindable) => Xamarin.Forms.AbsoluteLayout.GetLayoutFlags(bindable);

        /// <summary>
        /// Sets the layout bounds of element in AbsoluteLayout
        /// </summary>
        /// <param name="bindable">Bindable.</param>
        /// <param name="bounds">Bounds.</param>
        public static void SetLayoutBounds(BindableObject bindable, Rectangle bounds) => Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(bindable, bounds);

        /// <summary>
        /// Sets the layout flags of element in AbsoluteLayout
        /// </summary>
        /// <param name="bindable">Bindable.</param>
        /// <param name="flags">Flags.</param>
        public static void SetLayoutFlags(BindableObject bindable, AbsoluteLayoutFlags flags) => Xamarin.Forms.AbsoluteLayout.SetLayoutFlags(bindable, flags);

    }
}

