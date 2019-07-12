using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class SetLimitForm : Form
    {
        public SetLimitForm()
        {
            InitializeComponent();
        }

        public int Limit
        {
            get
            {
                return (int)this.numericUpDown1.Value;
            }
        }

        public IEnumerable<string> Names
        {
            get
            {
                foreach(var n in this.richTextBox1.Lines.Where(s => s.Length != 0))
                {
                    yield return n;
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
