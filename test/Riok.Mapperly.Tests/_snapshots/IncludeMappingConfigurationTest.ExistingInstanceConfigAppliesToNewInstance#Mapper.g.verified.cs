﻿//HintName: Mapper.g.cs
// <auto-generated />
#nullable enable
public partial class Mapper
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    public partial global::B MapOther(global::A source)
    {
        var target = new global::B();
        target.Target = source.Source;
        return target;
    }

    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    public partial void Map(global::A source, global::B target)
    {
        target.Target = source.Source;
    }
}