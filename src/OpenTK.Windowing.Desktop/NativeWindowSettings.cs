using OpenToolkit.GraphicsLibraryFramework;
using OpenToolkit.Mathematics;
using OpenToolkit.Windowing.Common;

namespace OpenToolkit.Windowing.Desktop
{
    public class NativeWindowSettings : INativeWindowProperties
    {
        /// <summary>
        /// Gets the default settings for a NativeWinow.
        /// </summary>
        public static readonly NativeWindowSettings Default = new NativeWindowSettings();

        public unsafe Monitor* CurrentMonitor { get; set; } = GLFWProvider.GLFW.Value.GetPrimaryMonitor();
        
        public string ClipboardString { get; set; }
        public string Title { get; set; } = "OpenTK Window";
        public bool Focused { get; set; } = true;
        public bool Visible { get; set; } = true;
        public bool Exists { get; }
        public WindowState WindowState { get; set; } = WindowState.Normal;
        public WindowBorder WindowBorder { get; set; } = WindowBorder.Resizable;
        public Box2 Bounds { get; set; }
        public Vector2 Location { get; set; }
        public Vector2 Size { get; set; }
        public int X { get; set; } = -1;
        public int Y { get; set; } = -1; //TODO: Find a way to set these equal to GLFW_DONT_CARE. For now, -1 will do.
        public int Width { get; set; } = 640;
        public int Height { get; set; } = 480;
        public Box2 ClientRectangle { get; set; }
        public Vector2 ClientSize { get; }

        public bool IsFullscreen { get; set; } = false;
    }
}