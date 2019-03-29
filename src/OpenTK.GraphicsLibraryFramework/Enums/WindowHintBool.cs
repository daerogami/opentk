//
// WindowHintBool.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// Context related boolean attributes.
    /// </summary>
    /// <seealso cref="IGLFW.WindowHint(WindowHintBool,bool)"/>
    public enum WindowHintBool
    {
        /// <summary>
        /// Indicates whether the specified window has input focus.
        /// Initial input focus is controlled by the window hint with the same name
        /// </summary>
        Focused = 0x00020001,

        /// <summary>
        /// Indicates whether the specified window is iconified,
        /// whether by the user or with <see cref="IGLFW.IconifyWindow"/>.
        /// </summary>
        Iconified = 0x00020002,

        /// <summary>
        /// Indicates whether the specified window is resizable by the user.
        /// This is set on creation with the window hint with the same name.
        /// </summary>
        Resizable = 0x00020003,

        /// <summary>
        /// Indicates whether the specified window is visible.
        /// Window visibility can be controlled with <see cref="IGLFW.ShowWindow"/> and <see cref="IGLFW.HideWindow"/>
        /// and initial visibility is controlled by the window hint with the same name.
        /// </summary>
        Visible = 0x00020004,

        /// <summary>
        /// Indicates whether the specified window has decorations such as a border,a close widget, etc.
        /// This is set on creation with the window hint with the same name.
        /// </summary>
        Decorated = 0x00020005,

        /// <summary>
        /// Specifies whether the full screen window will automatically iconify and restore
        /// the previous video mode on input focus loss.
        /// Possible values are <c>true</c> and <c>false</c>. This hint is ignored for windowed mode windows.
        /// </summary>
        AutoIconify = 0x00020006,

        /// <summary>
        /// Indicates whether the specified window is floating, also called topmost or always-on-top.
        /// This is controlled by the window hint with the same name.
        /// </summary>
        Floating = 0x00020007,

        /// <summary>
        /// Indicates whether the specified window is maximized,
        /// whether by the user or with <see cref="IGLFW.MaximizeWindow"/>.
        /// </summary>
        Maximized = 0x00020008,

        /// <summary>
        /// Specifies whether the cursor should be centered over newly created full screen windows.
        /// Possible values are <c>true</c> and <c>false</c>. This hint is ignored for windowed mode windows.
        /// </summary>
        CenterCursor = 0x00020009,

        /// <summary>
        /// Specifies whether the window framebuffer will be transparent.
        /// If enabled and supported by the system, the window framebuffer alpha channel will be used
        /// to combine the framebuffer with the background.
        /// This does not affect window decorations. Possible values are <c>true</c> and <c>false</c>.
        /// </summary>
        TransparentFramebuffer = 0x0002000A,

        /// <summary>
        /// Indicates whether the cursor is currently directly over the client area of the window,
        /// with no other windows between.
        /// See <a href="https://www.glfw.org/docs/3.3/input_guide.html#cursor_enter">Cursor enter/leave events</a>
        /// for details.
        /// </summary>
        Hovered = 0x0002000B,

        /// <summary>
        /// Specifies whether the window will be given input focus when <see cref="IGLFW.ShowWindow"/> is called.
        /// Possible values are <c>true</c> and <c>false</c>.
        /// </summary>
        FocusOnShow = 0x0002000C,

        /// <summary>
        /// Specifies whether the window's context is an OpenGL forward-compatible one.
        /// Possible values are <c>true</c> and <c>false</c>.
        /// </summary>
        OpenGLForwardCompat = 0x00022006,

        /// <summary>
        /// Specifies whether the window's context is an OpenGL debug context.
        /// Possible values are <c>true</c> and <c>false</c>.
        /// </summary>
        OpenGLDebugContext = 0x00022007,

        /// <summary>
        /// Specifies whether errors should be generated by the context.
        /// If enabled, situations that would have generated errors instead cause undefined behavior.
        /// </summary>
        ContextNoError = 0x0002200A,

        /// <summary>
        /// Specifies whether to use stereoscopic rendering. This is a hard constraint.
        /// </summary>
        Stereo = 0x0002100C,

        /// <summary>
        /// Specifies whether the framebuffer should be double buffered.
        /// You nearly always want to use double buffering. This is a hard constraint.
        /// </summary>
        DoubleBuffer = 0x00021010,

        /// <summary>
        /// Specifies whether the framebuffer should be sRGB capable.
        /// If supported, a created OpenGL context will support the
        /// <c>GL_FRAMEBUFFER_SRGB</c> enable( also called <c>GL_FRAMEBUFFER_SRGB_EXT</c>)
        /// for controlling sRGB rendering and a created OpenGL ES context will always have sRGB rendering enabled.
        /// </summary>
        SrgbCapable = 0x0002100E,
    }
}
