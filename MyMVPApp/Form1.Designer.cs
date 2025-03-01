namespace MyMVPApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.usersData = new System.Windows.Forms.DataGridView();
            this.filterButton = new System.Windows.Forms.Button();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.clearFilterButton = new System.Windows.Forms.Button();
            this.userFilterFields = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userCard1 = new UserCard.UserCard();
            ((System.ComponentModel.ISupportInitialize)(this.usersData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersData
            // 
            this.usersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersData.Location = new System.Drawing.Point(0, 0);
            this.usersData.Name = "usersData";
            this.usersData.Size = new System.Drawing.Size(1108, 255);
            this.usersData.TabIndex = 0;
            this.usersData.SelectionChanged += new System.EventHandler(this.usersData_SelectionChanged);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(135, 36);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(214, 23);
            this.filterButton.TabIndex = 1;
            this.filterButton.Text = "Фильтровать";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(139, 12);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(210, 20);
            this.filterTextBox.TabIndex = 2;
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.Location = new System.Drawing.Point(12, 36);
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.Size = new System.Drawing.Size(117, 23);
            this.clearFilterButton.TabIndex = 3;
            this.clearFilterButton.Text = "Очистить фильтр";
            this.clearFilterButton.UseVisualStyleBackColor = true;
            this.clearFilterButton.Click += new System.EventHandler(this.clearFilterButton_Click);
            // 
            // userFilterFields
            // 
            this.userFilterFields.FormattingEnabled = true;
            this.userFilterFields.Location = new System.Drawing.Point(12, 12);
            this.userFilterFields.Name = "userFilterFields";
            this.userFilterFields.Size = new System.Drawing.Size(121, 21);
            this.userFilterFields.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userFilterFields);
            this.panel1.Controls.Add(this.filterButton);
            this.panel1.Controls.Add(this.clearFilterButton);
            this.panel1.Controls.Add(this.filterTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 69);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userCard1);
            this.panel2.Controls.Add(this.usersData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 546);
            this.panel2.TabIndex = 6;
            // 
            // userCard1
            // 
            this.userCard1.Location = new System.Drawing.Point(192, 261);
            this.userCard1.Name = "userCard1";
            this.userCard1.Size = new System.Drawing.Size(589, 273);
            this.userCard1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.usersData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersData;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Button clearFilterButton;
        private System.Windows.Forms.ComboBox userFilterFields;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private UserCard.UserCard userCard1;
    }
}

