// See https://aka.ms/new-console-template for more information
using Hexa.NET.MiniAudio;

MaResult result;
MaEngineConfig config = MiniAudio.EngineConfigInit();
MaEngine engine = default;

result = MiniAudio.EngineInit(config, ref engine);
if (result != MaResult.Success)
{
    Console.WriteLine($"EngineInit failed: {result}");
    return;
}

MaSound sound = default;
result = MiniAudio.SoundInitFromFile(ref engine, "example.mp3", 0, default, default, ref sound);
if (result != MaResult.Success)
{
    Console.WriteLine($"SoundInitFromFile failed: {result}");
    MiniAudio.EngineUninit(ref engine);
    return;
}

result = MiniAudio.SoundStart(ref sound);
if (result != MaResult.Success)
{
    Console.WriteLine($"SoundStart failed: {result}");
    MiniAudio.SoundUninit(ref sound);
    MiniAudio.EngineUninit(ref engine);
    return;
}

Console.WriteLine("Playing example.mp3... Press any key to stop.");
while (MiniAudio.SoundIsPlaying(sound) != 0)
{
    Thread.Sleep(100);
    if (Console.KeyAvailable)
    {
        Console.ReadKey(true);
        break;
    }
}

MiniAudio.SoundUninit(ref sound);
MiniAudio.EngineUninit(ref engine);
Console.WriteLine("Playback finished.");