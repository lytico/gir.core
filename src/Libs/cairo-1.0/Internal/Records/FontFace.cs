﻿using System;
using System.Runtime.InteropServices;

namespace Cairo.Internal
{
    public partial class FontFace
    {
        [DllImport(CairoImportResolver.Library, EntryPoint = "cairo_font_face_destroy")]
        public static extern void Destroy(IntPtr handle);
    }
}