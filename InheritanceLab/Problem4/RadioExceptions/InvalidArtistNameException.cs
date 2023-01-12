using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab.Problem4.RadioExceptions
{
    internal class InvalidArtistNameException : InvalidSongException
    {
        public InvalidArtistNameException() : base() { }

        public InvalidArtistNameException(string message) : base(message) { }

        public InvalidArtistNameException(int minNameLength, int maxNameLength)
            : base($"Artist name should be between {minNameLength} and {maxNameLength} symbols.")
        {
        }
    }
}
