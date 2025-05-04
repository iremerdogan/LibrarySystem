namespace LibrarySystemSolution.PresentationLayer
{
    partial class FrmMemberShip
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMemberAddress = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtMemberAddress = new System.Windows.Forms.TextBox();
            this.txtMemberLastName = new System.Windows.Forms.TextBox();
            this.txtMemberFirstName = new System.Windows.Forms.TextBox();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.txtLimit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMemberAddress
            // 
            this.lblMemberAddress.AutoSize = true;
            this.lblMemberAddress.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblMemberAddress.Location = new System.Drawing.Point(77, 131);
            this.lblMemberAddress.Name = "lblMemberAddress";
            this.lblMemberAddress.Size = new System.Drawing.Size(72, 20);
            this.lblMemberAddress.TabIndex = 122;
            this.lblMemberAddress.Text = "Address:";
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblLimit.Location = new System.Drawing.Point(103, 195);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(46, 20);
            this.lblLimit.TabIndex = 121;
            this.lblLimit.Text = "Limit:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblPhoneNumber.Location = new System.Drawing.Point(30, 163);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(119, 20);
            this.lblPhoneNumber.TabIndex = 119;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblLastName.Location = new System.Drawing.Point(65, 99);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 20);
            this.lblLastName.TabIndex = 116;
            this.lblLastName.Text = "Lastname:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblFirstName.Location = new System.Drawing.Point(65, 67);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 20);
            this.lblFirstName.TabIndex = 115;
            this.lblFirstName.Text = "Firstname:";
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblMemberId.Location = new System.Drawing.Point(60, 35);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(89, 20);
            this.lblMemberId.TabIndex = 114;
            this.lblMemberId.Text = "Member Id:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(155, 160);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(210, 26);
            this.txtPhoneNumber.TabIndex = 113;
            // 
            // txtMemberAddress
            // 
            this.txtMemberAddress.Location = new System.Drawing.Point(155, 128);
            this.txtMemberAddress.Name = "txtMemberAddress";
            this.txtMemberAddress.Size = new System.Drawing.Size(210, 26);
            this.txtMemberAddress.TabIndex = 112;
            // 
            // txtMemberLastName
            // 
            this.txtMemberLastName.Location = new System.Drawing.Point(155, 96);
            this.txtMemberLastName.Name = "txtMemberLastName";
            this.txtMemberLastName.Size = new System.Drawing.Size(210, 26);
            this.txtMemberLastName.TabIndex = 110;
            // 
            // txtMemberFirstName
            // 
            this.txtMemberFirstName.Location = new System.Drawing.Point(155, 64);
            this.txtMemberFirstName.Name = "txtMemberFirstName";
            this.txtMemberFirstName.Size = new System.Drawing.Size(210, 26);
            this.txtMemberFirstName.TabIndex = 108;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(155, 32);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(210, 26);
            this.txtMemberId.TabIndex = 107;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(432, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(647, 390);
            this.dataGridView1.TabIndex = 106;
            // 
            // btnGetById
            // 
            this.btnGetById.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGetById.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnGetById.Location = new System.Drawing.Point(203, 390);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(111, 32);
            this.btnGetById.TabIndex = 104;
            this.btnGetById.Text = "Get By Id";
            this.btnGetById.UseVisualStyleBackColor = false;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnUpdate.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnUpdate.Location = new System.Drawing.Point(203, 356);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 32);
            this.btnUpdate.TabIndex = 103;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRemove.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnRemove.Location = new System.Drawing.Point(203, 322);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(111, 32);
            this.btnRemove.TabIndex = 102;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAdd.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAdd.Location = new System.Drawing.Point(203, 288);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 32);
            this.btnAdd.TabIndex = 101;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnList.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnList.Location = new System.Drawing.Point(203, 254);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(111, 32);
            this.btnList.TabIndex = 105;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(155, 192);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(210, 26);
            this.txtLimit.TabIndex = 113;
            // 
            // FrmMemberShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1119, 456);
            this.Controls.Add(this.lblMemberAddress);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblMemberId);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtMemberAddress);
            this.Controls.Add(this.txtMemberLastName);
            this.Controls.Add(this.txtMemberFirstName);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnList);
            this.Name = "FrmMemberShip";
            this.Text = "Membership Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMemberAddress;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtMemberAddress;
        private System.Windows.Forms.TextBox txtMemberLastName;
        private System.Windows.Forms.TextBox txtMemberFirstName;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtLimit;
    }
}

