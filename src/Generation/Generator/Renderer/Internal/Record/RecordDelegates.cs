﻿using System;
using System.Linq;
using Generator.Model;

namespace Generator.Renderer.Internal;

internal static class RecordDelegates
{
    public static string Render(GirModel.Record record)
    {
        return $@"
using System;
using System.Runtime.InteropServices;

#nullable enable

namespace {Namespace.GetInternalName(record.Namespace)};

// AUTOGENERATED FILE - DO NOT MODIFY

public partial struct {Record.GetInternalStructName(record)}
{{
    {record.Fields
        .Select(x => x.AnyTypeOrCallback)
        .Where(x => x.IsT1)
        .Select(x => x.AsT1)
        .Select(Callback.Render)
        .Join(Environment.NewLine)}
}}";
    }
}
