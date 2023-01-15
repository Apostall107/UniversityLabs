namespace InheritanceLab.Problem4.RadioExceptions {
    internal class InvalidSongNameException : InvalidSongException {
        public InvalidSongNameException() : base() { }

        public InvalidSongNameException(string message) : base(message) { }

        public InvalidSongNameException(int minNameLength, int maxNameLength)
            : base($"Song name should be between {minNameLength} and {maxNameLength} symbols.") {
        }
    }
}
