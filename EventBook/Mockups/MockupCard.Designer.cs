namespace EventBook.Mockups
{
    partial class MockupCard
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
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblType1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.8F);
            this.lblType.Location = new System.Drawing.Point(39, 19);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(74, 35);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.8F);
            this.lblName.Location = new System.Drawing.Point(39, 124);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 35);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.lblName1.Location = new System.Drawing.Point(74, 168);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(76, 30);
            this.lblName1.TabIndex = 2;
            this.lblName1.Text = "Name";
            // 
            // lblType1
            // 
            this.lblType1.AutoSize = true;
            this.lblType1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.lblType1.Location = new System.Drawing.Point(74, 64);
            this.lblType1.Name = "lblType1";
            this.lblType1.Size = new System.Drawing.Size(76, 30);
            this.lblType1.TabIndex = 3;
            this.lblType1.Text = "Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(79, 225);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 49);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // MockupCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 303);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblType1);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblType);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MockupCard";
            this.Text = "MockupCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblType1;
        private System.Windows.Forms.Button btnDelete;
    }
}