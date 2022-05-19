
namespace View
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldSizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.size12MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.size24MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.size36MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.space = new System.Windows.Forms.ToolStripStatusLabel();
            this.helpStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.field = new System.Windows.Forms.TableLayoutPanel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.newGameMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(513, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.saveMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fileMenuItem.Text = "Fájl";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(169, 26);
            this.openMenuItem.Text = "Megnyitás...";
            this.openMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(169, 26);
            this.saveMenuItem.Text = "Mentés...";
            this.saveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // newGameMenuItem
            // 
            this.newGameMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fieldSizeMenuItem});
            this.newGameMenuItem.Name = "newGameMenuItem";
            this.newGameMenuItem.Size = new System.Drawing.Size(73, 24);
            this.newGameMenuItem.Text = "Új játék";
            // 
            // fieldSizeMenuItem
            // 
            this.fieldSizeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.size12MenuItem,
            this.size24MenuItem,
            this.size36MenuItem});
            this.fieldSizeMenuItem.Name = "fieldSizeMenuItem";
            this.fieldSizeMenuItem.Size = new System.Drawing.Size(165, 26);
            this.fieldSizeMenuItem.Text = "Pályaméret";
            this.fieldSizeMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.FieldSizeMenuItem_DropDownItemClicked);
            // 
            // size12MenuItem
            // 
            this.size12MenuItem.Name = "size12MenuItem";
            this.size12MenuItem.Size = new System.Drawing.Size(134, 26);
            this.size12MenuItem.Text = "12×12";
            // 
            // size24MenuItem
            // 
            this.size24MenuItem.Name = "size24MenuItem";
            this.size24MenuItem.Size = new System.Drawing.Size(134, 26);
            this.size24MenuItem.Text = "24×24";
            // 
            // size36MenuItem
            // 
            this.size36MenuItem.Name = "size36MenuItem";
            this.size36MenuItem.Size = new System.Drawing.Size(134, 26);
            this.size36MenuItem.Text = "36×36";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.timeStatusLabel,
            this.space,
            this.helpStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 466);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(513, 26);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(72, 20);
            this.toolStripStatusLabel1.Text = "Eltelt idő:";
            // 
            // timeStatusLabel
            // 
            this.timeStatusLabel.Name = "timeStatusLabel";
            this.timeStatusLabel.Size = new System.Drawing.Size(63, 20);
            this.timeStatusLabel.Text = "00:00:00";
            // 
            // space
            // 
            this.space.Name = "space";
            this.space.Size = new System.Drawing.Size(363, 20);
            this.space.Spring = true;
            // 
            // helpStatusLabel
            // 
            this.helpStatusLabel.Name = "helpStatusLabel";
            this.helpStatusLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // field
            // 
            this.field.BackColor = System.Drawing.Color.DarkGray;
            this.field.ColumnCount = 2;
            this.field.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.field.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.field.Dock = System.Windows.Forms.DockStyle.Fill;
            this.field.Location = new System.Drawing.Point(0, 28);
            this.field.Name = "field";
            this.field.RowCount = 2;
            this.field.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.field.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.field.Size = new System.Drawing.Size(513, 438);
            this.field.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 300;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "tmd";
            this.openFileDialog.Filter = "Tron Motor Dual files|*.tmd|All files|*.*";
            this.openFileDialog.FilterIndex = 2;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "tmd";
            this.saveFileDialog.Filter = "Tron Motor Dual files|*.tmd|All files|*.*";
            this.saveFileDialog.FilterIndex = 2;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 492);
            this.Controls.Add(this.field);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.Text = "Motorverseny";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fieldSizeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem size12MenuItem;
        private System.Windows.Forms.ToolStripMenuItem size24MenuItem;
        private System.Windows.Forms.ToolStripMenuItem size36MenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel timeStatusLabel;
        private System.Windows.Forms.TableLayoutPanel field;
        private System.Windows.Forms.ToolStripStatusLabel space;
        private System.Windows.Forms.ToolStripStatusLabel helpStatusLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}