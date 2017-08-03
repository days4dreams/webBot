namespace webBot
{
    partial class FormWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWelcome));
            this.labelWelcomeSubIntro = new System.Windows.Forms.Label();
            this.labelWelcomeIntro = new System.Windows.Forms.Label();
            this.buttonQuickReport = new System.Windows.Forms.Button();
            this.buttonFullReport = new System.Windows.Forms.Button();
            this.labelWelcomeQuickReport = new System.Windows.Forms.Label();
            this.labelWelcomeFullReport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWelcomeSubIntro
            // 
            this.labelWelcomeSubIntro.AutoSize = true;
            this.labelWelcomeSubIntro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeSubIntro.Location = new System.Drawing.Point(31, 50);
            this.labelWelcomeSubIntro.Name = "labelWelcomeSubIntro";
            this.labelWelcomeSubIntro.Size = new System.Drawing.Size(461, 15);
            this.labelWelcomeSubIntro.TabIndex = 4;
            this.labelWelcomeSubIntro.Text = "Web Bot will crawl and analyse your webpage(s). Start by selecting a service belo" +
    "w";
            this.labelWelcomeSubIntro.Click += new System.EventHandler(this.labelSubIntro_Click);
            // 
            // labelWelcomeIntro
            // 
            this.labelWelcomeIntro.AutoSize = true;
            this.labelWelcomeIntro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeIntro.Location = new System.Drawing.Point(29, 21);
            this.labelWelcomeIntro.Name = "labelWelcomeIntro";
            this.labelWelcomeIntro.Size = new System.Drawing.Size(181, 19);
            this.labelWelcomeIntro.TabIndex = 3;
            this.labelWelcomeIntro.Text = "Welcome to the Web Bot";
            // 
            // buttonQuickReport
            // 
            this.buttonQuickReport.Location = new System.Drawing.Point(34, 97);
            this.buttonQuickReport.Name = "buttonQuickReport";
            this.buttonQuickReport.Size = new System.Drawing.Size(210, 31);
            this.buttonQuickReport.TabIndex = 5;
            this.buttonQuickReport.Text = "Quick Report";
            this.buttonQuickReport.UseVisualStyleBackColor = true;
            this.buttonQuickReport.Click += new System.EventHandler(this.buttonQuickReport_Click);
            // 
            // buttonFullReport
            // 
            this.buttonFullReport.Location = new System.Drawing.Point(284, 97);
            this.buttonFullReport.Name = "buttonFullReport";
            this.buttonFullReport.Size = new System.Drawing.Size(208, 31);
            this.buttonFullReport.TabIndex = 6;
            this.buttonFullReport.Text = "Full Report";
            this.buttonFullReport.UseVisualStyleBackColor = true;
            // 
            // labelWelcomeQuickReport
            // 
            this.labelWelcomeQuickReport.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeQuickReport.Location = new System.Drawing.Point(31, 150);
            this.labelWelcomeQuickReport.Name = "labelWelcomeQuickReport";
            this.labelWelcomeQuickReport.Size = new System.Drawing.Size(214, 200);
            this.labelWelcomeQuickReport.TabIndex = 7;
            this.labelWelcomeQuickReport.Text = resources.GetString("labelWelcomeQuickReport.Text");
            // 
            // labelWelcomeFullReport
            // 
            this.labelWelcomeFullReport.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeFullReport.Location = new System.Drawing.Point(281, 150);
            this.labelWelcomeFullReport.Name = "labelWelcomeFullReport";
            this.labelWelcomeFullReport.Size = new System.Drawing.Size(214, 200);
            this.labelWelcomeFullReport.TabIndex = 8;
            this.labelWelcomeFullReport.Text = resources.GetString("labelWelcomeFullReport.Text");
            this.labelWelcomeFullReport.Click += new System.EventHandler(this.labelWelcomeFullReport_Click);
            // 
            // FormWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 371);
            this.Controls.Add(this.labelWelcomeFullReport);
            this.Controls.Add(this.labelWelcomeQuickReport);
            this.Controls.Add(this.buttonFullReport);
            this.Controls.Add(this.buttonQuickReport);
            this.Controls.Add(this.labelWelcomeSubIntro);
            this.Controls.Add(this.labelWelcomeIntro);
            this.Name = "FormWelcome";
            this.Text = "Web Bot Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcomeSubIntro;
        private System.Windows.Forms.Label labelWelcomeIntro;
        private System.Windows.Forms.Button buttonQuickReport;
        private System.Windows.Forms.Button buttonFullReport;
        private System.Windows.Forms.Label labelWelcomeQuickReport;
        private System.Windows.Forms.Label labelWelcomeFullReport;
    }
}