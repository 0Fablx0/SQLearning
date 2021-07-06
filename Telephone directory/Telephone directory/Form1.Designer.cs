
namespace Telephone_directory
{
    partial class Form1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Refresh_table_button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Search_field = new System.Windows.Forms.ComboBox();
            this.Search_word = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Phone_number = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.TextBox();
            this.Save_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(618, 433);
            this.dataGridView.TabIndex = 0;
            // 
            // Refresh_table_button
            // 
            this.Refresh_table_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Refresh_table_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Refresh_table_button.Location = new System.Drawing.Point(477, 451);
            this.Refresh_table_button.Name = "Refresh_table_button";
            this.Refresh_table_button.Size = new System.Drawing.Size(153, 68);
            this.Refresh_table_button.TabIndex = 1;
            this.Refresh_table_button.Text = "Resfresh table";
            this.Refresh_table_button.UseVisualStyleBackColor = false;
            this.Refresh_table_button.Click += new System.EventHandler(this.Refresh_table_button_Click);
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Search_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Search_button.Location = new System.Drawing.Point(477, 541);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(153, 68);
            this.Search_button.TabIndex = 2;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = false;
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Add_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.Add_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add_button.Location = new System.Drawing.Point(477, 615);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(153, 68);
            this.Add_button.TabIndex = 3;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = false;
            // 
            // Search_field
            // 
            this.Search_field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Search_field.FormattingEnabled = true;
            this.Search_field.Items.AddRange(new object[] {
            "Name",
            "Phone",
            "Mail"});
            this.Search_field.Location = new System.Drawing.Point(323, 568);
            this.Search_field.Name = "Search_field";
            this.Search_field.Size = new System.Drawing.Size(121, 23);
            this.Search_field.TabIndex = 4;
            // 
            // Search_word
            // 
            this.Search_word.BackColor = System.Drawing.Color.DarkGray;
            this.Search_word.Location = new System.Drawing.Point(12, 568);
            this.Search_word.Name = "Search_word";
            this.Search_word.Size = new System.Drawing.Size(243, 23);
            this.Search_word.TabIndex = 5;
            // 
            // Name
            // 
            this.Name.BackColor = System.Drawing.Color.DarkGray;
            this.Name.Location = new System.Drawing.Point(12, 642);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(141, 23);
            this.Name.TabIndex = 6;
            // 
            // Phone_number
            // 
            this.Phone_number.BackColor = System.Drawing.Color.DarkGray;
            this.Phone_number.Location = new System.Drawing.Point(159, 642);
            this.Phone_number.Name = "Phone_number";
            this.Phone_number.Size = new System.Drawing.Size(158, 23);
            this.Phone_number.TabIndex = 7;
            // 
            // Mail
            // 
            this.Mail.BackColor = System.Drawing.Color.DarkGray;
            this.Mail.Location = new System.Drawing.Point(323, 642);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(148, 23);
            this.Mail.TabIndex = 8;
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Save_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save_button.Location = new System.Drawing.Point(12, 451);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(243, 68);
            this.Save_button.TabIndex = 9;
            this.Save_button.Text = "Save table";
            this.Save_button.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(642, 695);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Phone_number);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Search_word);
            this.Controls.Add(this.Search_field);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Refresh_table_button);
            this.Controls.Add(this.dataGridView);
            this.Text = "Refresh table";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Refresh_table_button;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.ComboBox Search_field;
        private System.Windows.Forms.TextBox Search_word;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Phone_number;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Button Save_button;
    }
}

