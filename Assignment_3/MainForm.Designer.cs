namespace Assignment_3
{
    partial class MainForm
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
            this.listOfStudents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.rbtnUpdate = new System.Windows.Forms.RadioButton();
            this.rbtnDelete = new System.Windows.Forms.RadioButton();
            this.rbtnExit = new System.Windows.Forms.RadioButton();
            this.grpBoxOperation = new System.Windows.Forms.GroupBox();
            this.btnPerform = new System.Windows.Forms.Button();
            this.txtScoreTotal = new System.Windows.Forms.TextBox();
            this.txtScoreCount = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.labelScoreTotal = new System.Windows.Forms.Label();
            this.labelScoreCount = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoxOperation.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOfStudents
            // 
            this.listOfStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfStudents.FormattingEnabled = true;
            this.listOfStudents.ItemHeight = 18;
            this.listOfStudents.Location = new System.Drawing.Point(44, 78);
            this.listOfStudents.Name = "listOfStudents";
            this.listOfStudents.Size = new System.Drawing.Size(677, 166);
            this.listOfStudents.TabIndex = 0;
            this.listOfStudents.SelectedIndexChanged += new System.EventHandler(this.listOfStudents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students";
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Location = new System.Drawing.Point(44, 39);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(54, 22);
            this.rbtnAdd.TabIndex = 2;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "&Add";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            // 
            // rbtnUpdate
            // 
            this.rbtnUpdate.AutoSize = true;
            this.rbtnUpdate.Location = new System.Drawing.Point(44, 82);
            this.rbtnUpdate.Name = "rbtnUpdate";
            this.rbtnUpdate.Size = new System.Drawing.Size(76, 22);
            this.rbtnUpdate.TabIndex = 3;
            this.rbtnUpdate.TabStop = true;
            this.rbtnUpdate.Text = "&Update";
            this.rbtnUpdate.UseVisualStyleBackColor = true;
            // 
            // rbtnDelete
            // 
            this.rbtnDelete.AutoSize = true;
            this.rbtnDelete.Location = new System.Drawing.Point(44, 124);
            this.rbtnDelete.Name = "rbtnDelete";
            this.rbtnDelete.Size = new System.Drawing.Size(71, 22);
            this.rbtnDelete.TabIndex = 4;
            this.rbtnDelete.TabStop = true;
            this.rbtnDelete.Text = "&Delete";
            this.rbtnDelete.UseVisualStyleBackColor = true;
            // 
            // rbtnExit
            // 
            this.rbtnExit.AutoSize = true;
            this.rbtnExit.Location = new System.Drawing.Point(44, 162);
            this.rbtnExit.Name = "rbtnExit";
            this.rbtnExit.Size = new System.Drawing.Size(53, 22);
            this.rbtnExit.TabIndex = 5;
            this.rbtnExit.TabStop = true;
            this.rbtnExit.Text = "E&xit";
            this.rbtnExit.UseVisualStyleBackColor = true;
            // 
            // grpBoxOperation
            // 
            this.grpBoxOperation.Controls.Add(this.rbtnAdd);
            this.grpBoxOperation.Controls.Add(this.rbtnExit);
            this.grpBoxOperation.Controls.Add(this.rbtnUpdate);
            this.grpBoxOperation.Controls.Add(this.rbtnDelete);
            this.grpBoxOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxOperation.Location = new System.Drawing.Point(903, 53);
            this.grpBoxOperation.Name = "grpBoxOperation";
            this.grpBoxOperation.Size = new System.Drawing.Size(174, 212);
            this.grpBoxOperation.TabIndex = 6;
            this.grpBoxOperation.TabStop = false;
            this.grpBoxOperation.Text = "Operation";
            this.grpBoxOperation.Visible = false;
            // 
            // btnPerform
            // 
            this.btnPerform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerform.Location = new System.Drawing.Point(903, 283);
            this.btnPerform.Name = "btnPerform";
            this.btnPerform.Size = new System.Drawing.Size(174, 53);
            this.btnPerform.TabIndex = 7;
            this.btnPerform.Text = "Perform";
            this.btnPerform.UseVisualStyleBackColor = true;
            this.btnPerform.Visible = false;
            this.btnPerform.Click += new System.EventHandler(this.btnPerform_Click);
            // 
            // txtScoreTotal
            // 
            this.txtScoreTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScoreTotal.Location = new System.Drawing.Point(141, 272);
            this.txtScoreTotal.Name = "txtScoreTotal";
            this.txtScoreTotal.ReadOnly = true;
            this.txtScoreTotal.Size = new System.Drawing.Size(112, 24);
            this.txtScoreTotal.TabIndex = 8;
            // 
            // txtScoreCount
            // 
            this.txtScoreCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScoreCount.Location = new System.Drawing.Point(397, 275);
            this.txtScoreCount.Name = "txtScoreCount";
            this.txtScoreCount.ReadOnly = true;
            this.txtScoreCount.Size = new System.Drawing.Size(112, 24);
            this.txtScoreCount.TabIndex = 9;
            // 
            // txtAverage
            // 
            this.txtAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAverage.Location = new System.Drawing.Point(609, 275);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(112, 24);
            this.txtAverage.TabIndex = 10;
            // 
            // labelScoreTotal
            // 
            this.labelScoreTotal.AutoSize = true;
            this.labelScoreTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreTotal.Location = new System.Drawing.Point(50, 275);
            this.labelScoreTotal.Name = "labelScoreTotal";
            this.labelScoreTotal.Size = new System.Drawing.Size(85, 18);
            this.labelScoreTotal.TabIndex = 11;
            this.labelScoreTotal.Text = "Score Total";
            // 
            // labelScoreCount
            // 
            this.labelScoreCount.AutoSize = true;
            this.labelScoreCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreCount.Location = new System.Drawing.Point(299, 278);
            this.labelScoreCount.Name = "labelScoreCount";
            this.labelScoreCount.Size = new System.Drawing.Size(92, 18);
            this.labelScoreCount.TabIndex = 12;
            this.labelScoreCount.Text = "Score Count";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAverage.Location = new System.Drawing.Point(542, 281);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(61, 18);
            this.labelAverage.TabIndex = 13;
            this.labelAverage.Text = "Average";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1077, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.operationsToolStripMenuItem.Text = "&Student";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.updateToolStripMenuItem.Text = "&Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FirstName,
            this.LastName,
            this.Age,
            this.Gender,
            this.ClassName,
            this.TotalScore});
            this.dataGridViewStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStudents.Location = new System.Drawing.Point(3, 20);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(933, 300);
            this.dataGridViewStudents.TabIndex = 15;
            this.dataGridViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewStudents);
            this.groupBox1.Location = new System.Drawing.Point(27, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 323);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // StudentID
            // 
            this.StudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StudentID.Frozen = true;
            this.StudentID.HeaderText = "ID";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FirstName.Frozen = true;
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LastName.Frozen = true;
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // Age
            // 
            this.Age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Age.Frozen = true;
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 125;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gender.Frozen = true;
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 125;
            // 
            // ClassName
            // 
            this.ClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClassName.Frozen = true;
            this.ClassName.HeaderText = "Class Name";
            this.ClassName.MinimumWidth = 6;
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.Width = 125;
            // 
            // TotalScore
            // 
            this.TotalScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TotalScore.Frozen = true;
            this.TotalScore.HeaderText = "Total Score";
            this.TotalScore.MinimumWidth = 6;
            this.TotalScore.Name = "TotalScore";
            this.TotalScore.ReadOnly = true;
            this.TotalScore.Width = 125;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnPerform;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1077, 683);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelScoreCount);
            this.Controls.Add(this.labelScoreTotal);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtScoreCount);
            this.Controls.Add(this.txtScoreTotal);
            this.Controls.Add(this.btnPerform);
            this.Controls.Add(this.grpBoxOperation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listOfStudents);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Scores";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpBoxOperation.ResumeLayout(false);
            this.grpBoxOperation.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listOfStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.RadioButton rbtnUpdate;
        private System.Windows.Forms.RadioButton rbtnDelete;
        private System.Windows.Forms.RadioButton rbtnExit;
        private System.Windows.Forms.GroupBox grpBoxOperation;
        private System.Windows.Forms.Button btnPerform;
        private System.Windows.Forms.TextBox txtScoreTotal;
        private System.Windows.Forms.TextBox txtScoreCount;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Label labelScoreTotal;
        private System.Windows.Forms.Label labelScoreCount;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalScore;
    }
}

