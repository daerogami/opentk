﻿using System;

namespace OpenToolkit.GraphicsLibraryFramework
{
    public static class GLFWProvider
    {
        private static Lazy<GLFW> glfw = null;
        public static GLFW GLFW
        {
            get
            {
                if (glfw != null)
                {
                    return glfw.Value;
                }
                
                glfw = new Lazy<GLFW>(GLFW.GetAPI);
                
                lock (glfw.Value)
                {
                    glfw.Value.Init();
                    glfw.Value.SetErrorCallback(GLFW.errorCallback);
                }
                
                return glfw.Value;
            }
        }

        public static void Unload()
        {
            glfw.Value.Terminate();
            glfw = null;
        }
    }
}