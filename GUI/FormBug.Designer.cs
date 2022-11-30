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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBug));
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.lblBugId = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.lblLastEditDate = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblSolved = new System.Windows.Forms.Label();
            this.lblSeverity = new System.Windows.Forms.Label();
            this.txtBugId = new System.Windows.Forms.TextBox();
            this.txtCreator = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblMessagesList = new System.Windows.Forms.Label();
            this.lblBugInfos = new System.Windows.Forms.Label();
            this.lblLogsList = new System.Windows.Forms.Label();
            this.txtCreationDate = new System.Windows.Forms.TextBox();
            this.txtLastEditDate = new System.Windows.Forms.TextBox();
            this.imgBugSmall = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.radSolvedNo = new System.Windows.Forms.RadioButton();
            this.radSolvedYes = new System.Windows.Forms.RadioButton();
            this.comboPriority = new System.Windows.Forms.ComboBox();
            this.comboSeverity = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddMessage = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBugSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMessages
            // 
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.Location = new System.Drawing.Point(487, 89);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.ReadOnly = true;
            this.dgvMessages.RowHeadersWidth = 51;
            this.dgvMessages.RowTemplate.Height = 29;
            this.dgvMessages.Size = new System.Drawing.Size(752, 150);
            this.dgvMessages.TabIndex = 0;
            // 
            // lblBugId
            // 
            this.lblBugId.AutoSize = true;
            this.lblBugId.Location = new System.Drawing.Point(19, 92);
            this.lblBugId.Name = "lblBugId";
            this.lblBugId.Size = new System.Drawing.Size(52, 20);
            this.lblBugId.TabIndex = 1;
            this.lblBugId.Text = "Bug Id";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(19, 215);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(101, 20);
            this.lblCreationDate.TabIndex = 2;
            this.lblCreationDate.Text = "Creation Date";
            // 
            // lblLastEditDate
            // 
            this.lblLastEditDate.AutoSize = true;
            this.lblLastEditDate.Location = new System.Drawing.Point(19, 255);
            this.lblLastEditDate.Name = "lblLastEditDate";
            this.lblLastEditDate.Size = new System.Drawing.Size(101, 20);
            this.lblLastEditDate.TabIndex = 3;
            this.lblLastEditDate.Text = "Last Edit Date";
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Location = new System.Drawing.Point(19, 176);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(58, 20);
            this.lblCreator.TabIndex = 4;
            this.lblCreator.Text = "Creator";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 137);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(19, 378);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 20);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(19, 338);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(56, 20);
            this.lblPriority.TabIndex = 7;
            this.lblPriority.Text = "Priority";
            // 
            // lblSolved
            // 
            this.lblSolved.AutoSize = true;
            this.lblSolved.Location = new System.Drawing.Point(19, 419);
            this.lblSolved.Name = "lblSolved";
            this.lblSolved.Size = new System.Drawing.Size(54, 20);
            this.lblSolved.TabIndex = 8;
            this.lblSolved.Text = "Solved";
            // 
            // lblSeverity
            // 
            this.lblSeverity.AutoSize = true;
            this.lblSeverity.Location = new System.Drawing.Point(19, 290);
            this.lblSeverity.Name = "lblSeverity";
            this.lblSeverity.Size = new System.Drawing.Size(61, 20);
            this.lblSeverity.TabIndex = 9;
            this.lblSeverity.Text = "Severity";
            // 
            // txtBugId
            // 
            this.txtBugId.Location = new System.Drawing.Point(174, 92);
            this.txtBugId.Name = "txtBugId";
            this.txtBugId.ReadOnly = true;
            this.txtBugId.Size = new System.Drawing.Size(244, 27);
            this.txtBugId.TabIndex = 14;
            // 
            // txtCreator
            // 
            this.txtCreator.Location = new System.Drawing.Point(174, 176);
            this.txtCreator.Name = "txtCreator";
            this.txtCreator.ReadOnly = true;
            this.txtCreator.Size = new System.Drawing.Size(244, 27);
            this.txtCreator.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 137);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(244, 27);
            this.txtName.TabIndex = 16;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(172, 378);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(246, 27);
            this.txtDescription.TabIndex = 17;
            // 
            // lblMessagesList
            // 
            this.lblMessagesList.AutoSize = true;
            this.lblMessagesList.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMessagesList.Location = new System.Drawing.Point(487, 55);
            this.lblMessagesList.Name = "lblMessagesList";
            this.lblMessagesList.Size = new System.Drawing.Size(189, 31);
            this.lblMessagesList.TabIndex = 47;
            this.lblMessagesList.Text = "List of Messages";
            // 
            // lblBugInfos
            // 
            this.lblBugInfos.AutoSize = true;
            this.lblBugInfos.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBugInfos.Location = new System.Drawing.Point(80, 12);
            this.lblBugInfos.Name = "lblBugInfos";
            this.lblBugInfos.Size = new System.Drawing.Size(143, 38);
            this.lblBugInfos.TabIndex = 71;
            this.lblBugInfos.Text = "Bug Infos";
            // 
            // lblLogsList
            // 
            this.lblLogsList.AutoSize = true;
            this.lblLogsList.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogsList.Location = new System.Drawing.Point(487, 255);
            this.lblLogsList.Name = "lblLogsList";
            this.lblLogsList.Size = new System.Drawing.Size(137, 31);
            this.lblLogsList.TabIndex = 72;
            this.lblLogsList.Text = "List of Logs";
            // 
            // txtCreationDate
            // 
            this.txtCreationDate.Location = new System.Drawing.Point(174, 215);
            this.txtCreationDate.Name = "txtCreationDate";
            this.txtCreationDate.ReadOnly = true;
            this.txtCreationDate.Size = new System.Drawing.Size(244, 27);
            this.txtCreationDate.TabIndex = 73;
            // 
            // txtLastEditDate
            // 
            this.txtLastEditDate.Location = new System.Drawing.Point(174, 255);
            this.txtLastEditDate.Name = "txtLastEditDate";
            this.txtLastEditDate.ReadOnly = true;
            this.txtLastEditDate.Size = new System.Drawing.Size(244, 27);
            this.txtLastEditDate.TabIndex = 74;
            // 
            // imgBugSmall
            // 
            this.imgBugSmall.Image = ((System.Drawing.Image)(resources.GetObject("imgBugSmall.Image")));
            this.imgBugSmall.Location = new System.Drawing.Point(19, 12);
            this.imgBugSmall.Name = "imgBugSmall";
            this.imgBugSmall.Size = new System.Drawing.Size(55, 62);
            this.imgBugSmall.TabIndex = 77;
            this.imgBugSmall.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(487, 287);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(752, 150);
            this.richTextBox1.TabIndex = 78;
            this.richTextBox1.Text = "";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Orange;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(795, 471);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(144, 50);
            this.btnEdit.TabIndex = 79;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // radSolvedNo
            // 
            this.radSolvedNo.AutoSize = true;
            this.radSolvedNo.Enabled = false;
            this.radSolvedNo.Location = new System.Drawing.Point(313, 421);
            this.radSolvedNo.Name = "radSolvedNo";
            this.radSolvedNo.Size = new System.Drawing.Size(50, 24);
            this.radSolvedNo.TabIndex = 81;
            this.radSolvedNo.TabStop = true;
            this.radSolvedNo.Text = "No";
            this.radSolvedNo.UseVisualStyleBackColor = true;
            // 
            // radSolvedYes
            // 
            this.radSolvedYes.AutoSize = true;
            this.radSolvedYes.Enabled = false;
            this.radSolvedYes.Location = new System.Drawing.Point(217, 419);
            this.radSolvedYes.Name = "radSolvedYes";
            this.radSolvedYes.Size = new System.Drawing.Size(51, 24);
            this.radSolvedYes.TabIndex = 80;
            this.radSolvedYes.TabStop = true;
            this.radSolvedYes.Text = "Yes";
            this.radSolvedYes.UseVisualStyleBackColor = true;
            // 
            // comboPriority
            // 
            this.comboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPriority.Enabled = false;
            this.comboPriority.FormattingEnabled = true;
            this.comboPriority.Location = new System.Drawing.Point(174, 335);
            this.comboPriority.Name = "comboPriority";
            this.comboPriority.Size = new System.Drawing.Size(244, 28);
            this.comboPriority.TabIndex = 82;
            // 
            // comboSeverity
            // 
            this.comboSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSeverity.Enabled = false;
            this.comboSeverity.FormattingEnabled = true;
            this.comboSeverity.Location = new System.Drawing.Point(174, 290);
            this.comboSeverity.Name = "comboSeverity";
            this.comboSeverity.Size = new System.Drawing.Size(244, 28);
            this.comboSeverity.TabIndex = 83;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(1095, 471);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 50);
            this.btnSave.TabIndex = 84;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightPink;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(945, 471);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 50);
            this.btnCancel.TabIndex = 85;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAddMessage
            // 
            this.btnAddMessage.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMessage.Location = new System.Drawing.Point(637, 471);
            this.btnAddMessage.Name = "btnAddMessage";
            this.btnAddMessage.Size = new System.Drawing.Size(152, 50);
            this.btnAddMessage.TabIndex = 86;
            this.btnAddMessage.Text = "Add Message";
            this.btnAddMessage.UseVisualStyleBackColor = false;
            this.btnAddMessage.Click += new System.EventHandler(this.btnNewMessage_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(487, 471);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 50);
            this.btnAdd.TabIndex = 87;
            this.btnAdd.Text = "Add bug";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // FormBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 538);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAddMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboSeverity);
            this.Controls.Add(this.comboPriority);
            this.Controls.Add(this.radSolvedNo);
            this.Controls.Add(this.radSolvedYes);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.imgBugSmall);
            this.Controls.Add(this.txtLastEditDate);
            this.Controls.Add(this.txtCreationDate);
            this.Controls.Add(this.lblLogsList);
            this.Controls.Add(this.lblBugInfos);
            this.Controls.Add(this.lblMessagesList);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCreator);
            this.Controls.Add(this.txtBugId);
            this.Controls.Add(this.lblSeverity);
            this.Controls.Add(this.lblSolved);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.lblLastEditDate);
            this.Controls.Add(this.lblCreationDate);
            this.Controls.Add(this.lblBugId);
            this.Controls.Add(this.dgvMessages);
            this.Name = "FormBug";
            this.Text = "Bug Info";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBugSmall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvMessages;
        private Label lblBugId;
        private Label lblCreationDate;
        private Label lblLastEditDate;
        private Label lblCreator;
        private Label lblName;
        private Label lblDescription;
        private Label lblPriority;
        private Label lblSolved;
        private Label lblSeverity;
        private TextBox txtBugId;
        private TextBox txtCreator;
        private TextBox txtName;
        private TextBox txtDescription;
        private Label lblMessagesList;
        private Label lblBugInfos;
        private Label lblLogsList;
        private TextBox txtCreationDate;
        private TextBox txtLastEditDate;
        private PictureBox imgBugSmall;
        private RichTextBox richTextBox1;
        private Button btnEdit;
        private RadioButton radSolvedNo;
        private RadioButton radSolvedYes;
        private ComboBox comboPriority;
        private ComboBox comboSeverity;
        private Button btnSave;
        private Button btnCancel;
        private Button btnAddMessage;
        private Button btnAdd;
    }
}