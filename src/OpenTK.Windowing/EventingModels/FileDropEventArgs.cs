//
// FileDropEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.Windowing.EventingModels
{
    /// <summary>
    /// Defines the arguments for file drop events.
    /// This event is generated when a file is dragged and dropped onto the window.
    /// </summary>
    public class FileDropEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        public string FileName { get; internal set; }
    }
}
