//HintName: Mapper.g.cs
// <auto-generated />
#nullable enable
public partial class Mapper
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    public partial global::System.Linq.IQueryable<global::B?>? Map(global::System.Linq.IQueryable<global::A?>? q)
    {
        if (q == null)
            return default;
#nullable disable
        return System.Linq.Queryable.Select(q, x => new global::B(x.Value));
#nullable enable
    }

    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    private partial global::B? Map(global::A? source)
    {
        if (source == null)
            return default;
        var target = new global::B(source.Value);
        return target;
    }
}