using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab.Problem4.RadioExceptions
{
    internal class InvalidSongLengthException : InvalidSongException 
    {
        public InvalidSongLengthException() : base("Invalid song length.") { }

        public InvalidSongLengthException(string message) : base(message) { }
    }
}
