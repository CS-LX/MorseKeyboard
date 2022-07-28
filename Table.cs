using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseKeyboard
{
    public partial class Table : Form
    {
        public List<Morse> morses = new List<Morse>();
        public Table(List<Morse> morses)
        {
            InitializeComponent();
            this.morses = morses;
        }

        private void Table_Load(object sender, EventArgs e)
        {
            UpdateList();
        }
        public void UpdateList()
        {
            listBox1.Items.Clear();
            listBox1.BeginUpdate();
            foreach (Morse morse in morses)
            {
                listBox1.Items.Add(morse.key.ToString() + ": " + morse.code);
            }
            listBox1.EndUpdate();
        }
    }
}
