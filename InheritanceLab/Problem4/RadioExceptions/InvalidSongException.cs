namespace InheritanceLab.Problem4.RadioExceptions {
    internal class InvalidSongException : Exception {
        public InvalidSongException() : base("Invalid song.") { }

        public InvalidSongException(string message) : base(message) { }
    }
}
