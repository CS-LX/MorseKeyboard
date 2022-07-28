using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseKeyboard
{
    public class Morse
    {
        public string code;
        public Keys key;


        public Morse(string code, Keys key)
        {
            this.code = code;
            this.key = key;
        }
    }
}
