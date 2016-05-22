namespace FloatingArrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRotateC = new System.Windows.Forms.Button();
            this.buttonRotateCC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Yellow;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(87, 115);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.TabStop = false;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonRotateC
            // 
            this.buttonRotateC.BackColor = System.Drawing.Color.Yellow;
            this.buttonRotateC.FlatAppearance.BorderSize = 0;
            this.buttonRotateC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRotateC.Location = new System.Drawing.Point(204, 165);
            this.buttonRotateC.Name = "buttonRotateC";
            this.buttonRotateC.Size = new System.Drawing.Size(75, 23);
            this.buttonRotateC.TabIndex = 2;
            this.buttonRotateC.TabStop = false;
            this.buttonRotateC.UseVisualStyleBackColor = false;
            this.buttonRotateC.Click += new System.EventHandler(this.buttonRotateC_Click);
            // 
            // buttonRotateCC
            // 
            this.buttonRotateCC.BackColor = System.Drawing.Color.Yellow;
            this.buttonRotateCC.FlatAppearance.BorderSize = 0;
            this.buttonRotateCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRotateCC.Location = new System.Drawing.Point(204, 229);
            this.buttonRotateCC.Name = "buttonRotateCC";
            this.buttonRotateCC.Size = new System.Drawing.Size(75, 23);
            this.buttonRotateCC.TabIndex = 2;
            this.buttonRotateCC.TabStop = false;
            this.buttonRotateCC.UseVisualStyleBackColor = false;
            this.buttonRotateCC.Click += new System.EventHandler(this.buttonRotateCC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.buttonRotateCC);
            this.Controls.Add(this.buttonRotateC);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FloatingArrow";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRotateC;
        private System.Windows.Forms.Button buttonRotateCC;
    }
}

