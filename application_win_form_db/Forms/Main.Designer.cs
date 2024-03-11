﻿namespace application_win_form_db
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
			btn_anlytc = new Button();
			btn_scient = new Button();
			btn_read_db = new Button();
			btn_crud_db = new Button();
			lbl_role1 = new Label();
			lbl_role2 = new Label();
			listBox_notes = new ListBox();
			lbl_notes = new Label();
			SuspendLayout();
			// 
			// btn_anlytc
			// 
			btn_anlytc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btn_anlytc.Location = new Point(26, 69);
			btn_anlytc.Margin = new Padding(3, 2, 3, 2);
			btn_anlytc.Name = "btn_anlytc";
			btn_anlytc.Size = new Size(175, 56);
			btn_anlytc.TabIndex = 0;
			btn_anlytc.Text = "Analytics Page";
			btn_anlytc.UseVisualStyleBackColor = true;
			// 
			// btn_scient
			// 
			btn_scient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btn_scient.Location = new Point(26, 144);
			btn_scient.Margin = new Padding(3, 2, 3, 2);
			btn_scient.Name = "btn_scient";
			btn_scient.Size = new Size(175, 56);
			btn_scient.TabIndex = 4;
			btn_scient.Text = "Scientist Page";
			btn_scient.UseVisualStyleBackColor = true;
			// 
			// btn_read_db
			// 
			btn_read_db.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btn_read_db.Location = new Point(26, 219);
			btn_read_db.Margin = new Padding(3, 2, 3, 2);
			btn_read_db.Name = "btn_read_db";
			btn_read_db.Size = new Size(175, 56);
			btn_read_db.TabIndex = 5;
			btn_read_db.Text = "Read-db Page";
			btn_read_db.UseVisualStyleBackColor = true;
			// 
			// btn_crud_db
			// 
			btn_crud_db.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btn_crud_db.Location = new Point(26, 294);
			btn_crud_db.Margin = new Padding(3, 2, 3, 2);
			btn_crud_db.Name = "btn_crud_db";
			btn_crud_db.Size = new Size(175, 56);
			btn_crud_db.TabIndex = 6;
			btn_crud_db.Text = "CRUD-db Page";
			btn_crud_db.UseVisualStyleBackColor = true;
			// 
			// lbl_role1
			// 
			lbl_role1.AutoSize = true;
			lbl_role1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_role1.Location = new Point(26, 9);
			lbl_role1.Name = "lbl_role1";
			lbl_role1.Size = new Size(113, 25);
			lbl_role1.TabIndex = 7;
			lbl_role1.Text = "Your Role is:";
			// 
			// lbl_role2
			// 
			lbl_role2.AutoSize = true;
			lbl_role2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_role2.Location = new Point(155, 9);
			lbl_role2.Name = "lbl_role2";
			lbl_role2.Size = new Size(57, 25);
			lbl_role2.TabIndex = 8;
			lbl_role2.Text = "xxxxx";
			// 
			// listBox_notes
			// 
			listBox_notes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			listBox_notes.FormattingEnabled = true;
			listBox_notes.ItemHeight = 21;
			listBox_notes.Location = new Point(222, 69);
			listBox_notes.Margin = new Padding(3, 2, 3, 2);
			listBox_notes.Name = "listBox_notes";
			listBox_notes.Size = new Size(874, 508);
			listBox_notes.TabIndex = 9;
			// 
			// lbl_notes
			// 
			lbl_notes.AutoSize = true;
			lbl_notes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_notes.Location = new Point(978, 35);
			lbl_notes.Name = "lbl_notes";
			lbl_notes.Size = new Size(118, 21);
			lbl_notes.TabIndex = 10;
			lbl_notes.Text = "Your own notes";
			// 
			// Main
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1108, 598);
			Controls.Add(lbl_notes);
			Controls.Add(listBox_notes);
			Controls.Add(lbl_role2);
			Controls.Add(lbl_role1);
			Controls.Add(btn_crud_db);
			Controls.Add(btn_read_db);
			Controls.Add(btn_scient);
			Controls.Add(btn_anlytc);
			Margin = new Padding(3, 2, 3, 2);
			Name = "Main";
			Text = "Main";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn_anlytc;
        private Button btn_scient;
        private Button btn_read_db;
        private Button btn_crud_db;
        private Label lbl_role1;
        private Label lbl_role2;
        private ListBox listBox_notes;
        private Label lbl_notes;
    }
}