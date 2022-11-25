namespace GUI
{
    partial class FormAddBugs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddBugs));
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comboSeverity = new System.Windows.Forms.ComboBox();
            this.comboPriority = new System.Windows.Forms.ComboBox();
            this.lblSeverity = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.imgMediumBug = new System.Windows.Forms.PictureBox();
            this.lblInfoMandatoryFields = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblAddBugs = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtCreatorId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgMediumBug)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(146, 314);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(492, 121);
            this.txtDescription.TabIndex = 61;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(146, 155);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 27);
            this.txtName.TabIndex = 60;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // comboSeverity
            // 
            this.comboSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSeverity.FormattingEnabled = true;
            this.comboSeverity.Location = new System.Drawing.Point(146, 258);
            this.comboSeverity.Name = "comboSeverity";
            this.comboSeverity.Size = new System.Drawing.Size(246, 28);
            this.comboSeverity.TabIndex = 58;
            this.comboSeverity.SelectedIndexChanged += new System.EventHandler(this.comboSeverity_SelectedIndexChanged);
            // 
            // comboPriority
            // 
            this.comboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPriority.FormattingEnabled = true;
            this.comboPriority.Location = new System.Drawing.Point(146, 208);
            this.comboPriority.Name = "comboPriority";
            this.comboPriority.Size = new System.Drawing.Size(246, 28);
            this.comboPriority.TabIndex = 57;
            this.comboPriority.SelectedIndexChanged += new System.EventHandler(this.comboPriority_SelectedIndexChanged);
            // 
            // lblSeverity
            // 
            this.lblSeverity.AutoSize = true;
            this.lblSeverity.Location = new System.Drawing.Point(25, 258);
            this.lblSeverity.Name = "lblSeverity";
            this.lblSeverity.Size = new System.Drawing.Size(71, 20);
            this.lblSeverity.TabIndex = 56;
            this.lblSeverity.Text = "Severity *";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(25, 208);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(66, 20);
            this.lblPriority.TabIndex = 55;
            this.lblPriority.Text = "Priority *";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(25, 314);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 20);
            this.lblDescription.TabIndex = 54;
            this.lblDescription.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 155);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 20);
            this.lblName.TabIndex = 53;
            this.lblName.Text = "Bug Name *";
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Location = new System.Drawing.Point(25, 111);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(85, 20);
            this.lblCreator.TabIndex = 52;
            this.lblCreator.Text = "Creator Id *";
            // 
            // imgMediumBug
            // 
            this.imgMediumBug.Image = ((System.Drawing.Image)(resources.GetObject("imgMediumBug.Image")));
            this.imgMediumBug.Location = new System.Drawing.Point(512, 102);
            this.imgMediumBug.Name = "imgMediumBug";
            this.imgMediumBug.Size = new System.Drawing.Size(126, 146);
            this.imgMediumBug.TabIndex = 65;
            this.imgMediumBug.TabStop = false;
            // 
            // lblInfoMandatoryFields
            // 
            this.lblInfoMandatoryFields.AutoSize = true;
            this.lblInfoMandatoryFields.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblInfoMandatoryFields.Location = new System.Drawing.Point(25, 57);
            this.lblInfoMandatoryFields.Name = "lblInfoMandatoryFields";
            this.lblInfoMandatoryFields.Size = new System.Drawing.Size(265, 20);
            this.lblInfoMandatoryFields.TabIndex = 66;
            this.lblInfoMandatoryFields.Text = "The fields with an asterix are mandatory";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(146, 462);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(492, 50);
            this.btnAdd.TabIndex = 67;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(90, 462);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(50, 50);
            this.btnReset.TabIndex = 68;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblAddBugs
            // 
            this.lblAddBugs.AutoSize = true;
            this.lblAddBugs.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddBugs.Location = new System.Drawing.Point(25, 9);
            this.lblAddBugs.Name = "lblAddBugs";
            this.lblAddBugs.Size = new System.Drawing.Size(136, 38);
            this.lblAddBugs.TabIndex = 69;
            this.lblAddBugs.Text = "New Bug";
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(25, 462);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 70;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtCreatorId
            // 
            this.txtCreatorId.Location = new System.Drawing.Point(146, 111);
            this.txtCreatorId.Name = "txtCreatorId";
            this.txtCreatorId.Size = new System.Drawing.Size(244, 27);
            this.txtCreatorId.TabIndex = 71;
            this.txtCreatorId.TextChanged += new System.EventHandler(this.txtCreatorId_TextChanged);
            // 
            // FormAddBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 524);
            this.Controls.Add(this.txtCreatorId);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAddBugs);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblInfoMandatoryFields);
            this.Controls.Add(this.imgMediumBug);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.comboSeverity);
            this.Controls.Add(this.comboPriority);
            this.Controls.Add(this.lblSeverity);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCreator);
            this.Name = "FormAddBugs";
            this.Text = "Add Bug";
            ((System.ComponentModel.ISupportInitialize)(this.imgMediumBug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtDescription;
        private TextBox txtName;
        private ComboBox comboSeverity;
        private ComboBox comboPriority;
        private Label lblSeverity;
        private Label lblPriority;
        private Label lblDescription;
        private Label lblName;
        private Label lblCreator;
        private PictureBox imgMediumBug;
        private Label lblInfoMAndatoryFields;
        private Button btnAdd;
        private Button btnReset;
        private Label lblAddBugs;
        private Button btnBack;
        private TextBox txtCreatorId;
        private Label lblInfoMandatoryFields;
    }
}