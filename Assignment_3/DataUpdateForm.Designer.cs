namespace Assignment_3
{
    partial class DataUpdateForm
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
            this.groupBoxUpdateStudent = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAssignments = new System.Windows.Forms.DataGridView();
            this.AssignmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.findAssignmentGroupBox = new System.Windows.Forms.GroupBox();
            this.labelAssignmentIDSearch = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.textBoxAssignmentIDSearch = new System.Windows.Forms.TextBox();
            this.textBoxAssignmentScore = new System.Windows.Forms.TextBox();
            this.textBoxAssignmentName = new System.Windows.Forms.TextBox();
            this.labelAssignmentScore = new System.Windows.Forms.Label();
            this.labelAssignemntName = new System.Windows.Forms.Label();
            this.textBoxAssignmentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelSelectedStudent = new System.Windows.Forms.Label();
            this.comboStudentName = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnUpdateStudent = new System.Windows.Forms.RadioButton();
            this.rbtnUpdateAssignments = new System.Windows.Forms.RadioButton();
            this.groupBoxUpdateStudent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignments)).BeginInit();
            this.findAssignmentGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUpdateStudent
            // 
            this.groupBoxUpdateStudent.Controls.Add(this.groupBox2);
            this.groupBoxUpdateStudent.Controls.Add(this.groupBox1);
            this.groupBoxUpdateStudent.Controls.Add(this.btnCancel);
            this.groupBoxUpdateStudent.Controls.Add(this.findAssignmentGroupBox);
            this.groupBoxUpdateStudent.Controls.Add(this.textBoxAssignmentScore);
            this.groupBoxUpdateStudent.Controls.Add(this.textBoxAssignmentName);
            this.groupBoxUpdateStudent.Controls.Add(this.labelAssignmentScore);
            this.groupBoxUpdateStudent.Controls.Add(this.labelAssignemntName);
            this.groupBoxUpdateStudent.Controls.Add(this.textBoxAssignmentID);
            this.groupBoxUpdateStudent.Controls.Add(this.label1);
            this.groupBoxUpdateStudent.Controls.Add(this.btnSave);
            this.groupBoxUpdateStudent.Controls.Add(this.labelSelectedStudent);
            this.groupBoxUpdateStudent.Controls.Add(this.comboStudentName);
            this.groupBoxUpdateStudent.Location = new System.Drawing.Point(24, 31);
            this.groupBoxUpdateStudent.Name = "groupBoxUpdateStudent";
            this.groupBoxUpdateStudent.Size = new System.Drawing.Size(855, 423);
            this.groupBoxUpdateStudent.TabIndex = 0;
            this.groupBoxUpdateStudent.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewAssignments);
            this.groupBox1.Location = new System.Drawing.Point(29, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 224);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assignments";
            // 
            // dataGridViewAssignments
            // 
            this.dataGridViewAssignments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAssignments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssignments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignmentID,
            this.AssignmentName,
            this.Score,
            this.MaxScore});
            this.dataGridViewAssignments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAssignments.Location = new System.Drawing.Point(3, 20);
            this.dataGridViewAssignments.Name = "dataGridViewAssignments";
            this.dataGridViewAssignments.RowHeadersWidth = 51;
            this.dataGridViewAssignments.RowTemplate.Height = 24;
            this.dataGridViewAssignments.Size = new System.Drawing.Size(796, 201);
            this.dataGridViewAssignments.TabIndex = 0;
            this.dataGridViewAssignments.SelectionChanged += new System.EventHandler(this.dataGridViewAssignments_SelectionChanged);
            // 
            // AssignmentID
            // 
            this.AssignmentID.HeaderText = "ID";
            this.AssignmentID.MinimumWidth = 6;
            this.AssignmentID.Name = "AssignmentID";
            // 
            // AssignmentName
            // 
            this.AssignmentName.HeaderText = "AssignmentName";
            this.AssignmentName.MinimumWidth = 6;
            this.AssignmentName.Name = "AssignmentName";
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.MinimumWidth = 6;
            this.Score.Name = "Score";
            // 
            // MaxScore
            // 
            this.MaxScore.HeaderText = "Max Score";
            this.MaxScore.MinimumWidth = 6;
            this.MaxScore.Name = "MaxScore";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(480, 26);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel / Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // findAssignmentGroupBox
            // 
            this.findAssignmentGroupBox.Controls.Add(this.labelAssignmentIDSearch);
            this.findAssignmentGroupBox.Controls.Add(this.btnFind);
            this.findAssignmentGroupBox.Controls.Add(this.textBoxAssignmentIDSearch);
            this.findAssignmentGroupBox.Location = new System.Drawing.Point(616, 23);
            this.findAssignmentGroupBox.Name = "findAssignmentGroupBox";
            this.findAssignmentGroupBox.Size = new System.Drawing.Size(215, 76);
            this.findAssignmentGroupBox.TabIndex = 15;
            this.findAssignmentGroupBox.TabStop = false;
            // 
            // labelAssignmentIDSearch
            // 
            this.labelAssignmentIDSearch.AutoSize = true;
            this.labelAssignmentIDSearch.Location = new System.Drawing.Point(6, 15);
            this.labelAssignmentIDSearch.Name = "labelAssignmentIDSearch";
            this.labelAssignmentIDSearch.Size = new System.Drawing.Size(103, 18);
            this.labelAssignmentIDSearch.TabIndex = 13;
            this.labelAssignmentIDSearch.Text = "Assignment ID";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(115, 31);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(89, 31);
            this.btnFind.TabIndex = 14;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // textBoxAssignmentIDSearch
            // 
            this.textBoxAssignmentIDSearch.Location = new System.Drawing.Point(12, 38);
            this.textBoxAssignmentIDSearch.Name = "textBoxAssignmentIDSearch";
            this.textBoxAssignmentIDSearch.Size = new System.Drawing.Size(89, 24);
            this.textBoxAssignmentIDSearch.TabIndex = 12;
            // 
            // textBoxAssignmentScore
            // 
            this.textBoxAssignmentScore.Location = new System.Drawing.Point(578, 373);
            this.textBoxAssignmentScore.Name = "textBoxAssignmentScore";
            this.textBoxAssignmentScore.Size = new System.Drawing.Size(216, 24);
            this.textBoxAssignmentScore.TabIndex = 11;
            // 
            // textBoxAssignmentName
            // 
            this.textBoxAssignmentName.Location = new System.Drawing.Point(308, 374);
            this.textBoxAssignmentName.Name = "textBoxAssignmentName";
            this.textBoxAssignmentName.Size = new System.Drawing.Size(207, 24);
            this.textBoxAssignmentName.TabIndex = 10;
            // 
            // labelAssignmentScore
            // 
            this.labelAssignmentScore.AutoSize = true;
            this.labelAssignmentScore.Location = new System.Drawing.Point(575, 349);
            this.labelAssignmentScore.Name = "labelAssignmentScore";
            this.labelAssignmentScore.Size = new System.Drawing.Size(82, 18);
            this.labelAssignmentScore.TabIndex = 9;
            this.labelAssignmentScore.Text = "New Score";
            // 
            // labelAssignemntName
            // 
            this.labelAssignemntName.AutoSize = true;
            this.labelAssignemntName.Location = new System.Drawing.Point(305, 349);
            this.labelAssignemntName.Name = "labelAssignemntName";
            this.labelAssignemntName.Size = new System.Drawing.Size(163, 18);
            this.labelAssignemntName.TabIndex = 8;
            this.labelAssignemntName.Text = "New Assignment Name";
            // 
            // textBoxAssignmentID
            // 
            this.textBoxAssignmentID.Location = new System.Drawing.Point(33, 373);
            this.textBoxAssignmentID.Name = "textBoxAssignmentID";
            this.textBoxAssignmentID.ReadOnly = true;
            this.textBoxAssignmentID.Size = new System.Drawing.Size(218, 24);
            this.textBoxAssignmentID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Assignemnt ID";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(480, 61);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Process";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelSelectedStudent
            // 
            this.labelSelectedStudent.AutoSize = true;
            this.labelSelectedStudent.Location = new System.Drawing.Point(29, 35);
            this.labelSelectedStudent.Name = "labelSelectedStudent";
            this.labelSelectedStudent.Size = new System.Drawing.Size(119, 18);
            this.labelSelectedStudent.TabIndex = 1;
            this.labelSelectedStudent.Text = "Selected Student";
            // 
            // comboStudentName
            // 
            this.comboStudentName.FormattingEnabled = true;
            this.comboStudentName.Location = new System.Drawing.Point(33, 59);
            this.comboStudentName.Name = "comboStudentName";
            this.comboStudentName.Size = new System.Drawing.Size(262, 26);
            this.comboStudentName.TabIndex = 0;
            this.comboStudentName.SelectedIndexChanged += new System.EventHandler(this.comboStudentName_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.assignmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // assignmentToolStripMenuItem
            // 
            this.assignmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.findToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.assignmentToolStripMenuItem.Name = "assignmentToolStripMenuItem";
            this.assignmentToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.assignmentToolStripMenuItem.Text = "Assignment";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnUpdateAssignments);
            this.groupBox2.Controls.Add(this.rbtnUpdateStudent);
            this.groupBox2.Location = new System.Drawing.Point(308, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 76);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update";
            // 
            // rbtnUpdateStudent
            // 
            this.rbtnUpdateStudent.AutoSize = true;
            this.rbtnUpdateStudent.Location = new System.Drawing.Point(24, 21);
            this.rbtnUpdateStudent.Name = "rbtnUpdateStudent";
            this.rbtnUpdateStudent.Size = new System.Drawing.Size(79, 22);
            this.rbtnUpdateStudent.TabIndex = 18;
            this.rbtnUpdateStudent.TabStop = true;
            this.rbtnUpdateStudent.Text = "Student";
            this.rbtnUpdateStudent.UseVisualStyleBackColor = true;
            this.rbtnUpdateStudent.CheckedChanged += new System.EventHandler(this.rbtnUpdateStudent_CheckedChanged);
            // 
            // rbtnUpdateAssignments
            // 
            this.rbtnUpdateAssignments.AutoSize = true;
            this.rbtnUpdateAssignments.Location = new System.Drawing.Point(24, 47);
            this.rbtnUpdateAssignments.Name = "rbtnUpdateAssignments";
            this.rbtnUpdateAssignments.Size = new System.Drawing.Size(114, 22);
            this.rbtnUpdateAssignments.TabIndex = 19;
            this.rbtnUpdateAssignments.TabStop = true;
            this.rbtnUpdateAssignments.Text = "Assignments";
            this.rbtnUpdateAssignments.UseVisualStyleBackColor = true;
            this.rbtnUpdateAssignments.CheckedChanged += new System.EventHandler(this.rbtnUpdateAssignments_CheckedChanged);
            // 
            // DataUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 470);
            this.Controls.Add(this.groupBoxUpdateStudent);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DataUpdateForm";
            this.Text = "DataUpdateForm";
            this.groupBoxUpdateStudent.ResumeLayout(false);
            this.groupBoxUpdateStudent.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignments)).EndInit();
            this.findAssignmentGroupBox.ResumeLayout(false);
            this.findAssignmentGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUpdateStudent;
        private System.Windows.Forms.Label labelSelectedStudent;
        private System.Windows.Forms.ComboBox comboStudentName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripMenuItem assignmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAssignmentScore;
        private System.Windows.Forms.TextBox textBoxAssignmentName;
        private System.Windows.Forms.Label labelAssignmentScore;
        private System.Windows.Forms.Label labelAssignemntName;
        private System.Windows.Forms.TextBox textBoxAssignmentID;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.Label labelAssignmentIDSearch;
        private System.Windows.Forms.TextBox textBoxAssignmentIDSearch;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox findAssignmentGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewAssignments;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxScore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnUpdateAssignments;
        private System.Windows.Forms.RadioButton rbtnUpdateStudent;
    }
}