namespace PDF_Resume_Creator
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
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblAppAuthor = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFDJSON = new System.Windows.Forms.OpenFileDialog();
            this.lblSelected = new System.Windows.Forms.Label();
            this.txtBoxSelected = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Font Awesome 5 Pro Solid", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblLogo.Location = new System.Drawing.Point(188, 31);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(265, 77);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "  ";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAppName.Location = new System.Drawing.Point(69, 130);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(503, 43);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "JSON to PDF Resume Creator";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppAuthor
            // 
            this.lblAppAuthor.AutoSize = true;
            this.lblAppAuthor.Font = new System.Drawing.Font("SF Mono", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppAuthor.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblAppAuthor.Location = new System.Drawing.Point(90, 174);
            this.lblAppAuthor.Name = "lblAppAuthor";
            this.lblAppAuthor.Size = new System.Drawing.Size(440, 33);
            this.lblAppAuthor.TabIndex = 2;
            this.lblAppAuthor.Text = "App by Bernard C. Narceda";
            this.lblAppAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBrowse.Location = new System.Drawing.Point(77, 284);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(173, 50);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse JSON File";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFDJSON
            // 
            this.openFDJSON.FileName = "openFileDialog1";
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblSelected.Location = new System.Drawing.Point(73, 238);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(151, 20);
            this.lblSelected.TabIndex = 4;
            this.lblSelected.Text = "Selected JSON File:";
            // 
            // txtBoxSelected
            // 
            this.txtBoxSelected.Location = new System.Drawing.Point(230, 235);
            this.txtBoxSelected.Name = "txtBoxSelected";
            this.txtBoxSelected.ReadOnly = true;
            this.txtBoxSelected.Size = new System.Drawing.Size(328, 26);
            this.txtBoxSelected.TabIndex = 5;
            this.txtBoxSelected.TextChanged += new System.EventHandler(this.txtBoxSelected_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConvert.Location = new System.Drawing.Point(385, 284);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(173, 50);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert to PDF";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(638, 378);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtBoxSelected);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblAppAuthor);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.lblLogo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JSON to PDF Resume Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblAppAuthor;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFDJSON;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.TextBox txtBoxSelected;
        private System.Windows.Forms.Button btnConvert;
    }
}

