using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseKeyboard
{
    public partial class Form1 : Form
    {
        //窗口失焦
        private const int WS_EX_TOOLWINDOOW = 0x00000080;//窗口失焦
        private const int WS_EX_NOACTIVATE = 0x08000000;//窗口失焦
        protected override CreateParams CreateParams//窗口失焦
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= (WS_EX_NOACTIVATE | WS_EX_TOOLWINDOOW);
                cp.Parent = IntPtr.Zero;
                return cp;
            }
        }

        public string code;

        public List<Morse> morses = new List<Morse>()
        {
            new Morse(".-", Keys.A),
            new Morse("-...", Keys.B),
            new Morse("-.-.", Keys.C),
            new Morse("-..", Keys.D),
            new Morse(".", Keys.E),
            new Morse("..-.", Keys.F),
            new Morse("--.", Keys.G),
            new Morse("....", Keys.H),
            new Morse("..", Keys.I),
            new Morse(".---", Keys.J),
            new Morse("-.-", Keys.K),
            new Morse(".-..", Keys.L),
            new Morse("--", Keys.M),
            new Morse("-.", Keys.N),
            new Morse("---", Keys.O),
            new Morse(".--.", Keys.P),
            new Morse("--.-", Keys.Q),
            new Morse(".-.", Keys.R),
            new Morse("...", Keys.S),
            new Morse("-", Keys.T),
            new Morse("..-", Keys.U),
            new Morse("...-", Keys.V),
            new Morse(".--", Keys.W),
            new Morse("-..-", Keys.X),
            new Morse("-.--", Keys.Y),
            new Morse("--..", Keys.Z),
            new Morse("-----", Keys.D0),
            new Morse(".----", Keys.D1),
            new Morse("..---", Keys.D2),
            new Morse("...--", Keys.D3),
            new Morse("....-", Keys.D4),
            new Morse(".....", Keys.D5),
            new Morse("-....", Keys.D6),
            new Morse("--...", Keys.D7),
            new Morse("---..", Keys.D8),
            new Morse("----.", Keys.D9),
            new Morse(".-.-.-", Keys.Decimal),
            new Morse("-....-", Keys.Subtract),
            new Morse("-..-.", Keys.Divide),
            new Morse(".-.-.", Keys.Add),
            new Morse("", Keys.None),
        };

        [DllImport("user32.dll", EntryPoint = "keybd_event")]//虚拟键盘输入p2x*x*
        public static extern void keybd_event//虚拟键盘输入.
        (
           byte bVK,//键码
          byte bSca,//硬件扫描码
        int dwFlags,
        int dwExtraInfo
        );
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Table table = new Table(morses);
            table.Show();
        }

        public void UpdateCode(string c)
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.ResourceManager.GetStream("Ding"));
            sound.Play();
            if(c != "/")
            {
                code += c;
                textBox1.Text = code;
            }
            else
            {
                foreach (Morse morse in morses)
                {
                    if(morse.code == this.code)
                    {
                        keybd_event((byte)((int)morse.key), 0, 0, 0);//Q按下
                        keybd_event((byte)((int)morse.key), 0, 0x02, 0);//Q弹起
                    }
                }
                code = "";
                textBox1.Text = code;
            }
        }

        private void dotBt_Click(object sender, EventArgs e)
        {
            UpdateCode(".");
        }

        private void barBt_Click(object sender, EventArgs e)
        {
            UpdateCode("-");
        }

        private void gBt_Click(object sender, EventArgs e)
        {
            UpdateCode("/");
        }
    }
}
//UG76MU7B7