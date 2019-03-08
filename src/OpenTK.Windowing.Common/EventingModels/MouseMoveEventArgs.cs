//
// MouseMoveEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.Windowing.EventingModels
{
    /// <summary>
    /// Defines the event data for <see cref="MouseDevice.Move" /> events.
    /// </summary>
    /// <remarks>
    ///  <para>
    /// Do not cache instances of this type outside their event handler.
    /// If necessary, you can clone an instance using the
    ///  <see cref="MouseMoveEventArgs(MouseMoveEventArgs)" /> constructor.
    ///  </para>
    /// </remarks>
    public class MouseMoveEventArgs : MouseEventArgs
    {
        /// <summary>
        /// Constructs a new <see cref="MouseMoveEventArgs" /> instance.
        /// </summary>
        public MouseMoveEventArgs()
        {
        }

        /// <summary>
        /// Constructs a new <see cref="MouseMoveEventArgs" /> instance.
        /// </summary>
        /// <param name="x">The X position.</param>
        /// <param name="y">The Y position.</param>
        /// <param name="deltaX">The change in X position produced by this event.</param>
        /// <param name="deltaY">The change in Y position produced by this event.</param>
        public MouseMoveEventArgs(double x, double y, double deltaX, double deltaY)
            : base(x, y)
        {
            DeltaX = deltaX;
            DeltaY = deltaY;
        }

        /// <summary>
        /// Constructs a new <see cref="MouseMoveEventArgs" /> instance.
        /// </summary>
        /// <param name="args">The <see cref="MouseMoveEventArgs" /> instance to clone.</param>
        public MouseMoveEventArgs(MouseMoveEventArgs args)
            : this(args.X, args.Y, args.DeltaX, args.DeltaY)
        {
        }

        /// <summary>
        /// Gets the change in X position produced by this event.
        /// </summary>
        public double DeltaX { get; internal set; }

        /// <summary>
        /// Gets the change in Y position produced by this event.
        /// </summary>
        public double  DeltaY { get; internal set; }
    }
}