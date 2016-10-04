﻿namespace OggVorbisEncoder.Setup.Templates.Stereo44.BookBlocks.Chapter5
{
    public class Page9_1 : IStaticCodeBook
    {
        public int Dimensions { get; } = 2;

        public byte[] LengthList { get; } = {
            1, 4, 4, 5, 5, 7, 7, 9, 8, 10, 9, 10, 10, 11, 10, 11,
            11, 6, 5, 5, 7, 7, 8, 9, 10, 10, 11, 10, 12, 11, 12, 11,
            13, 12, 6, 5, 5, 7, 7, 9, 9, 10, 10, 11, 11, 12, 12, 13,
            12, 13, 13, 18, 8, 8, 8, 8, 9, 9, 10, 11, 11, 11, 12, 11,
            13, 11, 13, 12, 18, 8, 8, 8, 8, 10, 10, 11, 11, 12, 12, 13,
            13, 13, 13, 13, 14, 18, 12, 12, 9, 9, 11, 11, 11, 11, 12, 12,
            13, 12, 13, 12, 13, 13, 20, 13, 12, 9, 9, 11, 11, 11, 11, 12,
            12, 13, 13, 13, 14, 14, 13, 20, 18, 19, 11, 12, 11, 11, 12, 12,
            13, 13, 13, 13, 13, 13, 14, 13, 18, 19, 19, 12, 11, 11, 11, 12,
            12, 13, 12, 13, 13, 13, 14, 14, 13, 18, 17, 19, 14, 15, 12, 12,
            12, 13, 13, 13, 14, 14, 14, 14, 14, 14, 19, 19, 19, 16, 15, 12,
            11, 13, 12, 14, 14, 14, 13, 13, 14, 14, 14, 19, 18, 19, 18, 19,
            13, 13, 13, 13, 14, 14, 14, 13, 14, 14, 14, 14, 18, 17, 19, 19,
            19, 13, 13, 13, 11, 13, 11, 13, 14, 14, 14, 14, 14, 19, 17, 17,
            18, 18, 16, 16, 13, 13, 13, 13, 14, 13, 15, 15, 14, 14, 19, 19,
            17, 17, 18, 16, 16, 13, 11, 14, 10, 13, 12, 14, 14, 14, 14, 19,
            19, 19, 19, 19, 18, 17, 13, 14, 13, 11, 14, 13, 14, 14, 15, 15,
            19, 19, 19, 17, 19, 18, 18, 14, 13, 12, 11, 14, 11, 15, 15, 15,
            15
        };

        public CodeBookMapType MapType { get; } = CodeBookMapType.Implicit;
        public int QuantMin { get; } = -520814592;
        public int QuantDelta { get; } = 1620377600;
        public int Quant { get; } = 5;
        public int QuantSequenceP { get; } = 0;

        public int[] QuantList { get; } = {
            8,
            7,
            9,
            6,
            10,
            5,
            11,
            4,
            12,
            3,
            13,
            2,
            14,
            1,
            15,
            0,
            16
        };
    }
}