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
using static UtilityLibrary.IntegerEnumerable;

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
                LoadData(Properties.Settings.Default.Filename);
            }
            ShowKANSENData(this.KANSENData);
        }

        private void LoadData(string path)
        {
            using(var fs = new StreamReader(path))
            {
                var reader = new System.Xml.Serialization.XmlSerializer(typeof(List<DataType>));
                if(reader.Deserialize(fs) is List<DataType> list)
                {
                    this.KANSENData = list;
                }
                else
                {
                    MessageBox.Show($"{path}は壊れています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private List<DataType> KANSENData;
        private SortedDictionary<string, int> Indexes;

        private void ShowKANSENData(IEnumerable<DataType> datas)
        {
            ShowVariableData();
            this.KANSENDataGrid.Rows.Clear();
            foreach(var data in datas)
            {
                var name = data.Name;
                var gets = data.Gets ? "○" : "";
                var count = data.Gets ? data.BreakCount.ToString() : "";
                var awaken = data.Awaken ? "○" : "";
                var remodel =
                    data.RemodelingStatus == RemodelingStatus.Unimplement ? "" :
                    data.RemodelingStatus == RemodelingStatus.Waiting ? "実装済み" : "完了";
                var love = data.Love ? "○" : "";
                var story =
                    data.StoryStatus == StoryStatus.Unimplement ? "" :
                    data.StoryStatus == StoryStatus.Implement ? "実装済み" : "完了";
                this.KANSENDataGrid.Rows.Add(name, gets, count, awaken, remodel, love, story);
            }
        }

        private void ShowVariableData()
        {
            var all = 0;
            var gets = 0;
            var breaks = 0;
            var awaken = 0;
            var remodelImplement = 0;
            var remodeled = 0;
            var love = 0;
            var storyImplement = 0;
            var storyComplete = 0;
            foreach(var data in this.KANSENData)
            {
                ++all;
                if (data.Gets)
                {
                    ++gets;
                    if (data.BreakCount == 3)
                    {
                        ++breaks;
                    }
                    if (data.Awaken)
                    {
                        ++awaken;
                    }
                    if (data.RemodelingStatus != RemodelingStatus.Unimplement)
                    {
                        ++remodelImplement;
                    }
                    if (data.RemodelingStatus == RemodelingStatus.Remodeled)
                    {
                        ++remodeled;
                    }
                    if (data.Love)
                    {
                        ++love;
                    }
                    if (data.StoryStatus != StoryStatus.Unimplement)
                    {
                        ++storyImplement;
                    }
                    if (data.StoryStatus == StoryStatus.Complete)
                    {
                        ++storyComplete;
                    }
                }
            }
            this.getCountLabel.Text = $"{gets}/{all}";
            this.limitBreakCountLabel.Text = $"{breaks}/{all}";
            this.awakenCountLabel.Text = $"{awaken}/{all}";
            this.remodeledCountLabel.Text = $"{remodeled}/{remodelImplement}";
            this.loveCountLabel.Text = $"{love}/{all}";
            this.storyCompleteCountLabel.Text = $"{storyComplete}/{storyImplement}";
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

        private void AddKANSENClick(object sender, EventArgs e)
        {
            var form = new AddKANSENForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var exist = new List<string>();
                foreach(var n in form.Names)
                {
                    if (this.Indexes.ContainsKey(n))
                    {
                        exist.Add(n);
                    }
                    else
                    {
                        this.Indexes[n] = this.KANSENData.Count;
                        this.KANSENData.Add(new DataType(n));
                    }
                }
                ShowErrorMessageBox(exist, "はすでに存在します");
                ShowKANSENData(this.KANSENData);
            }
        }

        private void AddKANSENData(IEnumerable<string> names, bool gets, Func<DataType, bool> cond, Action<DataType> action, params (Func<DataType, bool> Cond, string Message)[] errors)
        {
            var none = new List<string>();
            var notgets = new List<string>();
            var lists = Range(errors.Length).Select(_ => new List<string>()).ToArray();
            foreach (var n in names)
            {
                if (!this.Indexes.ContainsKey(n))
                {
                    none.Add(n);
                    continue;
                }
                var data = this.KANSENData[this.Indexes[n]];
                if (gets && !data.Gets)
                {
                    notgets.Add(n);
                    continue;
                }
                if (cond(data))
                {
                    action(data);
                    continue;
                }
                foreach (var i in Range(errors.Length))
                {
                    if (!errors[i].Cond(data))
                    {
                        lists[i].Add(n);
                    }
                }
            }
            ShowErrorMessageBox(none, "は実装されていません");
            if (gets)
            {
                ShowErrorMessageBox(notgets, "は取得していません");
            }
            foreach (var i in Range(errors.Length))
            {
                ShowErrorMessageBox(lists[i], errors[i].Message);
            }
            ShowKANSENData(this.KANSENData);
        }

        private void SetLimitClick(object sender, EventArgs e)
        {
            var form = new SetLimitForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                AddKANSENData(form.Names, true, data => true, data => data.BreakCount = form.Limit);
            }
        }

        private void AwakenSetClick(object sender, EventArgs e)
        {
            var form = new AddKANSENForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                bool Check(DataType data)
                {
                    return data.BreakCount == 3;
                }
                AddKANSENData(form.Names, true, Check, data => data.Awaken = true,
                    (Check, "はまだ3回限界突破していません"));
            }
        }

        private void ImplementRemodelClick(object sender, EventArgs e)
        {
            var form = new AddKANSENForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                bool Check(DataType data)
                {
                    return data.RemodelingStatus != RemodelingStatus.Remodeled;
                }
                AddKANSENData(form.Names, false, Check, data => data.RemodelingStatus = RemodelingStatus.Waiting,
                    (Check, "は改造済みです"));
            }
        }

        private void RemodeledClick(object sender, EventArgs e)
        {
            var form = new AddKANSENForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                bool Three(DataType data)
                {
                    return data.BreakCount == 3;
                }
                bool Implement(DataType data)
                {
                    return data.RemodelingStatus != RemodelingStatus.Unimplement;
                }
                bool All(DataType data)
                {
                    return Three(data) && Implement(data);
                }
                AddKANSENData(form.Names, true, All, data => data.RemodelingStatus = RemodelingStatus.Remodeled,
                    (Three, "は3回限界突破していません"),
                    (Implement, "の改造は実装されていません"));
            }
        }

        private void LoveSetClick(object sender, EventArgs e)
        {
            var form = new AddKANSENForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                AddKANSENData(form.Names, true, data => true, data => data.Love = true);
            }
        }

        private void AddStoryClick(object sender, EventArgs e)
        {
            var form = new AddKANSENForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                bool Check(DataType data)
                {
                    return data.StoryStatus != StoryStatus.Complete;
                }
                AddKANSENData(form.Names, false, Check, data => data.StoryStatus = StoryStatus.Implement,
                    (Check, "のストーリーは完走済みです"));
            }
        }

        private void CompleteStoryClick(object sender, EventArgs e)
        {
            var form = new AddKANSENForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                bool Awaken(DataType data)
                {
                    return data.Awaken;
                }
                bool Love(DataType data)
                {
                    return data.Love;
                }
                bool Impliment(DataType data)
                {
                    return data.StoryStatus != StoryStatus.Unimplement;
                }
                bool All(DataType data)
                {
                    return Awaken(data) && Love(data) && Impliment(data);
                }
                AddKANSENData(form.Names, true, All, data => data.StoryStatus = StoryStatus.Complete,
                    (Awaken, "は認識覚醒していません"),
                    (Love, "は愛状態ではありません"),
                    (Impliment, "のストーリーは実装されていません"));
            }
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Filename = sfd.FileName;
                using (var fs = File.Create(sfd.FileName))
                {
                    var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<DataType>));
                    writer.Serialize(fs, this.KANSENData);
                }
            }
        }

        private void GetKANSENClick(object sender, EventArgs e)
        {
            var form = new AddKANSENForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var names = new List<string>();
                foreach (var n in form.Names)
                {
                    if (!this.Indexes.ContainsKey(n))
                    {
                        names.Add(n);
                    }
                    else
                    {
                        this.KANSENData[this.Indexes[n]].Gets = true;
                    }
                }
                ShowErrorMessageBox(names, "は存在しません");
                ShowKANSENData(this.KANSENData);
            }
        }
    }

    [Serializable]
    public enum RemodelingStatus
    {
        Unimplement,
        Waiting,
        Remodeled
    }

    [Serializable]
    public enum StoryStatus
    {
        Unimplement,
        Implement,
        Complete
    }

    [Serializable]
    public class DataType
    {
        public string Name { get; }
        public bool Gets { set; get; }
        public int BreakCount { set; get; }
        public bool Awaken { set; get; }
        public RemodelingStatus RemodelingStatus { get; set; }
        public bool Love { set; get; }
        public StoryStatus StoryStatus { get; set; }

        public DataType(string name)
        {
            this.Name = name;
            this.Gets = false;
            this.BreakCount = 0;
            this.Awaken = false;
            this.RemodelingStatus = RemodelingStatus.Unimplement;
            this.Love = false;
            this.StoryStatus = StoryStatus.Unimplement;
        }
    }
}
