namespace GUI
{
    partial class FormSelection
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timeCreationDate = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCreator = new System.Windows.Forms.TextBox();
            this.txtBugId = new System.Windows.Forms.TextBox();
            this.comboSeverity = new System.Windows.Forms.ComboBox();
            this.comboPriority = new System.Windows.Forms.ComboBox();
            this.cbxSolvedNo = new System.Windows.Forms.CheckBox();
            this.cbxSolvedYes = new System.Windows.Forms.CheckBox();
            this.lblSeverity = new System.Windows.Forms.Label();
            this.lblSolved = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblLastEditDate = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.lblBugId = new System.Windows.Forms.Label();
            this.dgvBugsList = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(737, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 27);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // timeCreationDate
            // 
            this.timeCreationDate.Location = new System.Drawing.Point(216, 53);
            this.timeCreationDate.Name = "timeCreationDate";
            this.timeCreationDate.Size = new System.Drawing.Size(246, 27);
            this.timeCreationDate.TabIndex = 38;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(216, 150);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(246, 27);
            this.txtDescription.TabIndex = 37;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(737, 150);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 27);
            this.txtName.TabIndex = 36;
            // 
            // txtCreator
            // 
            this.txtCreator.Location = new System.Drawing.Point(737, 12);
            this.txtCreator.Name = "txtCreator";
            this.txtCreator.Size = new System.Drawing.Size(244, 27);
            this.txtCreator.TabIndex = 35;
            // 
            // txtBugId
            // 
            this.txtBugId.Location = new System.Drawing.Point(216, 11);
            this.txtBugId.Name = "txtBugId";
            this.txtBugId.Size = new System.Drawing.Size(246, 27);
            this.txtBugId.TabIndex = 34;
            // 
            // comboSeverity
            // 
            this.comboSeverity.FormattingEnabled = true;
            this.comboSeverity.Location = new System.Drawing.Point(737, 105);
            this.comboSeverity.Name = "comboSeverity";
            this.comboSeverity.Size = new System.Drawing.Size(244, 28);
            this.comboSeverity.TabIndex = 33;
            // 
            // comboPriority
            // 
            this.comboPriority.FormattingEnabled = true;
            this.comboPriority.Location = new System.Drawing.Point(216, 97);
            this.comboPriority.Name = "comboPriority";
            this.comboPriority.Size = new System.Drawing.Size(246, 28);
            this.comboPriority.TabIndex = 32;
            // 
            // cbxSolvedNo
            // 
            this.cbxSolvedNo.AutoSize = true;
            this.cbxSolvedNo.Location = new System.Drawing.Point(355, 201);
            this.cbxSolvedNo.Name = "cbxSolvedNo";
            this.cbxSolvedNo.Size = new System.Drawing.Size(51, 24);
            this.cbxSolvedNo.TabIndex = 31;
            this.cbxSolvedNo.Text = "No";
            this.cbxSolvedNo.UseVisualStyleBackColor = true;
            // 
            // cbxSolvedYes
            // 
            this.cbxSolvedYes.AutoSize = true;
            this.cbxSolvedYes.Location = new System.Drawing.Point(258, 201);
            this.cbxSolvedYes.Name = "cbxSolvedYes";
            this.cbxSolvedYes.Size = new System.Drawing.Size(52, 24);
            this.cbxSolvedYes.TabIndex = 30;
            this.cbxSolvedYes.Text = "Yes";
            this.cbxSolvedYes.UseVisualStyleBackColor = true;
            // 
            // lblSeverity
            // 
            this.lblSeverity.AutoSize = true;
            this.lblSeverity.Location = new System.Drawing.Point(576, 105);
            this.lblSeverity.Name = "lblSeverity";
            this.lblSeverity.Size = new System.Drawing.Size(61, 20);
            this.lblSeverity.TabIndex = 29;
            this.lblSeverity.Text = "Severity";
            // 
            // lblSolved
            // 
            this.lblSolved.AutoSize = true;
            this.lblSolved.Location = new System.Drawing.Point(87, 205);
            this.lblSolved.Name = "lblSolved";
            this.lblSolved.Size = new System.Drawing.Size(54, 20);
            this.lblSolved.TabIndex = 28;
            this.lblSolved.Text = "Solved";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(85, 105);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(56, 20);
            this.lblPriority.TabIndex = 27;
            this.lblPriority.Text = "Priority";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(87, 157);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 20);
            this.lblDescription.TabIndex = 26;
            this.lblDescription.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(576, 157);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Name";
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Location = new System.Drawing.Point(576, 13);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(58, 20);
            this.lblCreator.TabIndex = 24;
            this.lblCreator.Text = "Creator";
            // 
            // lblLastEditDate
            // 
            this.lblLastEditDate.AutoSize = true;
            this.lblLastEditDate.Location = new System.Drawing.Point(576, 60);
            this.lblLastEditDate.Name = "lblLastEditDate";
            this.lblLastEditDate.Size = new System.Drawing.Size(101, 20);
            this.lblLastEditDate.TabIndex = 23;
            this.lblLastEditDate.Text = "Last Edit Date";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(85, 60);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(101, 20);
            this.lblCreationDate.TabIndex = 22;
            this.lblCreationDate.Text = "Creation Date";
            // 
            // lblBugId
            // 
            this.lblBugId.AutoSize = true;
            this.lblBugId.Location = new System.Drawing.Point(85, 13);
            this.lblBugId.Name = "lblBugId";
            this.lblBugId.Size = new System.Drawing.Size(52, 20);
            this.lblBugId.TabIndex = 21;
            this.lblBugId.Text = "Bug Id";
            // 
            // dgvBugsList
            // 
            this.dgvBugsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBugsList.Location = new System.Drawing.Point(71, 270);
            this.dgvBugsList.Name = "dgvBugsList";
            this.dgvBugsList.ReadOnly = true;
            this.dgvBugsList.RowHeadersWidth = 51;
            this.dgvBugsList.RowTemplate.Height = 29;
            this.dgvBugsList.Size = new System.Drawing.Size(910, 223);
            this.dgvBugsList.TabIndex = 20;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Lime;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(837, 201);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 50);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // FormSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 514);
            this.Controls.Add(this.btnSearch);
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
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker timeCreationDate;
        private TextBox txtDescription;
        private TextBox txtName;
        private TextBox txtCreator;
        private TextBox txtBugId;
        private ComboBox comboSeverity;
        private ComboBox comboPriority;
        private CheckBox cbxSolvedNo;
        private CheckBox cbxSolvedYes;
        private Label lblSeverity;
        private Label lblSolved;
        private Label lblPriority;
        private Label lblDescription;
        private Label lblName;
        private Label lblCreator;
        private Label lblLastEditDate;
        private Label lblCreationDate;
        private Label lblBugId;
        private DataGridView dgvBugsList;
        private Button btnSearch;
    }
}