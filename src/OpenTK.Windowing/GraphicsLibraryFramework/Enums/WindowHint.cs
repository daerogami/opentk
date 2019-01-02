﻿//
// WindowHint.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

// TODO: Need to create WindowAttrib enum and see if any need duplicate/moved to that one since there is a syntactic difference
namespace OpenToolkit.Windowing.GraphicsLibraryFramework.Enums
{
    public enum WindowHint
    {
        GLFW_FOCUSED = 0x00020001,
        GLFW_ICONIFIED = 0x00020002,
        GLFW_RESIZABLE = 0x00020003,
        GLFW_VISIBLE = 0x00020004,
        GLFW_DECORATED = 0x00020005,
        GLFW_AUTO_ICONIFY = 0x00020006,
        GLFW_FLOATING = 0x00020007,
        GLFW_MAXIMIZED = 0x00020008,

        GLFW_RED_BITS = 0x00021001,
        GLFW_GREEN_BITS = 0x00021002,
        GLFW_BLUE_BITS = 0x00021003,
        GLFW_ALPHA_BITS = 0x00021004,
        GLFW_DEPTH_BITS = 0x00021005,
        GLFW_STENCIL_BITS = 0x00021006,
        GLFW_ACCUM_RED_BITS = 0x00021007,
        GLFW_ACCUM_GREEN_BITS = 0x00021008,
        GLFW_ACCUM_BLUE_BITS = 0x00021009,
        GLFW_ACCUM_ALPHA_BITS = 0x0002100A,
        GLFW_AUX_BUFFERS = 0x0002100B,
        GLFW_STEREO = 0x0002100C,
        GLFW_SAMPLES = 0x0002100D,
        GLFW_SRGB_CAPABLE = 0x0002100E,
        GLFW_REFRESH_RATE = 0x0002100F,
        GLFW_DOUBLEBUFFER = 0x00021010,

        GLFW_CLIENT_API = 0x00022001,
        GLFW_CONTEXT_VERSION_MAJOR = 0x00022002,
        GLFW_CONTEXT_VERSION_MINOR = 0x00022003,
        GLFW_CONTEXT_REVISION = 0x00022004,
        GLFW_CONTEXT_ROBUSTNESS = 0x00022005,
        GLFW_OPENGL_FORWARD_COMPAT = 0x00022006,
        GLFW_OPENGL_DEBUG_CONTEXT = 0x00022007,
        GLFW_OPENGL_PROFILE = 0x00022008,
        GLFW_CONTEXT_RELEASE_BEHAVIOR = 0x00022009,
        GLFW_CONTEXT_NO_ERROR = 0x0002200A,
        GLFW_CONTEXT_CREATION_API = 0x0002200B
    }
}