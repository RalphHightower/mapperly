﻿// <auto-generated />
#nullable enable annotations
namespace Riok.Mapperly.IntegrationTests.Mapper
{
    public static partial class UseExternalMapper
    {
        [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
        public static partial global::Riok.Mapperly.IntegrationTests.Dto.IdObjectDto Map(global::Riok.Mapperly.IntegrationTests.Models.IdObject source)
        {
            var target = new global::Riok.Mapperly.IntegrationTests.Dto.IdObjectDto();
            target.IdValue = global::Riok.Mapperly.IntegrationTests.Mapper.UseExternalMapper.MyOtherMapper.MapInt(source.IdValue);
            return target;
        }
    }
}