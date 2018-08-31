namespace CrmPrivilegeChecker {
	partial class CrmPrivilegeCheckerControl {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.btnCheck = new System.Windows.Forms.Button();
			this.tbError = new System.Windows.Forms.TextBox();
			this.lbWho = new System.Windows.Forms.Label();
			this.lbWhat = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbRoles = new System.Windows.Forms.ComboBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.cbDepth = new System.Windows.Forms.ComboBox();
			this.lbError = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCheck
			// 
			this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCheck.Location = new System.Drawing.Point(599, 86);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(75, 23);
			this.btnCheck.TabIndex = 0;
			this.btnCheck.Text = "Check \'em";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// tbError
			// 
			this.tbError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbError.Location = new System.Drawing.Point(25, 32);
			this.tbError.Multiline = true;
			this.tbError.Name = "tbError";
			this.tbError.Size = new System.Drawing.Size(649, 48);
			this.tbError.TabIndex = 1;
			// 
			// lbWho
			// 
			this.lbWho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbWho.AutoSize = true;
			this.lbWho.Location = new System.Drawing.Point(22, 175);
			this.lbWho.Name = "lbWho";
			this.lbWho.Size = new System.Drawing.Size(36, 13);
			this.lbWho.TabIndex = 2;
			this.lbWho.Text = "Who: ";
			// 
			// lbWhat
			// 
			this.lbWhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbWhat.AutoSize = true;
			this.lbWhat.Location = new System.Drawing.Point(22, 216);
			this.lbWhat.Name = "lbWhat";
			this.lbWhat.Size = new System.Drawing.Size(36, 13);
			this.lbWhat.TabIndex = 3;
			this.lbWhat.Text = "What:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Error";
			// 
			// cbRoles
			// 
			this.cbRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbRoles.FormattingEnabled = true;
			this.cbRoles.Location = new System.Drawing.Point(65, 247);
			this.cbRoles.Name = "cbRoles";
			this.cbRoles.Size = new System.Drawing.Size(232, 21);
			this.cbRoles.TabIndex = 5;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAdd.Location = new System.Drawing.Point(430, 245);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 250);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Roles:";
			// 
			// cbDepth
			// 
			this.cbDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cbDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDepth.FormattingEnabled = true;
			this.cbDepth.Location = new System.Drawing.Point(303, 247);
			this.cbDepth.Name = "cbDepth";
			this.cbDepth.Size = new System.Drawing.Size(121, 21);
			this.cbDepth.TabIndex = 8;
			// 
			// lbError
			// 
			this.lbError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbError.AutoSize = true;
			this.lbError.Location = new System.Drawing.Point(22, 117);
			this.lbError.Name = "lbError";
			this.lbError.Size = new System.Drawing.Size(29, 13);
			this.lbError.TabIndex = 9;
			this.lbError.Text = "Error";
			// 
			// CrmPrivilegeCheckerControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lbError);
			this.Controls.Add(this.cbDepth);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.cbRoles);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbWhat);
			this.Controls.Add(this.lbWho);
			this.Controls.Add(this.tbError);
			this.Controls.Add(this.btnCheck);
			this.Name = "CrmPrivilegeCheckerControl";
			this.Size = new System.Drawing.Size(700, 400);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.TextBox tbError;
		private System.Windows.Forms.Label lbWho;
		private System.Windows.Forms.Label lbWhat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbRoles;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbDepth;
		private System.Windows.Forms.Label lbError;
	}
}
