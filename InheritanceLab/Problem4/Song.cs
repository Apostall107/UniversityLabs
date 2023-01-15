using InheritanceLab.Problem4.RadioExceptions;

namespace InheritanceLab.Problem4 {
    internal class Song {
        //constants for exceptions
        private const int ARTIST_MIN_LENGTH = 3;
        private const int ARTIST_MAX_LENGTH = 20;
        private const int NAME_MIN_LENGTH = 3;
        private const int NAME_MAX_LENGTH = 30;
        private const int MIN_MINUTES = 0;
        private const int MAX_MINUTES = 14;
        private const int MIN_SECONDS = 0;
        private const int MAX_SECONDS = 59;

        private string _artist;
        private string _name;
        private int _minutes;
        private int _seconds;

        public Song(string artist, string name, int minutes, int seconds) {
            Artist = artist;
            Name = name;
            Minutes = minutes;
            Seconds = seconds;
        }

        private string Artist {
            set {
                if (value.Length < ARTIST_MIN_LENGTH || value.Length > ARTIST_MAX_LENGTH)
                    throw new InvalidArtistNameException(ARTIST_MIN_LENGTH, ARTIST_MAX_LENGTH);

                _artist = value;
            }
        }

        private string Name {
            set {
                if (value.Length < NAME_MIN_LENGTH || value.Length > NAME_MAX_LENGTH)
                    throw new InvalidSongNameException(NAME_MIN_LENGTH, NAME_MAX_LENGTH);

                _name = value;
            }
        }

        public int Minutes {
            get => _minutes;
            set {
                if (value < MIN_MINUTES || value > MAX_MINUTES)
                    throw new InvalidSongMinutesException(MIN_MINUTES, MAX_MINUTES);

                _minutes = value;
            }
        }

        public int Seconds {
            get => _seconds;
            set {
                if (value < MIN_SECONDS || value > MAX_SECONDS)
                    throw new InvalidSongSecondsException(MIN_SECONDS, MAX_SECONDS);

                _seconds = value;
            }
        }
    }
}
