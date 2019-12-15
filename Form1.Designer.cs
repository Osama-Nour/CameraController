namespace DealWithCamera
{
    partial class Form1
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
            this.btn_capture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stopCamera = new System.Windows.Forms.Button();
            this.btn_saveBinary = new System.Windows.Forms.Button();
            this.saveFilePhoto = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_capture
            // 
            this.btn_capture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_capture.Location = new System.Drawing.Point(389, 356);
            this.btn_capture.Name = "btn_capture";
            this.btn_capture.Size = new System.Drawing.Size(83, 44);
            this.btn_capture.TabIndex = 0;
            this.btn_capture.Text = "Capture";
            this.btn_capture.UseVisualStyleBackColor = true;
            this.btn_capture.Click += new System.EventHandler(this.btn_capture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 265);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_start.Location = new System.Drawing.Point(35, 356);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(83, 44);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stopCamera
            // 
            this.btn_stopCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_stopCamera.Location = new System.Drawing.Point(151, 356);
            this.btn_stopCamera.Name = "btn_stopCamera";
            this.btn_stopCamera.Size = new System.Drawing.Size(83, 44);
            this.btn_stopCamera.TabIndex = 0;
            this.btn_stopCamera.Text = "Stop";
            this.btn_stopCamera.UseVisualStyleBackColor = true;
            this.btn_stopCamera.Click += new System.EventHandler(this.btn_stopCamera_Click);
            // 
            // btn_saveBinary
            // 
            this.btn_saveBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_saveBinary.Location = new System.Drawing.Point(275, 356);
            this.btn_saveBinary.Name = "btn_saveBinary";
            this.btn_saveBinary.Size = new System.Drawing.Size(83, 44);
            this.btn_saveBinary.TabIndex = 0;
            this.btn_saveBinary.Text = "Save binary";
            this.btn_saveBinary.UseVisualStyleBackColor = true;
            this.btn_saveBinary.Click += new System.EventHandler(this.btn_saveBinary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_saveBinary);
            this.Controls.Add(this.btn_stopCamera);
            this.Controls.Add(this.btn_capture);
            this.Name = "Form1";
            this.Text = "Capture image";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_capture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stopCamera;
        private System.Windows.Forms.Button btn_saveBinary;
        private System.Windows.Forms.SaveFileDialog saveFilePhoto;
    }
}

