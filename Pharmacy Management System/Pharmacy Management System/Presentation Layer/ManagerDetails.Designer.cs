
namespace Pharmacy_Management_System.Presentation_Layer
{
    partial class ManagerDetails
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
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteManagerButton = new System.Windows.Forms.Button();
            this.deleteManagerIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addManagerButton = new System.Windows.Forms.Button();
            this.addManagerGenderTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addManagerEmailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addManagerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.managerListDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Silver;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(35, 586);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(96, 27);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.deleteManagerButton);
            this.groupBox3.Controls.Add(this.deleteManagerIdTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(497, 71);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(315, 129);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Manager";
            // 
            // deleteManagerButton
            // 
            this.deleteManagerButton.BackColor = System.Drawing.Color.Silver;
            this.deleteManagerButton.Location = new System.Drawing.Point(132, 64);
            this.deleteManagerButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteManagerButton.Name = "deleteManagerButton";
            this.deleteManagerButton.Size = new System.Drawing.Size(159, 32);
            this.deleteManagerButton.TabIndex = 2;
            this.deleteManagerButton.Text = "Delete";
            this.deleteManagerButton.UseVisualStyleBackColor = false;
            this.deleteManagerButton.Click += new System.EventHandler(this.deleteManagerButton_Click);
            // 
            // deleteManagerIdTextBox
            // 
            this.deleteManagerIdTextBox.Location = new System.Drawing.Point(132, 32);
            this.deleteManagerIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.deleteManagerIdTextBox.Name = "deleteManagerIdTextBox";
            this.deleteManagerIdTextBox.Size = new System.Drawing.Size(157, 22);
            this.deleteManagerIdTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manager Id";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.addManagerButton);
            this.groupBox2.Controls.Add(this.addManagerGenderTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.addManagerEmailTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.addManagerNameTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 39);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(327, 191);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Manager";
            // 
            // addManagerButton
            // 
            this.addManagerButton.BackColor = System.Drawing.Color.Silver;
            this.addManagerButton.Location = new System.Drawing.Point(165, 157);
            this.addManagerButton.Margin = new System.Windows.Forms.Padding(4);
            this.addManagerButton.Name = "addManagerButton";
            this.addManagerButton.Size = new System.Drawing.Size(124, 26);
            this.addManagerButton.TabIndex = 2;
            this.addManagerButton.Text = "Add";
            this.addManagerButton.UseVisualStyleBackColor = false;
            this.addManagerButton.Click += new System.EventHandler(this.addManagerButton_Click);
            // 
            // addManagerGenderTextBox
            // 
            this.addManagerGenderTextBox.Location = new System.Drawing.Point(131, 110);
            this.addManagerGenderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addManagerGenderTextBox.Name = "addManagerGenderTextBox";
            this.addManagerGenderTextBox.Size = new System.Drawing.Size(157, 22);
            this.addManagerGenderTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender";
            // 
            // addManagerEmailTextBox
            // 
            this.addManagerEmailTextBox.Location = new System.Drawing.Point(131, 75);
            this.addManagerEmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addManagerEmailTextBox.Name = "addManagerEmailTextBox";
            this.addManagerEmailTextBox.Size = new System.Drawing.Size(157, 22);
            this.addManagerEmailTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manager Email";
            // 
            // addManagerNameTextBox
            // 
            this.addManagerNameTextBox.Location = new System.Drawing.Point(132, 32);
            this.addManagerNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addManagerNameTextBox.Name = "addManagerNameTextBox";
            this.addManagerNameTextBox.Size = new System.Drawing.Size(157, 22);
            this.addManagerNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.managerListDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 266);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(658, 299);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manager List";
            // 
            // managerListDataGridView
            // 
            this.managerListDataGridView.AllowUserToAddRows = false;
            this.managerListDataGridView.AllowUserToDeleteRows = false;
            this.managerListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managerListDataGridView.Location = new System.Drawing.Point(8, 23);
            this.managerListDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.managerListDataGridView.Name = "managerListDataGridView";
            this.managerListDataGridView.ReadOnly = true;
            this.managerListDataGridView.RowHeadersWidth = 51;
            this.managerListDataGridView.Size = new System.Drawing.Size(642, 268);
            this.managerListDataGridView.TabIndex = 0;
            // 
            // ManagerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(853, 652);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManagerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerDetails_FormClosing);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.managerListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteManagerButton;
        private System.Windows.Forms.TextBox deleteManagerIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addManagerButton;
        private System.Windows.Forms.TextBox addManagerGenderTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addManagerEmailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addManagerNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView managerListDataGridView;
    }
}