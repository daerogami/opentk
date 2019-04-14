//
// MouseButtonEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using OpenToolkit.Windowing.Common;
using OpenToolkit.Windowing.Common.Input;

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Defines the event data for <see cref="IWindowEvents.MouseDown" />
    /// and <see cref="IWindowEvents.MouseUp" /> events.
    /// </summary>
    /// <remarks>
    ///  <para>
    /// Do not cache instances of this type outside their event handler.
    /// If necessary, you can clone an instance using the
    ///  <see cref="MouseButtonEventArgs(MouseButtonEventArgs)" /> constructor.
    ///  </para>
    /// </remarks>
    public class MouseButtonEventArgs : MouseEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MouseButtonEventArgs"/> class.
        /// </summary>
        public MouseButtonEventArgs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MouseButtonEventArgs"/> class.
        /// </summary>
        /// <param name="x">The X position.</param>
        /// <param name="y">The Y position.</param>
        /// <param name="button">The mouse button for the event.</param>
        /// <param name="pressed">The current state of the button.</param>
        public MouseButtonEventArgs(double x, double y, MouseButton button, bool pressed)
            : base(x, y)
        {
            Button = button;
            IsPressed = pressed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MouseButtonEventArgs"/> class.
        /// </summary>
        /// <param name="args">The <see cref="MouseButtonEventArgs" /> instance to clone.</param>
        public MouseButtonEventArgs(MouseButtonEventArgs args)
            : this(args.X, args.Y, args.Button, args.IsPressed)
        {
        }

        /// <summary>
        /// Gets the <see cref="MouseButton" /> that triggered this event.
        /// </summary>
        public MouseButton Button { get; internal set; }

        /// <summary>
        /// Gets the <see cref="InputAction"/> of the pressed button.
        /// </summary>
        public InputAction Action { get; internal set; }

        /// <summary>
        /// Gets the active <see cref="KeyModifiers"/> of the pressed button.
        /// </summary>
        public KeyModifiers Modifiers { get; internal set; }

        /// <summary>
        /// Gets a value indicating whether the <see cref="Button"/> which triggered this event was pressed or released.
        /// </summary>
        public bool IsPressed
        {
            get => GetButton(Button) == ButtonState.Pressed;
            internal set => SetButton(Button, value ? ButtonState.Pressed : ButtonState.Released);
        }
    }
}
