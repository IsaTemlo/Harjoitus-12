
namespace Harjoitus_12
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
            this.VastausARB = new System.Windows.Forms.RadioButton();
            this.VastausBRB = new System.Windows.Forms.RadioButton();
            this.VastausCRB = new System.Windows.Forms.RadioButton();
            this.VastausDRB = new System.Windows.Forms.RadioButton();
            this.KysymysLB = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VastausARB
            // 
            this.VastausARB.AutoSize = true;
            this.VastausARB.Location = new System.Drawing.Point(742, 97);
            this.VastausARB.Name = "VastausARB";
            this.VastausARB.Size = new System.Drawing.Size(46, 33);
            this.VastausARB.TabIndex = 0;
            this.VastausARB.TabStop = true;
            this.VastausARB.Text = "A";
            this.VastausARB.UseVisualStyleBackColor = true;
            // 
            // VastausBRB
            // 
            this.VastausBRB.AutoSize = true;
            this.VastausBRB.Location = new System.Drawing.Point(742, 168);
            this.VastausBRB.Name = "VastausBRB";
            this.VastausBRB.Size = new System.Drawing.Size(47, 33);
            this.VastausBRB.TabIndex = 1;
            this.VastausBRB.TabStop = true;
            this.VastausBRB.Text = "B";
            this.VastausBRB.UseVisualStyleBackColor = true;
            // 
            // VastausCRB
            // 
            this.VastausCRB.AutoSize = true;
            this.VastausCRB.Location = new System.Drawing.Point(742, 240);
            this.VastausCRB.Name = "VastausCRB";
            this.VastausCRB.Size = new System.Drawing.Size(48, 33);
            this.VastausCRB.TabIndex = 2;
            this.VastausCRB.TabStop = true;
            this.VastausCRB.Text = "C";
            this.VastausCRB.UseVisualStyleBackColor = true;
            // 
            // VastausDRB
            // 
            this.VastausDRB.AutoSize = true;
            this.VastausDRB.Location = new System.Drawing.Point(742, 311);
            this.VastausDRB.Name = "VastausDRB";
            this.VastausDRB.Size = new System.Drawing.Size(48, 33);
            this.VastausDRB.TabIndex = 3;
            this.VastausDRB.TabStop = true;
            this.VastausDRB.Text = "D";
            this.VastausDRB.UseVisualStyleBackColor = true;
            // 
            // KysymysLB
            // 
            this.KysymysLB.AutoSize = true;
            this.KysymysLB.Location = new System.Drawing.Point(13, 97);
            this.KysymysLB.Name = "KysymysLB";
            this.KysymysLB.Size = new System.Drawing.Size(265, 29);
            this.KysymysLB.TabIndex = 4;
            this.KysymysLB.Text = "Vastaus 1. kysymkseen:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(30, 311);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(97, 29);
            this.VastausLB.TabIndex = 5;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 538);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.KysymysLB);
            this.Controls.Add(this.VastausDRB);
            this.Controls.Add(this.VastausCRB);
            this.Controls.Add(this.VastausBRB);
            this.Controls.Add(this.VastausARB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton VastausARB;
        private System.Windows.Forms.RadioButton VastausBRB;
        private System.Windows.Forms.RadioButton VastausCRB;
        private System.Windows.Forms.RadioButton VastausDRB;
        private System.Windows.Forms.Label KysymysLB;
        private System.Windows.Forms.Label VastausLB;
    }
}

