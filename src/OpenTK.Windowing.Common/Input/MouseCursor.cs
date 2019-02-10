﻿//
// MouseCursor.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.Windowing.Common.Input
{
    /// <summary>
    /// Represents a predefined or custom mouse cursor.
    /// </summary>
    public sealed class MouseCursor : WindowIcon
    {
        private MouseCursor()
        {
        }

        /// <summary>
        /// Initializes a new <see cref="MouseCursor" /> instance from a
        /// contiguous array of BGRA pixels.
        /// Each pixel is composed of 4 bytes, representing B, G, R and A values,
        /// respectively. For correct antialiasing of translucent cursors,
        /// the B, G and R components should be premultiplied with the A component:
        ///  <code>
        /// B = (byte)((B * A) / 255)
        /// G = (byte)((G * A) / 255)
        /// R = (byte)((R * A) / 255)
        /// </code>
        /// </summary>
        /// <param name="hotx">The x-coordinate of the cursor hotspot, in the range [0, width]</param>
        /// <param name="hoty">The y-coordinate of the cursor hotspot, in the range [0, height]</param>
        /// <param name="width">The width of the cursor data, in pixels.</param>
        /// <param name="height">The height of the cursor data, in pixels.</param>
        /// <param name="data">
        /// A byte array representing the cursor image,
        /// laid out as a contiguous array of BGRA pixels.
        /// </param>
        public MouseCursor(int hotx, int hoty, int width, int height, byte[] data)
            : base(width, height, data)
        {
            if (hotx < 0 || hotx >= Width || hoty < 0 || hoty >= Height)
            {
                throw new ArgumentOutOfRangeException();
            }

            X = hotx;
            Y = hoty;
        }

        /// <summary>
        /// Initializes a new <see cref="MouseCursor" /> instance from a
        /// contiguous array of BGRA pixels.
        /// Each pixel is composed of 4 bytes, representing B, G, R and A values,
        /// respectively. For correct antialiasing of translucent cursors,
        /// the B, G and R components should be premultiplied with the A component:
        ///  <code>
        /// B = (byte)((B * A) / 255)
        /// G = (byte)((G * A) / 255)
        /// R = (byte)((R * A) / 255)
        /// </code>
        /// </summary>
        /// <param name="hotx">The x-coordinate of the cursor hotspot, in the range [0, width]</param>
        /// <param name="hoty">The y-coordinate of the cursor hotspot, in the range [0, height]</param>
        /// <param name="width">The width of the cursor data, in pixels.</param>
        /// <param name="height">The height of the cursor data, in pixels.</param>
        /// <param name="data">
        /// A pointer to the cursor image, laid out as a contiguous array of BGRA pixels.
        /// </param>
        public MouseCursor(int hotx, int hoty, int width, int height, IntPtr data)
            : base(width, height, data)
        {
            if (hotx < 0 || hotx >= Width || hoty < 0 || hoty >= Height)
            {
                throw new ArgumentOutOfRangeException();
            }

            X = hotx;
            Y = hoty;
        }

        internal int X { get; }
        internal int Y { get; }

        /// <summary>
        /// Gets the default mouse cursor for this platform.
        /// </summary>
        public static MouseCursor Default { get; } = new MouseCursor();

        /// <summary>
        /// Gets an empty (invisible) mouse cursor.
        /// </summary>
        public static MouseCursor Empty { get; } = new MouseCursor(
            0, 0, 16, 16, new byte[16 * 16 * 4]);
    }
}
