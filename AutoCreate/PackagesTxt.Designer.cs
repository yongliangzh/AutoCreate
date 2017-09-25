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
            // PackagesTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 645);
            this.Controls.Add(this.txtRecord);
            this.Name = "PackagesTxt";
            this.Text = "PackagesTxt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecord;
    }
}