
namespace Total_Commander
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.bpLookButton = new System.Windows.Forms.Button();
            this.bpCopyButton = new System.Windows.Forms.Button();
            this.bpMoveButton = new System.Windows.Forms.Button();
            this.bpRenameButton = new System.Windows.Forms.Button();
            this.bpDeleteButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.BackColor = System.Drawing.Color.LightCyan;
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ButtonsPanel.Controls.Add(this.bpDeleteButton);
            this.ButtonsPanel.Controls.Add(this.bpRenameButton);
            this.ButtonsPanel.Controls.Add(this.bpMoveButton);
            this.ButtonsPanel.Controls.Add(this.bpCopyButton);
            this.ButtonsPanel.Controls.Add(this.bpLookButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 577);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(906, 39);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // bpLookButton
            // 
            this.bpLookButton.BackColor = System.Drawing.Color.LightCyan;
            this.bpLookButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bpLookButton.Location = new System.Drawing.Point(13, 7);
            this.bpLookButton.Name = "bpLookButton";
            this.bpLookButton.Size = new System.Drawing.Size(171, 23);
            this.bpLookButton.TabIndex = 0;
            this.bpLookButton.Text = "Просмотр сборки";
            this.bpLookButton.UseVisualStyleBackColor = false;
            // 
            // bpCopyButton
            // 
            this.bpCopyButton.BackColor = System.Drawing.Color.LightCyan;
            this.bpCopyButton.Location = new System.Drawing.Point(190, 7);
            this.bpCopyButton.Name = "bpCopyButton";
            this.bpCopyButton.Size = new System.Drawing.Size(171, 23);
            this.bpCopyButton.TabIndex = 1;
            this.bpCopyButton.Text = "Копирование";
            this.bpCopyButton.UseVisualStyleBackColor = false;
            // 
            // bpMoveButton
            // 
            this.bpMoveButton.BackColor = System.Drawing.Color.LightCyan;
            this.bpMoveButton.Location = new System.Drawing.Point(367, 7);
            this.bpMoveButton.Name = "bpMoveButton";
            this.bpMoveButton.Size = new System.Drawing.Size(171, 23);
            this.bpMoveButton.TabIndex = 2;
            this.bpMoveButton.Text = "Перемещение";
            this.bpMoveButton.UseVisualStyleBackColor = false;
            // 
            // bpRenameButton
            // 
            this.bpRenameButton.BackColor = System.Drawing.Color.LightCyan;
            this.bpRenameButton.Location = new System.Drawing.Point(544, 7);
            this.bpRenameButton.Name = "bpRenameButton";
            this.bpRenameButton.Size = new System.Drawing.Size(171, 23);
            this.bpRenameButton.TabIndex = 3;
            this.bpRenameButton.Text = "Переименование";
            this.bpRenameButton.UseVisualStyleBackColor = false;
            // 
            // bpDeleteButton
            // 
            this.bpDeleteButton.BackColor = System.Drawing.Color.LightCyan;
            this.bpDeleteButton.Location = new System.Drawing.Point(721, 7);
            this.bpDeleteButton.Name = "bpDeleteButton";
            this.bpDeleteButton.Size = new System.Drawing.Size(171, 23);
            this.bpDeleteButton.TabIndex = 4;
            this.bpDeleteButton.Text = "Удаление";
            this.bpDeleteButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 547);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(461, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 547);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cyan;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(461, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 547);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OrangeRed;
            this.panel4.Location = new System.Drawing.Point(461, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 547);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightCyan;
            this.panel5.Controls.Add(this.listView2);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(453, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(453, 547);
            this.panel5.TabIndex = 3;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(453, 43);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(-1, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(453, 43);
            this.panel7.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(447, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(447, 22);
            this.textBox2.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 78);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(447, 466);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.TypeHeader,
            this.SizeHeader,
            this.DateHeader});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(3, 78);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(447, 466);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Имя";
            this.NameHeader.Width = 130;
            // 
            // TypeHeader
            // 
            this.TypeHeader.Text = "Тип";
            this.TypeHeader.Width = 66;
            // 
            // SizeHeader
            // 
            this.SizeHeader.Text = "Размер";
            this.SizeHeader.Width = 76;
            // 
            // DateHeader
            // 
            this.DateHeader.Text = "Дата";
            this.DateHeader.Width = 172;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Тип";
            this.columnHeader2.Width = 66;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Размер";
            this.columnHeader3.Width = 76;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дата";
            this.columnHeader4.Width = 172;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 616);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Total Commander";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button bpLookButton;
        private System.Windows.Forms.Button bpMoveButton;
        private System.Windows.Forms.Button bpCopyButton;
        private System.Windows.Forms.Button bpDeleteButton;
        private System.Windows.Forms.Button bpRenameButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader TypeHeader;
        private System.Windows.Forms.ColumnHeader SizeHeader;
        private System.Windows.Forms.ColumnHeader DateHeader;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel7;
    }
}

