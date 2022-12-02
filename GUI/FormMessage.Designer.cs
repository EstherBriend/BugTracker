namespace GUI
{
    partial class formMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMessage));
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtCreationDate = new System.Windows.Forms.TextBox();
            this.txtBugId = new System.Windows.Forms.TextBox();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBugId = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblInfoMandatoryFields = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtCreator = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(184, 67);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(310, 27);
            this.txtId.TabIndex = 13;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(41, 67);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 20);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Id";
            // 
            // txtCreationDate
            // 
            this.txtCreationDate.Location = new System.Drawing.Point(184, 198);
            this.txtCreationDate.Name = "txtCreationDate";
            this.txtCreationDate.ReadOnly = true;
            this.txtCreationDate.Size = new System.Drawing.Size(310, 27);
            this.txtCreationDate.TabIndex = 23;
            // 
            // txtBugId
            // 
            this.txtBugId.Location = new System.Drawing.Point(184, 113);
            this.txtBugId.Name = "txtBugId";
            this.txtBugId.ReadOnly = true;
            this.txtBugId.Size = new System.Drawing.Size(310, 27);
            this.txtBugId.TabIndex = 21;
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(41, 198);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(101, 20);
            this.lblCreationDate.TabIndex = 20;
            this.lblCreationDate.Text = "Creation Date";
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Location = new System.Drawing.Point(41, 153);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(58, 20);
            this.lblCreator.TabIndex = 19;
            this.lblCreator.Text = "Creator";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(41, 246);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 20);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Title";
            // 
            // lblBugId
            // 
            this.lblBugId.AutoSize = true;
            this.lblBugId.Location = new System.Drawing.Point(41, 113);
            this.lblBugId.Name = "lblBugId";
            this.lblBugId.Size = new System.Drawing.Size(52, 20);
            this.lblBugId.TabIndex = 17;
            this.lblBugId.Text = "Bug Id";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(43, 287);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(36, 20);
            this.lblText.TabIndex = 25;
            this.lblText.Text = "Text";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(184, 483);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(310, 50);
            this.btnAdd.TabIndex = 68;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.Location = new System.Drawing.Point(41, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(130, 38);
            this.lblMessage.TabIndex = 71;
            this.lblMessage.Text = "Message";
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(106, 483);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(50, 50);
            this.btnReset.TabIndex = 73;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblInfoMandatoryFields
            // 
            this.lblInfoMandatoryFields.AutoSize = true;
            this.lblInfoMandatoryFields.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblInfoMandatoryFields.Location = new System.Drawing.Point(41, 67);
            this.lblInfoMandatoryFields.Name = "lblInfoMandatoryFields";
            this.lblInfoMandatoryFields.Size = new System.Drawing.Size(265, 20);
            this.lblInfoMandatoryFields.TabIndex = 74;
            this.lblInfoMandatoryFields.Text = "The fields with an asterix are mandatory";
            this.lblInfoMandatoryFields.Visible = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(184, 246);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(310, 27);
            this.txtTitle.TabIndex = 75;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(184, 287);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ReadOnly = true;
            this.txtText.Size = new System.Drawing.Size(310, 164);
            this.txtText.TabIndex = 77;
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            // 
            // txtCreator
            // 
            this.txtCreator.Location = new System.Drawing.Point(184, 153);
            this.txtCreator.Name = "txtCreator";
            this.txtCreator.ReadOnly = true;
            this.txtCreator.Size = new System.Drawing.Size(310, 27);
            this.txtCreator.TabIndex = 78;
            this.txtCreator.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCreator_MouseClick);
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(41, 483);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 79;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // formMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 545);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtCreator);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblInfoMandatoryFields);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtCreationDate);
            this.Controls.Add(this.txtBugId);
            this.Controls.Add(this.lblCreationDate);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBugId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "formMessage";
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtId;
        private Label lblId;
        private TextBox txtCreationDate;
        private TextBox txtBugId;
        private Label lblCreationDate;
        private Label lblCreator;
        private Label lblTitle;
        private Label lblBugId;
        private Label lblText;
        private Button btnAdd;
        private Label lblMessage;
        private Button btnReset;
        private Label lblInfoMandatoryFields;
        private TextBox txtTitle;
        private TextBox txtText;
        private TextBox txtCreator;
        private Button btnBack;
    }
}