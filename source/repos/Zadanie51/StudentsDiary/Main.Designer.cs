namespace StudentsDiary
{
    partial class Main
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvDiary = new System.Windows.Forms.DataGridView();
            this.cmbGrupa = new System.Windows.Forms.ComboBox();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.addEditStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addEditStudentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.addEditStudentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEditStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEditStudentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEditStudentBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Location = new System.Drawing.Point(18, 18);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEdit.Location = new System.Drawing.Point(153, 18);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 35);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Location = new System.Drawing.Point(297, 18);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRefresh.Location = new System.Drawing.Point(444, 18);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 35);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvDiary
            // 
            this.dgvDiary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiary.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiary.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.studentBindingSource1, "Klasa", true));
            this.dgvDiary.Location = new System.Drawing.Point(18, 63);
            this.dgvDiary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDiary.Name = "dgvDiary";
            this.dgvDiary.ReadOnly = true;
            this.dgvDiary.RowHeadersVisible = false;
            this.dgvDiary.RowHeadersWidth = 62;
            this.dgvDiary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiary.Size = new System.Drawing.Size(1202, 829);
            this.dgvDiary.TabIndex = 4;
            // 
            // cmbGrupa
            // 
            this.cmbGrupa.Location = new System.Drawing.Point(609, 25);
            this.cmbGrupa.Name = "cmbGrupa";
            this.cmbGrupa.Size = new System.Drawing.Size(246, 28);
            this.cmbGrupa.Sorted = true;
            this.cmbGrupa.TabIndex = 5;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataSource = typeof(StudentsDiary.Student);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(StudentsDiary.Student);
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataSource = typeof(StudentsDiary.Student);
            // 
            // addEditStudentBindingSource
            // 
            this.addEditStudentBindingSource.DataSource = typeof(StudentsDiary.AddEditStudent);
            // 
            // addEditStudentBindingSource1
            // 
            this.addEditStudentBindingSource1.DataSource = typeof(StudentsDiary.AddEditStudent);
            // 
            // addEditStudentBindingSource2
            // 
            this.addEditStudentBindingSource2.DataSource = typeof(StudentsDiary.AddEditStudent);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1238, 911);
            this.Controls.Add(this.cmbGrupa);
            this.Controls.Add(this.dgvDiary);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Dziennik ucznia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEditStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEditStudentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEditStudentBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvDiary;
        private System.Windows.Forms.BindingSource addEditStudentBindingSource;
        private System.Windows.Forms.ComboBox cmbGrupa;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.BindingSource addEditStudentBindingSource1;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private System.Windows.Forms.BindingSource addEditStudentBindingSource2;
    }
}

