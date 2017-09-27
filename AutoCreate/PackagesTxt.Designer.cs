namespace AutoCreate
{
    partial class PackagesTxt
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
            this.txtRecord = new System.Windows.Forms.TextBox();
            this.txtInto = new System.Windows.Forms.TextBox();
            this.txtAs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRecord
            // 
            this.txtRecord.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRecord.Location = new System.Drawing.Point(35, 28);
            this.txtRecord.Multiline = true;
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRecord.Size = new System.Drawing.Size(426, 586);
            this.txtRecord.TabIndex = 0;
            // 
            // txtInto
            // 
            this.txtInto.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInto.Location = new System.Drawing.Point(487, 28);
            this.txtInto.MaxLength = 327670;
            this.txtInto.Multiline = true;
            this.txtInto.Name = "txtInto";
            this.txtInto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInto.Size = new System.Drawing.Size(426, 586);
            this.txtInto.TabIndex = 1;
            // 
            // txtAs
            // 
            this.txtAs.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAs.Location = new System.Drawing.Point(945, 28);
            this.txtAs.MaxLength = 327670;
            this.txtAs.Multiline = true;
            this.txtAs.Name = "txtAs";
            this.txtAs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAs.Size = new System.Drawing.Size(426, 586);
            this.txtAs.TabIndex = 2;
            // 
            // PackagesTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 645);
            this.Controls.Add(this.txtAs);
            this.Controls.Add(this.txtInto);
            this.Controls.Add(this.txtRecord);
            this.Name = "PackagesTxt";
            this.Text = "PackagesTxt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecord;
        private System.Windows.Forms.TextBox txtInto;
        private System.Windows.Forms.TextBox txtAs;
    }
}