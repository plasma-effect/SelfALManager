using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                foreach (var i in Range(this.dataGridView1.Rows.Count - 1))
                {
                    yield return (
                        this.dataGridView1[0, i].Value.ToString(),
                        int.TryParse(this.dataGridView1[1, i].Value.ToString(), out var level) ? (int?)level : null);
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
