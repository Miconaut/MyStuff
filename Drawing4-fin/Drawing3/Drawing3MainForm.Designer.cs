namespace Drawing3
{
    partial class Drawing3MainForm
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
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.widthLabel = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.widthSlider = new System.Windows.Forms.TrackBar();
            this.w1 = new System.Windows.Forms.Label();
            this.w5 = new System.Windows.Forms.Label();
            this.w2 = new System.Windows.Forms.Label();
            this.w3 = new System.Windows.Forms.Label();
            this.w4 = new System.Windows.Forms.Label();
            this.colorPreview = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuGroupFile = new System.Windows.Forms.MenuItem();
            this.btnOpen = new System.Windows.Forms.MenuItem();
            this.btnSave = new System.Windows.Forms.MenuItem();
            this.ew4 = new System.Windows.Forms.Label();
            this.ew3 = new System.Windows.Forms.Label();
            this.ew2 = new System.Windows.Forms.Label();
            this.ew5 = new System.Windows.Forms.Label();
            this.ew1 = new System.Windows.Forms.Label();
            this.eraserWidthSlider = new System.Windows.Forms.TrackBar();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.widthSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraserWidthSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // saveDialog
            // 
            this.saveDialog.Filter = "Portable Network Graphics|*.png|All Files|*.*";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(619, 12);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(83, 13);
            this.widthLabel.TabIndex = 12;
            this.widthLabel.Text = "Width (Left Key)";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(513, 80);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 60);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Eraser (Right Key)";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(513, 12);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(100, 43);
            this.btnColor.TabIndex = 9;
            this.btnColor.Text = "COLOR";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.Color.White;
            this.drawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drawingPanel.Location = new System.Drawing.Point(10, 12);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(500, 499);
            this.drawingPanel.TabIndex = 8;
            this.drawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseDown);
            this.drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseMove);
            this.drawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseUp);
            // 
            // widthSlider
            // 
            this.widthSlider.Location = new System.Drawing.Point(619, 28);
            this.widthSlider.Maximum = 5;
            this.widthSlider.Minimum = 1;
            this.widthSlider.Name = "widthSlider";
            this.widthSlider.Size = new System.Drawing.Size(100, 45);
            this.widthSlider.TabIndex = 16;
            this.widthSlider.Value = 1;
            this.widthSlider.Scroll += new System.EventHandler(this.WidthSlider_Scroll);
            // 
            // w1
            // 
            this.w1.AutoSize = true;
            this.w1.Location = new System.Drawing.Point(624, 59);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(13, 13);
            this.w1.TabIndex = 17;
            this.w1.Text = "1";
            // 
            // w5
            // 
            this.w5.AutoSize = true;
            this.w5.Location = new System.Drawing.Point(698, 59);
            this.w5.Name = "w5";
            this.w5.Size = new System.Drawing.Size(13, 13);
            this.w5.TabIndex = 18;
            this.w5.Text = "5";
            // 
            // w2
            // 
            this.w2.AutoSize = true;
            this.w2.Location = new System.Drawing.Point(643, 59);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(13, 13);
            this.w2.TabIndex = 19;
            this.w2.Text = "2";
            // 
            // w3
            // 
            this.w3.AutoSize = true;
            this.w3.Location = new System.Drawing.Point(662, 59);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(13, 13);
            this.w3.TabIndex = 20;
            this.w3.Text = "3";
            // 
            // w4
            // 
            this.w4.AutoSize = true;
            this.w4.Location = new System.Drawing.Point(681, 60);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(13, 13);
            this.w4.TabIndex = 21;
            this.w4.Text = "4";
            // 
            // colorPreview
            // 
            this.colorPreview.BackColor = System.Drawing.Color.Black;
            this.colorPreview.Location = new System.Drawing.Point(513, 58);
            this.colorPreview.Name = "colorPreview";
            this.colorPreview.Size = new System.Drawing.Size(100, 15);
            this.colorPreview.TabIndex = 22;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuGroupFile});
            // 
            // menuGroupFile
            // 
            this.menuGroupFile.Index = 0;
            this.menuGroupFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.btnOpen,
            this.btnSave});
            this.menuGroupFile.Text = "File";
            // 
            // btnOpen
            // 
            this.btnOpen.Index = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Index = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ew4
            // 
            this.ew4.AutoSize = true;
            this.ew4.Location = new System.Drawing.Point(681, 128);
            this.ew4.Name = "ew4";
            this.ew4.Size = new System.Drawing.Size(13, 13);
            this.ew4.TabIndex = 28;
            this.ew4.Text = "4";
            // 
            // ew3
            // 
            this.ew3.AutoSize = true;
            this.ew3.Location = new System.Drawing.Point(662, 127);
            this.ew3.Name = "ew3";
            this.ew3.Size = new System.Drawing.Size(13, 13);
            this.ew3.TabIndex = 27;
            this.ew3.Text = "3";
            // 
            // ew2
            // 
            this.ew2.AutoSize = true;
            this.ew2.Location = new System.Drawing.Point(643, 127);
            this.ew2.Name = "ew2";
            this.ew2.Size = new System.Drawing.Size(13, 13);
            this.ew2.TabIndex = 26;
            this.ew2.Text = "2";
            // 
            // ew5
            // 
            this.ew5.AutoSize = true;
            this.ew5.Location = new System.Drawing.Point(698, 127);
            this.ew5.Name = "ew5";
            this.ew5.Size = new System.Drawing.Size(13, 13);
            this.ew5.TabIndex = 25;
            this.ew5.Text = "5";
            // 
            // ew1
            // 
            this.ew1.AutoSize = true;
            this.ew1.Location = new System.Drawing.Point(624, 127);
            this.ew1.Name = "ew1";
            this.ew1.Size = new System.Drawing.Size(13, 13);
            this.ew1.TabIndex = 24;
            this.ew1.Text = "1";
            // 
            // eraserWidthSlider
            // 
            this.eraserWidthSlider.Location = new System.Drawing.Point(619, 96);
            this.eraserWidthSlider.Maximum = 5;
            this.eraserWidthSlider.Minimum = 1;
            this.eraserWidthSlider.Name = "eraserWidthSlider";
            this.eraserWidthSlider.Size = new System.Drawing.Size(100, 45);
            this.eraserWidthSlider.TabIndex = 23;
            this.eraserWidthSlider.Value = 1;
            this.eraserWidthSlider.Scroll += new System.EventHandler(this.EraserWidthSlider_Scroll);
            // 
            // Drawing3MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 542);
            this.Controls.Add(this.ew4);
            this.Controls.Add(this.ew3);
            this.Controls.Add(this.ew2);
            this.Controls.Add(this.ew5);
            this.Controls.Add(this.ew1);
            this.Controls.Add(this.eraserWidthSlider);
            this.Controls.Add(this.colorPreview);
            this.Controls.Add(this.w4);
            this.Controls.Add(this.w3);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.w5);
            this.Controls.Add(this.w1);
            this.Controls.Add(this.widthSlider);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.drawingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "Drawing3MainForm";
            this.ShowIcon = false;
            this.Text = "Drawing";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Drawing3MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Drawing3MainForm_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.widthSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraserWidthSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.TrackBar widthSlider;
        private System.Windows.Forms.Label w1;
        private System.Windows.Forms.Label w5;
        private System.Windows.Forms.Label w2;
        private System.Windows.Forms.Label w3;
        private System.Windows.Forms.Label w4;
        private System.Windows.Forms.Label colorPreview;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuGroupFile;
        private System.Windows.Forms.MenuItem btnSave;
        private System.Windows.Forms.Label ew4;
        private System.Windows.Forms.Label ew3;
        private System.Windows.Forms.Label ew2;
        private System.Windows.Forms.Label ew5;
        private System.Windows.Forms.Label ew1;
        private System.Windows.Forms.TrackBar eraserWidthSlider;
        private System.Windows.Forms.MenuItem btnOpen;
        private System.Windows.Forms.OpenFileDialog openDialog;
    }
}

