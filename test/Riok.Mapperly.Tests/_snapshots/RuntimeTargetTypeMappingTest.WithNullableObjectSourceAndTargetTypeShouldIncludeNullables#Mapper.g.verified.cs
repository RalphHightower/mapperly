﻿//HintName: Mapper.g.cs
// <auto-generated />
#nullable enable
public partial class Mapper
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    public partial object? Map(object? source, global::System.Type targetType)
    {
        return source switch
        {
            int x when targetType.IsAssignableFrom(typeof(int)) => MapIntToInt(x),
            string x when targetType.IsAssignableFrom(typeof(int)) => MapStringToInt(x),
            global::A x when targetType.IsAssignableFrom(typeof(global::B)) => MapToB(x),
            global::C x when targetType.IsAssignableFrom(typeof(global::D)) => MapToD(x),
            null => default,
            _ => throw new System.ArgumentException($"Cannot map {source.GetType()} to {targetType} as there is no known type mapping", nameof(source)),
        };
    }

    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    private partial global::B MapToB(global::A source)
    {
        var target = new global::B();
        target.Value = source.Value;
        return target;
    }

    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    [return: global::System.Diagnostics.CodeAnalysis.NotNullIfNotNull(nameof(source))]
    private partial global::D? MapToD(global::C? source)
    {
        if (source == null)
            return default;
        var target = new global::D();
        target.Value2 = source.Value2;
        return target;
    }

    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    private partial int? MapStringToInt(string? source)
    {
        return source == null ? default(int?) : int.Parse(source);
    }

    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    private partial int? MapIntToInt(int source)
    {
        return (int?)source;
    }
}