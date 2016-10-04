﻿namespace OggVorbisEncoder.Setup.Templates.FloorBooks
{
    public class Line256X4Class0 : IStaticCodeBook
    {
        public int Dimensions { get; } = 1;

        public byte[] LengthList { get; } = {
            6, 7, 7, 12, 6, 6, 7, 12, 7, 6, 6, 10, 15, 12, 11, 13,
            7, 7, 8, 13, 7, 7, 8, 12, 7, 7, 7, 11, 12, 12, 11, 13,
            10, 9, 9, 11, 9, 9, 9, 10, 10, 8, 8, 12, 14, 12, 12, 14,
            11, 11, 12, 14, 11, 12, 11, 15, 15, 12, 13, 15, 15, 15, 15, 15,
            6, 6, 7, 10, 6, 6, 6, 11, 7, 6, 6, 9, 14, 12, 11, 13,
            7, 7, 7, 10, 6, 6, 7, 9, 7, 7, 6, 10, 13, 12, 10, 12,
            9, 9, 9, 11, 9, 9, 8, 9, 9, 8, 8, 10, 13, 12, 10, 12,
            12, 12, 11, 13, 12, 12, 11, 12, 15, 13, 12, 15, 15, 15, 14, 14,
            6, 6, 6, 8, 6, 6, 5, 6, 7, 7, 6, 5, 11, 10, 9, 8,
            7, 6, 6, 7, 6, 6, 5, 6, 7, 7, 6, 6, 11, 10, 9, 8,
            8, 8, 8, 9, 8, 8, 7, 8, 8, 8, 6, 7, 11, 10, 9, 9,
            14, 11, 10, 14, 14, 11, 10, 15, 13, 11, 9, 11, 15, 12, 12, 11,
            11, 9, 8, 8, 10, 9, 8, 9, 11, 10, 9, 8, 12, 11, 12, 11,
            13, 10, 8, 9, 11, 10, 8, 9, 10, 9, 8, 9, 10, 8, 12, 12,
            15, 11, 10, 10, 13, 11, 10, 10, 8, 8, 7, 12, 10, 9, 11, 12,
            15, 12, 11, 15, 13, 11, 11, 15, 12, 14, 11, 13, 15, 15, 13, 13
        };

        public CodeBookMapType MapType { get; } = CodeBookMapType.None;
        public int QuantMin { get; } = 0;
        public int QuantDelta { get; } = 0;
        public int Quant { get; } = 0;
        public int QuantSequenceP { get; } = 0;
        public int[] QuantList { get; } = null;
    }
}