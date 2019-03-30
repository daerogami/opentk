//
// MonitorEventArgs.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using OpenToolkit.Windowing.Common;

namespace OpenToolkit.Windowing.Desktop
{
    /// <summary>
    /// Defines the event data for the <see cref="NativeWindow.MonitorConnected"/> event.
    /// </summary>
    public class MonitorEventArgs : EventArgs // TODO: merge with JoystickEventArgs?
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorEventArgs"/> class.
        /// </summary>
        public MonitorEventArgs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorEventArgs"/> class.
        /// </summary>
        /// <param name="monitor">The <see cref="GraphicsLibraryFramework.Monitor"/> which triggered the event.</param>
        /// <param name="isConnected">Whether the <see cref="GraphicsLibraryFramework.Monitor"/> is connected.</param>
        public MonitorEventArgs(Monitor monitor, bool isConnected)
        {
            this.Monitor = monitor;
            this.IsConnected = isConnected;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorEventArgs"/> class.
        /// </summary>
        /// <param name="other">The <see cref="MonitorEventArgs" /> instance to clone.</param>
        public MonitorEventArgs(MonitorEventArgs other)
        {
            this.Monitor = other.Monitor;
            this.IsConnected = other.IsConnected;
        }

        /// <summary>
        /// Gets the <see cref="Monitor"/> which triggered the event.
        /// </summary>
        public Monitor Monitor { get; }

        /// <summary>
        /// Gets a value indicating whether the <see cref="Monitor"/> that triggered this event is connected or not.
        /// </summary>
        public bool IsConnected { get; }
    }
}
