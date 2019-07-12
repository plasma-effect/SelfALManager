using System;
using System.IO;
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

namespace Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KANSENData = new List<DataType>();
            this.Indexes = new SortedDictionary<string, int>();
            if (File.Exists(Properties.Settings.Default.Filename))
            {
                LoadData();
            }
            ShowKANSENData(this.KANSENData);
        }

        private void LoadData()
        {
            using (var stream = new StreamReader(Properties.Settings.Default.Filename))
            {
                var name = Predefined.Name.ToExpr();
                var count = Predefined.Chars.Create('0', '1', '2', '3').ToExpr((v, _) => int.Parse(v));
                var awaken = Predefined.Chars.Create('o', 'x').ToExpr((v, _) => v[0] == 'o');
                var remodel = Predefined.Chars.Create('0', '1', '2').ToExpr((v, _) =>
                v[0] == '0' ? RemodelingStatus.Unimplemented :
                v[0] == '1' ? RemodelingStatus.Waiting : RemodelingStatus.Remodeled);
                var love = Predefined.Chars.Create('o', 'x').ToExpr((v, _) => v[0] == 'o');
                var expr = name.Next(count).Next(awaken).Next(remodel).Next(love).ToExpr((a, b, c, d, e) => (a, b, c, d, e));
                var error = new List<int>();
                var line = 0;
                while (stream.ReadLine() is string str)
                {
                    ++line;
                    if (expr.ParseFullMatch(str, out var data, out _))
                    {
                        this.Indexes[data.a] = this.KANSENData.Count;
                        this.KANSENData.Add(new DataType(data.a, data.b, data.c, data.d, data.e));
                    }
                    else
                    {
                        error.Add(line);
                    }
                }
                if (error.Count != 0)
                {
                    var builder = new StringBuilder(error[0].ToString());
                    foreach (var e in error.Skip(1))
                    {
                        builder.Append($", {e}");
                    }
                    builder.AppendLine("行目にエラーが存在します");
                    MessageBox.Show(builder.ToString(), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private List<DataType> KANSENData;
        private SortedDictionary<string, int> Indexes;

        private void ShowKANSENData(IEnumerable<DataType> datas)
        {
            this.KANSENDataGrid.Rows.Clear();
            foreach(var data in datas)
            {
                var name = data.Name;
                var count = data.BreakCount;
                var awaken = data.Awaken ? "o" : "";
                var remodel =
                    data.RemodelingStatus == RemodelingStatus.Unimplemented ? "" :
                    data.RemodelingStatus == RemodelingStatus.Waiting ? "Waiting" : "Remodeled";
                var love = data.Love ? "o" : "";
                this.KANSENDataGrid.Rows.Add(name, count, awaken, remodel, love);
            }
        }

        private void AddKANSENClick(object sender, EventArgs e)
        {
            var form = new AddKANSENForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var names = new List<string>();
                foreach(var n in form.Names)
                {
                    if (this.Indexes.ContainsKey(n))
                    {
                        names.Add(n);
                    }
                    else
                    {
                        this.Indexes[n] = this.KANSENData.Count;
                        this.KANSENData.Add(new DataType(n, 0, false, RemodelingStatus.Unimplemented, false));
                    }
                }
                ShowErrorMessageBox(names, "はすでに存在します");
                ShowKANSENData(this.KANSENData);
            }
        }

        private void SetLimitClick(object sender, EventArgs e)
        {
            var form = new SetLimitForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var value = form.Limit;
                var names = new List<string>();
                foreach(var n in form.Names)
                {
                    if (this.Indexes.ContainsKey(n))
                    {
                        this.KANSENData[this.Indexes[n]].BreakCount = value;
                    }
                    else
                    {
                        names.Add(n);
                    }
                }
                ShowErrorMessageBox(names, "は存在しません");
                ShowKANSENData(this.KANSENData);
            }
        }

        private void ShowErrorMessageBox(List<string> names, string suffix)
        {
            if (names.Count != 0)
            {
                var builder = new StringBuilder($@"""{names[0]}""");
                foreach (var n in names.Skip(1))
                {
                    builder.Append($@", ""{n}""");
                }
                builder.AppendLine(suffix);
                MessageBox.Show(builder.ToString(), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public enum RemodelingStatus
    {
        Unimplemented,
        Waiting,
        Remodeled
    }

    public class DataType
    {
        public string Name { get; }
        public int BreakCount { set; get; }
        public bool Awaken { set; get; }
        public RemodelingStatus RemodelingStatus { get; set; }
        public bool Love { set; get; }

        public DataType(string name, int breakCount, bool awaken, RemodelingStatus remodelingStatus, bool love)
        {
            this.Name = name;
            this.BreakCount = breakCount;
            this.Awaken = awaken;
            this.RemodelingStatus = remodelingStatus;
            this.Love = love;
        }
    }
}
