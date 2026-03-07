namespace Hexa.NET.MiniAudio
{
    public static unsafe partial class MiniAudio
    {
        static MiniAudio()
        {
            InitApi();
        }

        public static string GetLibraryName()
        {
            if (OperatingSystem.IsWindows())
            {
                return "miniaudio";
            }
            return "libminiaudio";
        }
    }
}