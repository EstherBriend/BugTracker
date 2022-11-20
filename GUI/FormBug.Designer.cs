namespace GUI
{
    partial class FormBug
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
            this.dgvBugsList = new System.Windows.Forms.DataGridView();
            this.lblBugId = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.lblLastEditDate = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblSolved = new System.Windows.Forms.Label();
            this.lblSeverity = new System.Windows.Forms.Label();
            this.cbxSolvedYes = new System.Windows.Forms.CheckBox();
            this.cbxSolvedNo = new System.Windows.Forms.CheckBox();
            this.comboPriority = new System.Windows.Forms.ComboBox();
            this.comboSeverity = new System.Windows.Forms.ComboBox();
            this.txtBugId = new System.Windows.Forms.TextBox();
            this.txtCreator = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.timeCreationDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBugsList
            // 
            this.dgvBugsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBugsList.Location = new System.Drawing.Point(12, 277);
            this.dgvBugsList.Name = "dgvBugsList";
            this.dgvBugsList.ReadOnly = true;
            this.dgvBugsList.RowHeadersWidth = 51;
            this.dgvBugsList.RowTemplate.Height = 29;
            this.dgvBugsList.Size = new System.Drawing.Size(910, 223);
            this.dgvBugsList.TabIndex = 0;
            // 
            // lblBugId
            // 
            this.lblBugId.AutoSize = true;
            this.lblBugId.Location = new System.Drawing.Point(26, 20);
            this.lblBugId.Name = "lblBugId";
            this.lblBugId.Size = new System.Drawing.Size(52, 20);
            this.lblBugId.TabIndex = 1;
            this.lblBugId.Text = "Bug Id";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(26, 67);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(101, 20);
            this.lblCreationDate.TabIndex = 2;
            this.lblCreationDate.Text = "Creation Date";
            // 
            // lblLastEditDate
            // 
            this.lblLastEditDate.AutoSize = true;
            this.lblLastEditDate.Location = new System.Drawing.Point(517, 67);
            this.lblLastEditDate.Name = "lblLastEditDate";
            this.lblLastEditDate.Size = new System.Drawing.Size(101, 20);
            this.lblLastEditDate.TabIndex = 3;
            this.lblLastEditDate.Text = "Last Edit Date";
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Location = new System.Drawing.Point(517, 20);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(58, 20);
            this.lblCreator.TabIndex = 4;
            this.lblCreator.Text = "Creator";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(517, 164);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(28, 164);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 20);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(26, 112);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(56, 20);
            this.lblPriority.TabIndex = 7;
            this.lblPriority.Text = "Priority";
            // 
            // lblSolved
            // 
            this.lblSolved.AutoSize = true;
            this.lblSolved.Location = new System.Drawing.Point(28, 212);
            this.lblSolved.Name = "lblSolved";
            this.lblSolved.Size = new System.Drawing.Size(54, 20);
            this.lblSolved.TabIndex = 8;
            this.lblSolved.Text = "Solved";
            // 
            // lblSeverity
            // 
            this.lblSeverity.AutoSize = true;
            this.lblSeverity.Location = new System.Drawing.Point(517, 112);
            this.lblSeverity.Name = "lblSeverity";
            this.lblSeverity.Size = new System.Drawing.Size(61, 20);
            this.lblSeverity.TabIndex = 9;
            this.lblSeverity.Text = "Severity";
            // 
            // cbxSolvedYes
            // 
            this.cbxSolvedYes.AutoSize = true;
            this.cbxSolvedYes.Location = new System.Drawing.Point(199, 208);
            this.cbxSolvedYes.Name = "cbxSolvedYes";
            this.cbxSolvedYes.Size = new System.Drawing.Size(52, 24);
            this.cbxSolvedYes.TabIndex = 10;
            this.cbxSolvedYes.Text = "Yes";
            this.cbxSolvedYes.UseVisualStyleBackColor = true;
            // 
            // cbxSolvedNo
            // 
            this.cbxSolvedNo.AutoSize = true;
            this.cbxSolvedNo.Location = new System.Drawing.Point(296, 208);
            this.cbxSolvedNo.Name = "cbxSolvedNo";
            this.cbxSolvedNo.Size = new System.Drawing.Size(51, 24);
            this.cbxSolvedNo.TabIndex = 11;
            this.cbxSolvedNo.Text = "No";
            this.cbxSolvedNo.UseVisualStyleBackColor = true;
            // 
            // comboPriority
            // 
            this.comboPriority.FormattingEnabled = true;
            this.comboPriority.Location = new System.Drawing.Point(157, 104);
            this.comboPriority.Name = "comboPriority";
            this.comboPriority.Size = new System.Drawing.Size(246, 28);
            this.comboPriority.TabIndex = 12;
            // 
            // comboSeverity
            // 
            this.comboSeverity.FormattingEnabled = true;
            this.comboSeverity.Location = new System.Drawing.Point(678, 112);
            this.comboSeverity.Name = "comboSeverity";
            this.comboSeverity.Size = new System.Drawing.Size(244, 28);
            this.comboSeverity.TabIndex = 13;
            // 
            // txtBugId
            // 
            this.txtBugId.Location = new System.Drawing.Point(157, 18);
            this.txtBugId.Name = "txtBugId";
            this.txtBugId.Size = new System.Drawing.Size(246, 27);
            this.txtBugId.TabIndex = 14;
            // 
            // txtCreator
            // 
            this.txtCreator.Location = new System.Drawing.Point(678, 19);
            this.txtCreator.Name = "txtCreator";
            this.txtCreator.Size = new System.Drawing.Size(244, 27);
            this.txtCreator.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(678, 157);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 27);
            this.txtName.TabIndex = 16;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(157, 157);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(246, 27);
            this.txtDescription.TabIndex = 17;
            // 
            // timeCreationDate
            // 
            this.timeCreationDate.Location = new System.Drawing.Point(157, 60);
            this.timeCreationDate.Name = "timeCreationDate";
            this.timeCreationDate.Size = new System.Drawing.Size(246, 27);
            this.timeCreationDate.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(678, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 27);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // FormSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 512);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.timeCreationDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCreator);
            this.Controls.Add(this.txtBugId);
            this.Controls.Add(this.comboSeverity);
            this.Controls.Add(this.comboPriority);
            this.Controls.Add(this.cbxSolvedNo);
            this.Controls.Add(this.cbxSolvedYes);
            this.Controls.Add(this.lblSeverity);
            this.Controls.Add(this.lblSolved);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.lblLastEditDate);
            this.Controls.Add(this.lblCreationDate);
            this.Controls.Add(this.lblBugId);
            this.Controls.Add(this.dgvBugsList);
            this.Name = "FormSelection";
            this.Text = "FormSelection";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvBugsList;
        private Label lblBugId;
        private Label lblCreationDate;
        private Label lblLastEditDate;
        private Label lblCreator;
        private Label lblName;
        private Label lblDescription;
        private Label lblPriority;
        private Label lblSolved;
        private Label lblSeverity;
        private CheckBox cbxSolvedYes;
        private CheckBox cbxSolvedNo;
        private ComboBox comboPriority;
        private ComboBox comboSeverity;
        private TextBox txtBugId;
        private TextBox txtCreator;
        private TextBox txtName;
        private TextBox txtDescription;
        private DateTimePicker timeCreationDate;
        private DateTimePicker dateTimePicker1;
    }
}