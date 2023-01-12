using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab.Problem4.RadioExceptions
{
    internal class InvalidSongException : Exception
    {
        public InvalidSongException() : base("Invalid song.") { }

        public InvalidSongException(string message) : base(message) { }
    }
}
