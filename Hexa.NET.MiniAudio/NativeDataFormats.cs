namespace Hexa.NET.MiniAudio
{
    public struct NativeDataFormats
    {
        public MaFormat Format;       /* Sample format. If set to ma_format_unknown, all sample formats are supported. */
        public uint Channels;     /* If set to 0, all channels are supported. */
        public uint SampleRate;   /* If set to 0, all sample rates are supported. */
        public uint Flags;        /* A combination of MA_DATA_FORMAT_FLAG_* flags. */
    }
}