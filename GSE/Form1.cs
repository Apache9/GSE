using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSE
{
    public partial class Form1 : Form
    {
        private SaveFile saveFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void setContent()
        {
            textBoxStage.Text = saveFile.Stage.ToString();
            textBoxMoney.Text = saveFile.Money.ToString();
            dataGridViewMember.DataSource = saveFile;
        }
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openSaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                saveFileName.Text = openSaveFileDialog.FileName;
                saveFile = new SaveFile(saveFileName.Text);
                setContent();
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStage.Text))
            {
                MessageBox.Show("关卡不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(textBoxMoney.Text))
            {
                MessageBox.Show("金钱不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (saveFile != null)
            {
                saveFile.Stage = UInt32.Parse(textBoxStage.Text);
                saveFile.Money = UInt32.Parse(textBoxMoney.Text);
                saveFile.Save();
            }
        }

        private void 重新加载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFile != null)
            {
                saveFile.Reload();
                setContent();
            }
        }

        private void textBoxMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBoxStage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void buttonExpMax_Click(object sender, EventArgs e)
        {
            saveFile.ExpMax();
            dataGridViewMember.Refresh();
        }
    }
}
