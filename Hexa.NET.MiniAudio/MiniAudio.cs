namespace Hexa.NET.MiniAudio
{
    using System.Runtime.InteropServices;

    public static unsafe partial class MiniAudio
    {
        static MiniAudio()
        {
            InitApi();
        }

        public static string GetLibraryName()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return "miniaudio";
            }
            return "libminiaudio";
        }
    }
}