﻿//
// IWindowInfo.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.Windowing.Interfaces
{
    /// <summary>
    /// Describes an OS window.
    /// </summary>
    public interface IWindowInfo : IDisposable
    {
        /// <summary>
        /// Retrieves a handle to this window.
        /// </summary>
        IntPtr Handle { get; }
    }
}