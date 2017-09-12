namespace AutoCreate
{
    partial class MainPanel
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
            this.txtTabelName = new System.Windows.Forms.TextBox();
            this.btnChooseTableName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxColoumn = new System.Windows.Forms.ListBox();
            this.btnAddToSelect = new System.Windows.Forms.Button();
            this.btnAddToShow = new System.Windows.Forms.Button();
            this.listBoxAddToSelect = new System.Windows.Forms.ListBox();
            this.listBoxAddToShow = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDeleteSelect = new System.Windows.Forms.Button();
            this.btnDeleteShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.txtRootName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTabelName
            // 
            this.txtTabelName.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.txtTabelName.Location = new System.Drawing.Point(208, 40);
            this.txtTabelName.Name = "txtTabelName";
            this.txtTabelName.Size = new System.Drawing.Size(345, 34);
            this.txtTabelName.TabIndex = 0;
            // 
            // btnChooseTableName
            // 
            this.btnChooseTableName.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btnChooseTableName.Location = new System.Drawing.Point(588, 38);
            this.btnChooseTableName.Name = "btnChooseTableName";
            this.btnChooseTableName.Size = new System.Drawing.Size(106, 37);
            this.btnChooseTableName.TabIndex = 1;
            this.btnChooseTableName.Text = "Select";
            this.btnChooseTableName.UseVisualStyleBackColor = true;
            this.btnChooseTableName.Click += new System.EventHandler(this.btnChooseTableName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Table Name：";
            // 
            // listBoxColoumn
            // 
            this.listBoxColoumn.Font = new System.Drawing.Font("微软雅黑 Light", 10F);
            this.listBoxColoumn.FormattingEnabled = true;
            this.listBoxColoumn.ItemHeight = 27;
            this.listBoxColoumn.Location = new System.Drawing.Point(42, 116);
            this.listBoxColoumn.Name = "listBoxColoumn";
            this.listBoxColoumn.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxColoumn.Size = new System.Drawing.Size(300, 382);
            this.listBoxColoumn.TabIndex = 4;
            // 
            // btnAddToSelect
            // 
            this.btnAddToSelect.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddToSelect.Location = new System.Drawing.Point(373, 173);
            this.btnAddToSelect.Name = "btnAddToSelect";
            this.btnAddToSelect.Size = new System.Drawing.Size(180, 50);
            this.btnAddToSelect.TabIndex = 5;
            this.btnAddToSelect.Text = ">Add To Select ";
            this.btnAddToSelect.UseVisualStyleBackColor = true;
            this.btnAddToSelect.Click += new System.EventHandler(this.btnAddToSelect_Click);
            // 
            // btnAddToShow
            // 
            this.btnAddToShow.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddToShow.Location = new System.Drawing.Point(373, 388);
            this.btnAddToShow.Name = "btnAddToShow";
            this.btnAddToShow.Size = new System.Drawing.Size(180, 50);
            this.btnAddToShow.TabIndex = 6;
            this.btnAddToShow.Text = ">Add To Show";
            this.btnAddToShow.UseVisualStyleBackColor = true;
            this.btnAddToShow.Click += new System.EventHandler(this.btnAddToShow_Click);
            // 
            // listBoxAddToSelect
            // 
            this.listBoxAddToSelect.Font = new System.Drawing.Font("微软雅黑 Light", 10F);
            this.listBoxAddToSelect.FormattingEnabled = true;
            this.listBoxAddToSelect.ItemHeight = 27;
            this.listBoxAddToSelect.Location = new System.Drawing.Point(588, 116);
            this.listBoxAddToSelect.Name = "listBoxAddToSelect";
            this.listBoxAddToSelect.Size = new System.Drawing.Size(300, 166);
            this.listBoxAddToSelect.TabIndex = 7;
            // 
            // listBoxAddToShow
            // 
            this.listBoxAddToShow.Font = new System.Drawing.Font("微软雅黑 Light", 10F);
            this.listBoxAddToShow.FormattingEnabled = true;
            this.listBoxAddToShow.ItemHeight = 27;
            this.listBoxAddToShow.Location = new System.Drawing.Point(588, 332);
            this.listBoxAddToShow.Name = "listBoxAddToShow";
            this.listBoxAddToShow.Size = new System.Drawing.Size(300, 166);
            this.listBoxAddToShow.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreate.Location = new System.Drawing.Point(43, 656);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(180, 50);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Quickly Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDeleteSelect
            // 
            this.btnDeleteSelect.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteSelect.Location = new System.Drawing.Point(901, 116);
            this.btnDeleteSelect.Name = "btnDeleteSelect";
            this.btnDeleteSelect.Size = new System.Drawing.Size(67, 37);
            this.btnDeleteSelect.TabIndex = 10;
            this.btnDeleteSelect.Text = "Del";
            this.btnDeleteSelect.UseVisualStyleBackColor = true;
            this.btnDeleteSelect.Click += new System.EventHandler(this.btnDeleteSelect_Click);
            // 
            // btnDeleteShow
            // 
            this.btnDeleteShow.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteShow.Location = new System.Drawing.Point(901, 332);
            this.btnDeleteShow.Name = "btnDeleteShow";
            this.btnDeleteShow.Size = new System.Drawing.Size(67, 37);
            this.btnDeleteShow.TabIndex = 11;
            this.btnDeleteShow.Text = "Del";
            this.btnDeleteShow.UseVisualStyleBackColor = true;
            this.btnDeleteShow.Click += new System.EventHandler(this.btnDeleteShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label2.Location = new System.Drawing.Point(38, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Project Path：";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.txtPath.Location = new System.Drawing.Point(208, 530);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(345, 34);
            this.txtPath.TabIndex = 13;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btnSelectPath.Location = new System.Drawing.Point(588, 528);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(106, 37);
            this.btnSelectPath.TabIndex = 14;
            this.btnSelectPath.Text = "Select";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // txtRootName
            // 
            this.txtRootName.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.txtRootName.Location = new System.Drawing.Point(208, 595);
            this.txtRootName.Name = "txtRootName";
            this.txtRootName.Size = new System.Drawing.Size(345, 34);
            this.txtRootName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label3.Location = new System.Drawing.Point(38, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Root Name：";
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 727);
            this.Controls.Add(this.txtRootName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteShow);
            this.Controls.Add(this.btnDeleteSelect);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.listBoxAddToShow);
            this.Controls.Add(this.listBoxAddToSelect);
            this.Controls.Add(this.btnAddToShow);
            this.Controls.Add(this.btnAddToSelect);
            this.Controls.Add(this.listBoxColoumn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChooseTableName);
            this.Controls.Add(this.txtTabelName);
            this.Name = "MainPanel";
            this.Text = "MainPanel";
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTabelName;
        private System.Windows.Forms.Button btnChooseTableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxColoumn;
        private System.Windows.Forms.Button btnAddToSelect;
        private System.Windows.Forms.Button btnAddToShow;
        private System.Windows.Forms.ListBox listBoxAddToSelect;
        private System.Windows.Forms.ListBox listBoxAddToShow;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDeleteSelect;
        private System.Windows.Forms.Button btnDeleteShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox txtRootName;
        private System.Windows.Forms.Label label3;
    }
}

