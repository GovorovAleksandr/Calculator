using System.Linq;

namespace Calculation.Data
{
    internal static class Constants
    {
        public const int ZeroAscii = 48;
        public const int NineAscii = 57;
        public const int PlusAscii = 43;
        public const int SpaceAscii = 32;
        public const int CharactersRange = NineAscii - ZeroAscii + 1;
        
        public const char ZeroChar = (char)ZeroAscii;
        public const char PlusChar = (char)PlusAscii;
        public const char SpaceChar = (char)SpaceAscii;
        public const string StringTransfer = "\n";
        
        public static readonly char[] AvailableCharacters = Enumerable
            .Range(ZeroAscii, CharactersRange)
            .Select(i => (char)i)
            .Append((char)PlusAscii)
            .ToArray();
    }
}