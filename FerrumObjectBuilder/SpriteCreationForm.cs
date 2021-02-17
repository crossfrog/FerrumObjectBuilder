using System;
using System.IO;
using System.Xml.Serialization;
using System.Drawing;
using System.Windows.Forms;

namespace FerrumObjectBuilder
{
    public partial class SpriteCreationForm : ElementCreationForm
    {
        private Label label3;
        private TextBox texFileBox;
        private Button texFileBrowseButton;
        private Label label4;
        private NumericUpDown frameIndexBox;
        private NumericUpDown tileSizeBoxX;
        private NumericUpDown tileSizeBoxY;
        private Label label5;
        private Label label6;
        private Label label7;

        public SpriteCreationForm() : base()
        {
            InitializeComponent();
        }

        public override void LoadFromElement(Element element)
        {
            base.LoadFromElement(element);
            var sprite = element as SpriteElement;
            frameIndexBox.Value = sprite.FrameIndex;
            tileSizeBoxX.Value = sprite.TileSizeX;
            tileSizeBoxY.Value = sprite.TileSizeY;
        }

        protected override Element NewElement()
        {
            return new SpriteElement()
            {
                Name = nameBox.Text,
                OffsetX = float.Parse(offsetTextBoxX.Text),
                OffsetY = float.Parse(offsetTextBoxY.Text),
                FrameIndex = (int)frameIndexBox.Value,
                TileSizeX = (int)tileSizeBoxX.Value,
                TileSizeY = (int)tileSizeBoxY.Value
            };
        }

        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.texFileBox = new System.Windows.Forms.TextBox();
            this.texFileBrowseButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.frameIndexBox = new System.Windows.Forms.NumericUpDown();
            this.tileSizeBoxX = new System.Windows.Forms.NumericUpDown();
            this.tileSizeBoxY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frameIndexBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileSizeBoxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileSizeBoxY)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Texture file";
            // 
            // texFileBox
            // 
            this.texFileBox.Location = new System.Drawing.Point(12, 110);
            this.texFileBox.Name = "texFileBox";
            this.texFileBox.Size = new System.Drawing.Size(235, 20);
            this.texFileBox.TabIndex = 4;
            // 
            // texFileBrowseButton
            // 
            this.texFileBrowseButton.Location = new System.Drawing.Point(253, 110);
            this.texFileBrowseButton.Name = "texFileBrowseButton";
            this.texFileBrowseButton.Size = new System.Drawing.Size(61, 20);
            this.texFileBrowseButton.TabIndex = 5;
            this.texFileBrowseButton.Text = "Browse...";
            this.texFileBrowseButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Frame index";
            // 
            // frameIndexBox
            // 
            this.frameIndexBox.Location = new System.Drawing.Point(15, 160);
            this.frameIndexBox.Name = "frameIndexBox";
            this.frameIndexBox.Size = new System.Drawing.Size(83, 20);
            this.frameIndexBox.TabIndex = 7;
            // 
            // tileSizeBoxX
            // 
            this.tileSizeBoxX.Location = new System.Drawing.Point(231, 160);
            this.tileSizeBoxX.Name = "tileSizeBoxX";
            this.tileSizeBoxX.Size = new System.Drawing.Size(83, 20);
            this.tileSizeBoxX.TabIndex = 8;
            // 
            // tileSizeBoxY
            // 
            this.tileSizeBoxY.Location = new System.Drawing.Point(231, 186);
            this.tileSizeBoxY.Name = "tileSizeBoxY";
            this.tileSizeBoxY.Size = new System.Drawing.Size(83, 20);
            this.tileSizeBoxY.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pixels per tile";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "X:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Y:";
            // 
            // SpriteCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(326, 326);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tileSizeBoxY);
            this.Controls.Add(this.tileSizeBoxX);
            this.Controls.Add(this.frameIndexBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.texFileBrowseButton);
            this.Controls.Add(this.texFileBox);
            this.Controls.Add(this.label3);
            this.Name = "SpriteCreationForm";
            this.Text = "Create Sprite";
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.texFileBox, 0);
            this.Controls.SetChildIndex(this.texFileBrowseButton, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.frameIndexBox, 0);
            this.Controls.SetChildIndex(this.tileSizeBoxX, 0);
            this.Controls.SetChildIndex(this.tileSizeBoxY, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            ((System.ComponentModel.ISupportInitialize)(this.frameIndexBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileSizeBoxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileSizeBoxY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }

    public class SpriteElement : Element
    {
        public Image Texture;
        public int FrameIndex;
        public int TileSizeX;
        public int TileSizeY;
    }
}
