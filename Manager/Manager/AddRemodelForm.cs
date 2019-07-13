using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PEGer;
using TrueRegex;
using static UtilityLibrary.IntegerEnumerable;


namespace Manager
{
    public partial class AddRemodelForm : Form
    {
        public AddRemodelForm()
        {
            InitializeComponent();
        }

        public IEnumerable<(string Name, int? Level)> Data
        {
            get
            {
                foreach(var line in this.richTextBox1.Lines)
                {
                    var ar = line.Split(',');
                    yield return (
                        ar[0],
                        int.TryParse(ar[1], out var ret) && 1 <= ret && ret <= 100 ? (int?)ret : null);
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
