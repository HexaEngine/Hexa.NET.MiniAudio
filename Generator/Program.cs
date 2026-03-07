using HexaGen;
using HexaGen.Patching;

GeneratorBuilder.Create<CsCodeGenerator>("generator.json")
    .WithPrePatch(new NamingPatch(["Ma"], NamingPatchOptions.CaseInsensitive))
    .Generate("include/miniaudio.h", "../../../../Hexa.NET.MiniAudio/Generated");