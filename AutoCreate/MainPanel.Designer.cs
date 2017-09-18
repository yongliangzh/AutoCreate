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
            this.rdbSingleSearch = new System.Windows.Forms.RadioButton();
            this.rdbMultipleSearch = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtTabelName
            // 
            this.txtTabelName.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.txtTabelName.Location = new System.Drawing.Point(254, 47);
            this.txtTabelName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTabelName.Name = "txtTabelName";
            this.txtTabelName.Size = new System.Drawing.Size(421, 38);
            this.txtTabelName.TabIndex = 0;
            // 
            // btnChooseTableName
            // 
            this.btnChooseTableName.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnChooseTableName.Location = new System.Drawing.Point(719, 44);
            this.btnChooseTableName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChooseTableName.Name = "btnChooseTableName";
            this.btnChooseTableName.Size = new System.Drawing.Size(130, 43);
            this.btnChooseTableName.TabIndex = 1;
            this.btnChooseTableName.Text = "Select";
            this.btnChooseTableName.UseVisualStyleBackColor = true;
            this.btnChooseTableName.Click += new System.EventHandler(this.btnChooseTableName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Table Name：";
            // 
            // listBoxColoumn
            // 
            this.listBoxColoumn.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F);
            this.listBoxColoumn.FormattingEnabled = true;
            this.listBoxColoumn.ItemHeight = 30;
            this.listBoxColoumn.Location = new System.Drawing.Point(51, 135);
            this.listBoxColoumn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxColoumn.Name = "listBoxColoumn";
            this.listBoxColoumn.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxColoumn.Size = new System.Drawing.Size(366, 424);
            this.listBoxColoumn.TabIndex = 4;
            // 
            // btnAddToSelect
            // 
            this.btnAddToSelect.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddToSelect.Location = new System.Drawing.Point(456, 202);
            this.btnAddToSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddToSelect.Name = "btnAddToSelect";
            this.btnAddToSelect.Size = new System.Drawing.Size(220, 58);
            this.btnAddToSelect.TabIndex = 5;
            this.btnAddToSelect.Text = ">Add To Select ";
            this.btnAddToSelect.UseVisualStyleBackColor = true;
            this.btnAddToSelect.Click += new System.EventHandler(this.btnAddToSelect_Click);
            // 
            // btnAddToShow
            // 
            this.btnAddToShow.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddToShow.Location = new System.Drawing.Point(456, 453);
            this.btnAddToShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddToShow.Name = "btnAddToShow";
            this.btnAddToShow.Size = new System.Drawing.Size(220, 58);
            this.btnAddToShow.TabIndex = 6;
            this.btnAddToShow.Text = ">Add To Show";
            this.btnAddToShow.UseVisualStyleBackColor = true;
            this.btnAddToShow.Click += new System.EventHandler(this.btnAddToShow_Click);
            // 
            // listBoxAddToSelect
            // 
            this.listBoxAddToSelect.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F);
            this.listBoxAddToSelect.FormattingEnabled = true;
            this.listBoxAddToSelect.ItemHeight = 30;
            this.listBoxAddToSelect.Location = new System.Drawing.Point(719, 135);
            this.listBoxAddToSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxAddToSelect.Name = "listBoxAddToSelect";
            this.listBoxAddToSelect.Size = new System.Drawing.Size(366, 184);
            this.listBoxAddToSelect.TabIndex = 7;
            // 
            // listBoxAddToShow
            // 
            this.listBoxAddToShow.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F);
            this.listBoxAddToShow.FormattingEnabled = true;
            this.listBoxAddToShow.ItemHeight = 30;
            this.listBoxAddToShow.Location = new System.Drawing.Point(719, 387);
            this.listBoxAddToShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxAddToShow.Name = "listBoxAddToShow";
            this.listBoxAddToShow.Size = new System.Drawing.Size(366, 184);
            this.listBoxAddToShow.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreate.Location = new System.Drawing.Point(53, 765);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(220, 58);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Quickly Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDeleteSelect
            // 
            this.btnDeleteSelect.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteSelect.Location = new System.Drawing.Point(1101, 135);
            this.btnDeleteSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteSelect.Name = "btnDeleteSelect";
            this.btnDeleteSelect.Size = new System.Drawing.Size(82, 43);
            this.btnDeleteSelect.TabIndex = 10;
            this.btnDeleteSelect.Text = "Del";
            this.btnDeleteSelect.UseVisualStyleBackColor = true;
            this.btnDeleteSelect.Click += new System.EventHandler(this.btnDeleteSelect_Click);
            // 
            // btnDeleteShow
            // 
            this.btnDeleteShow.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteShow.Location = new System.Drawing.Point(1101, 387);
            this.btnDeleteShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteShow.Name = "btnDeleteShow";
            this.btnDeleteShow.Size = new System.Drawing.Size(82, 43);
            this.btnDeleteShow.TabIndex = 11;
            this.btnDeleteShow.Text = "Del";
            this.btnDeleteShow.UseVisualStyleBackColor = true;
            this.btnDeleteShow.Click += new System.EventHandler(this.btnDeleteShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label2.Location = new System.Drawing.Point(46, 622);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Project Path：";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.txtPath.Location = new System.Drawing.Point(254, 618);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(421, 38);
            this.txtPath.TabIndex = 13;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnSelectPath.Location = new System.Drawing.Point(719, 616);
            this.btnSelectPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(130, 43);
            this.btnSelectPath.TabIndex = 14;
            this.btnSelectPath.Text = "Select";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // txtRootName
            // 
            this.txtRootName.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.txtRootName.Location = new System.Drawing.Point(254, 694);
            this.txtRootName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRootName.Name = "txtRootName";
            this.txtRootName.Size = new System.Drawing.Size(421, 38);
            this.txtRootName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label3.Location = new System.Drawing.Point(46, 698);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Root Name：";
            // 
            // rdbSingleSearch
            // 
            this.rdbSingleSearch.AutoSize = true;
            this.rdbSingleSearch.Checked = true;
            this.rdbSingleSearch.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbSingleSearch.Location = new System.Drawing.Point(724, 695);
            this.rdbSingleSearch.Name = "rdbSingleSearch";
            this.rdbSingleSearch.Size = new System.Drawing.Size(193, 35);
            this.rdbSingleSearch.TabIndex = 17;
            this.rdbSingleSearch.TabStop = true;
            this.rdbSingleSearch.Text = "Single Search";
            this.rdbSingleSearch.UseVisualStyleBackColor = true;
            // 
            // rdbMultipleSearch
            // 
            this.rdbMultipleSearch.AutoSize = true;
            this.rdbMultipleSearch.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbMultipleSearch.Location = new System.Drawing.Point(939, 696);
            this.rdbMultipleSearch.Name = "rdbMultipleSearch";
            this.rdbMultipleSearch.Size = new System.Drawing.Size(217, 35);
            this.rdbMultipleSearch.TabIndex = 18;
            this.rdbMultipleSearch.Text = "Multiple Search";
            this.rdbMultipleSearch.UseVisualStyleBackColor = true;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 848);
            this.Controls.Add(this.rdbMultipleSearch);
            this.Controls.Add(this.rdbSingleSearch);
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
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private System.Windows.Forms.RadioButton rdbSingleSearch;
        private System.Windows.Forms.RadioButton rdbMultipleSearch;
    }
}

