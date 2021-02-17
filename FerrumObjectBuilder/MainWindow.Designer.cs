namespace FerrumObjectBuilder
{
    partial class MainWindow
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
            this.designViewport = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameList = new System.Windows.Forms.ListBox();
            this.typeList = new System.Windows.Forms.ListBox();
            this.newSpriteButton = new System.Windows.Forms.Button();
            this.newHitboxButton = new System.Windows.Forms.Button();
            this.newPhysicsEntityButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // designViewport
            // 
            this.designViewport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.designViewport.Location = new System.Drawing.Point(12, 37);
            this.designViewport.Name = "designViewport";
            this.designViewport.Size = new System.Drawing.Size(483, 394);
            this.designViewport.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(794, 24);
            this.menuStrip.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.newToolStripMenuItem.Text = "New...";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Exit...";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.undoToolStripMenuItem.Text = "Undo...";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.redoToolStripMenuItem.Text = "Redo...";
            // 
            // nameList
            // 
            this.nameList.FormattingEnabled = true;
            this.nameList.Location = new System.Drawing.Point(501, 37);
            this.nameList.Name = "nameList";
            this.nameList.Size = new System.Drawing.Size(187, 394);
            this.nameList.TabIndex = 2;
            this.nameList.DoubleClick += new System.EventHandler(this.nameList_DoubleClick);
            // 
            // typeList
            // 
            this.typeList.Enabled = false;
            this.typeList.FormattingEnabled = true;
            this.typeList.Location = new System.Drawing.Point(694, 37);
            this.typeList.Name = "typeList";
            this.typeList.Size = new System.Drawing.Size(85, 394);
            this.typeList.TabIndex = 3;
            // 
            // newSpriteButton
            // 
            this.newSpriteButton.Location = new System.Drawing.Point(12, 437);
            this.newSpriteButton.Name = "newSpriteButton";
            this.newSpriteButton.Size = new System.Drawing.Size(98, 24);
            this.newSpriteButton.TabIndex = 4;
            this.newSpriteButton.Text = "New Sprite...";
            this.newSpriteButton.UseVisualStyleBackColor = true;
            this.newSpriteButton.Click += new System.EventHandler(this.newSpriteButton_Click);
            // 
            // newHitboxButton
            // 
            this.newHitboxButton.Location = new System.Drawing.Point(116, 437);
            this.newHitboxButton.Name = "newHitboxButton";
            this.newHitboxButton.Size = new System.Drawing.Size(98, 24);
            this.newHitboxButton.TabIndex = 5;
            this.newHitboxButton.Text = "New Hitbox...";
            this.newHitboxButton.UseVisualStyleBackColor = true;
            // 
            // newPhysicsEntityButton
            // 
            this.newPhysicsEntityButton.Location = new System.Drawing.Point(220, 437);
            this.newPhysicsEntityButton.Name = "newPhysicsEntityButton";
            this.newPhysicsEntityButton.Size = new System.Drawing.Size(143, 24);
            this.newPhysicsEntityButton.TabIndex = 6;
            this.newPhysicsEntityButton.Text = "New Physics Entity...";
            this.newPhysicsEntityButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(794, 466);
            this.Controls.Add(this.newPhysicsEntityButton);
            this.Controls.Add(this.newHitboxButton);
            this.Controls.Add(this.newSpriteButton);
            this.Controls.Add(this.typeList);
            this.Controls.Add(this.nameList);
            this.Controls.Add(this.designViewport);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.Text = "Ferrum Object Builder";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel designViewport;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ListBox nameList;
        private System.Windows.Forms.ListBox typeList;
        private System.Windows.Forms.Button newSpriteButton;
        private System.Windows.Forms.Button newHitboxButton;
        private System.Windows.Forms.Button newPhysicsEntityButton;
    }
}