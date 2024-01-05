
namespace CvPlatformer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.GameWindow = new System.Windows.Forms.PictureBox();
            this.DebugPanel = new System.Windows.Forms.Panel();
            this.InRangeWindow = new System.Windows.Forms.PictureBox();
            this.ContourWindow = new System.Windows.Forms.PictureBox();
            this.CameraWindow = new System.Windows.Forms.PictureBox();
            this.TransformWindow = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SaveButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameWindow)).BeginInit();
            this.DebugPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InRangeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContourWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransformWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.SystemColors.Control;
            this.GamePanel.Controls.Add(this.GameWindow);
            this.GamePanel.Location = new System.Drawing.Point(13, 13);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(557, 315);
            this.GamePanel.TabIndex = 0;
            // 
            // GameWindow
            // 
            this.GameWindow.BackColor = System.Drawing.SystemColors.Control;
            this.GameWindow.Location = new System.Drawing.Point(3, 3);
            this.GameWindow.Name = "GameWindow";
            this.GameWindow.Size = new System.Drawing.Size(551, 309);
            this.GameWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameWindow.TabIndex = 0;
            this.GameWindow.TabStop = false;
            // 
            // DebugPanel
            // 
            this.DebugPanel.BackColor = System.Drawing.SystemColors.Control;
            this.DebugPanel.Controls.Add(this.InRangeWindow);
            this.DebugPanel.Controls.Add(this.ContourWindow);
            this.DebugPanel.Controls.Add(this.CameraWindow);
            this.DebugPanel.Controls.Add(this.TransformWindow);
            this.DebugPanel.Location = new System.Drawing.Point(13, 358);
            this.DebugPanel.Name = "DebugPanel";
            this.DebugPanel.Size = new System.Drawing.Size(557, 306);
            this.DebugPanel.TabIndex = 1;
            // 
            // InRangeWindow
            // 
            this.InRangeWindow.Location = new System.Drawing.Point(277, 155);
            this.InRangeWindow.Name = "InRangeWindow";
            this.InRangeWindow.Size = new System.Drawing.Size(269, 144);
            this.InRangeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InRangeWindow.TabIndex = 3;
            this.InRangeWindow.TabStop = false;
            // 
            // ContourWindow
            // 
            this.ContourWindow.Location = new System.Drawing.Point(3, 155);
            this.ContourWindow.Name = "ContourWindow";
            this.ContourWindow.Size = new System.Drawing.Size(268, 144);
            this.ContourWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ContourWindow.TabIndex = 2;
            this.ContourWindow.TabStop = false;
            // 
            // CameraWindow
            // 
            this.CameraWindow.Location = new System.Drawing.Point(277, 5);
            this.CameraWindow.Name = "CameraWindow";
            this.CameraWindow.Size = new System.Drawing.Size(269, 144);
            this.CameraWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CameraWindow.TabIndex = 1;
            this.CameraWindow.TabStop = false;
            // 
            // TransformWindow
            // 
            this.TransformWindow.Location = new System.Drawing.Point(3, 3);
            this.TransformWindow.Name = "TransformWindow";
            this.TransformWindow.Size = new System.Drawing.Size(268, 144);
            this.TransformWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TransformWindow.TabIndex = 0;
            this.TransformWindow.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 32;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(16, 332);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.TabStop = false;
            this.SaveButton.Text = "save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(97, 332);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.TabStop = false;
            this.UpdateButton.Text = "update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(578, 676);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DebugPanel);
            this.Controls.Add(this.GamePanel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.GamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GameWindow)).EndInit();
            this.DebugPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InRangeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContourWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransformWindow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.PictureBox GameWindow;
        private System.Windows.Forms.Panel DebugPanel;
        private System.Windows.Forms.PictureBox CameraWindow;
        private System.Windows.Forms.PictureBox TransformWindow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox InRangeWindow;
        private System.Windows.Forms.PictureBox ContourWindow;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button UpdateButton;
    }
}

