namespace GSE
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStage = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新加载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSaveFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewMember = new System.Windows.Forms.DataGridView();
            this.ColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonExpMax = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "金钱";
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(148, 243);
            this.textBoxMoney.MaxLength = 10;
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(250, 42);
            this.textBoxMoney.TabIndex = 1;
            this.textBoxMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMoney_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "关卡";
            // 
            // textBoxStage
            // 
            this.textBoxStage.Location = new System.Drawing.Point(148, 160);
            this.textBoxStage.MaxLength = 2;
            this.textBoxStage.Name = "textBoxStage";
            this.textBoxStage.Size = new System.Drawing.Size(120, 42);
            this.textBoxStage.TabIndex = 3;
            this.textBoxStage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStage_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1218, 47);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.重新加载ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(89, 43);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(251, 46);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(251, 46);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 重新加载ToolStripMenuItem
            // 
            this.重新加载ToolStripMenuItem.Name = "重新加载ToolStripMenuItem";
            this.重新加载ToolStripMenuItem.Size = new System.Drawing.Size(251, 46);
            this.重新加载ToolStripMenuItem.Text = "重新加载";
            this.重新加载ToolStripMenuItem.Click += new System.EventHandler(this.重新加载ToolStripMenuItem_Click);
            // 
            // openSaveFileDialog
            // 
            this.openSaveFileDialog.FileName = "openFileDialog1";
            this.openSaveFileDialog.Filter = "存档文件|*.TBL";
            this.openSaveFileDialog.Title = "打开存档文件";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "存档文件";
            // 
            // saveFileName
            // 
            this.saveFileName.AutoSize = true;
            this.saveFileName.Location = new System.Drawing.Point(165, 91);
            this.saveFileName.Name = "saveFileName";
            this.saveFileName.Size = new System.Drawing.Size(0, 30);
            this.saveFileName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "成员";
            // 
            // dataGridViewMember
            // 
            this.dataGridViewMember.AllowUserToAddRows = false;
            this.dataGridViewMember.AllowUserToDeleteRows = false;
            this.dataGridViewMember.AllowUserToOrderColumns = true;
            this.dataGridViewMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIndex,
            this.ColumnLevel,
            this.ColumnExp});
            this.dataGridViewMember.Location = new System.Drawing.Point(148, 390);
            this.dataGridViewMember.Name = "dataGridViewMember";
            this.dataGridViewMember.RowTemplate.Height = 44;
            this.dataGridViewMember.Size = new System.Drawing.Size(582, 548);
            this.dataGridViewMember.TabIndex = 9;
            // 
            // ColumnIndex
            // 
            this.ColumnIndex.DataPropertyName = "Index";
            this.ColumnIndex.HeaderText = "编号";
            this.ColumnIndex.MaxInputLength = 2;
            this.ColumnIndex.Name = "ColumnIndex";
            this.ColumnIndex.ReadOnly = true;
            this.ColumnIndex.Width = 127;
            // 
            // ColumnLevel
            // 
            this.ColumnLevel.DataPropertyName = "Level";
            this.ColumnLevel.HeaderText = "等级";
            this.ColumnLevel.MaxInputLength = 2;
            this.ColumnLevel.Name = "ColumnLevel";
            this.ColumnLevel.Width = 127;
            // 
            // ColumnExp
            // 
            this.ColumnExp.DataPropertyName = "Exp";
            this.ColumnExp.HeaderText = "经验";
            this.ColumnExp.MaxInputLength = 11;
            this.ColumnExp.Name = "ColumnExp";
            this.ColumnExp.Width = 127;
            // 
            // buttonExpMax
            // 
            this.buttonExpMax.Location = new System.Drawing.Point(148, 317);
            this.buttonExpMax.Name = "buttonExpMax";
            this.buttonExpMax.Size = new System.Drawing.Size(165, 55);
            this.buttonExpMax.TabIndex = 10;
            this.buttonExpMax.Text = "经验最大";
            this.buttonExpMax.UseVisualStyleBackColor = true;
            this.buttonExpMax.Click += new System.EventHandler(this.buttonExpMax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 1368);
            this.Controls.Add(this.buttonExpMax);
            this.Controls.Add(this.dataGridViewMember);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxStage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "魔界之泉 存档修改";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openSaveFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label saveFileName;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新加载ToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExp;
        private System.Windows.Forms.Button buttonExpMax;
    }
}

