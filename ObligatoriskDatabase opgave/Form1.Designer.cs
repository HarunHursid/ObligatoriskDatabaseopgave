namespace ObligatoriskDatabase_opgave
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Facility_Id = new System.Windows.Forms.TextBox();
            this.FacilityName = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.ShowAll = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trainingDatabaseDataSet = new ObligatoriskDatabase_opgave.TrainingDatabaseDataSet();
            this.facilitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facilitiesTableAdapter = new ObligatoriskDatabase_opgave.TrainingDatabaseDataSetTableAdapters.FacilitiesTableAdapter();
            this.facilityidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facility Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "FacilityName";
            // 
            // Facility_Id
            // 
            this.Facility_Id.Location = new System.Drawing.Point(110, 46);
            this.Facility_Id.Name = "Facility_Id";
            this.Facility_Id.Size = new System.Drawing.Size(100, 26);
            this.Facility_Id.TabIndex = 2;
            // 
            // FacilityName
            // 
            this.FacilityName.Location = new System.Drawing.Point(135, 101);
            this.FacilityName.Name = "FacilityName";
            this.FacilityName.Size = new System.Drawing.Size(100, 26);
            this.FacilityName.TabIndex = 3;
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.Chartreuse;
            this.Insert.Location = new System.Drawing.Point(17, 276);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(97, 30);
            this.Insert.TabIndex = 4;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Yellow;
            this.Update.Location = new System.Drawing.Point(135, 276);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(82, 30);
            this.Update.TabIndex = 5;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.ForeColor = System.Drawing.SystemColors.Window;
            this.Delete.Location = new System.Drawing.Point(16, 327);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(85, 30);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ShowAll
            // 
            this.ShowAll.BackColor = System.Drawing.Color.Chartreuse;
            this.ShowAll.Location = new System.Drawing.Point(16, 382);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(88, 30);
            this.ShowAll.TabIndex = 7;
            this.ShowAll.Text = "ShowAll";
            this.ShowAll.UseVisualStyleBackColor = false;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Exit.Location = new System.Drawing.Point(160, 382);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 33);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.Blue;
            this.Find.ForeColor = System.Drawing.SystemColors.Window;
            this.Find.Location = new System.Drawing.Point(713, 43);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(75, 29);
            this.Find.TabIndex = 9;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facilityidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facilitiesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(250, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(538, 348);
            this.dataGridView1.TabIndex = 10;
            // 
            // trainingDatabaseDataSet
            // 
            this.trainingDatabaseDataSet.DataSetName = "TrainingDatabaseDataSet";
            this.trainingDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facilitiesBindingSource
            // 
            this.facilitiesBindingSource.DataMember = "Facilities";
            this.facilitiesBindingSource.DataSource = this.trainingDatabaseDataSet;
            // 
            // facilitiesTableAdapter
            // 
            this.facilitiesTableAdapter.ClearBeforeFill = true;
            // 
            // facilityidDataGridViewTextBoxColumn
            // 
            this.facilityidDataGridViewTextBoxColumn.DataPropertyName = "Facility_id";
            this.facilityidDataGridViewTextBoxColumn.HeaderText = "Facility_id";
            this.facilityidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.facilityidDataGridViewTextBoxColumn.Name = "facilityidDataGridViewTextBoxColumn";
            this.facilityidDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(345, 46);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(349, 26);
            this.SearchBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.FacilityName);
            this.Controls.Add(this.Facility_Id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilitiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Facility_Id;
        private System.Windows.Forms.TextBox FacilityName;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TrainingDatabaseDataSet trainingDatabaseDataSet;
        private System.Windows.Forms.BindingSource facilitiesBindingSource;
        private TrainingDatabaseDataSetTableAdapters.FacilitiesTableAdapter facilitiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilityidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox SearchBox;
    }
}

