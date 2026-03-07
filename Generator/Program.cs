using HexaGen;

GeneratorBuilder.Create<CsCodeGenerator>("generator.json")
    .Generate("include/miniaudio.h", "../../../../Hexa.NET.MiniAudio/Generated");