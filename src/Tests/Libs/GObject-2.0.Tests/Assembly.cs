﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GObject.Tests;

[TestClass]
public static class Assembly
{
    [AssemblyInitialize]
    public static void Initialize(TestContext context)
    {
        Module.Initialize();
    }
}