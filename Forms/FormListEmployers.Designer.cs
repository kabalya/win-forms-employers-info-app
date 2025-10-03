namespace TestTaskProject
{
    partial class FormListEmployers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonBeginSearch = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.textBoxPartName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDoNotSort = new System.Windows.Forms.RadioButton();
            this.radioButtonDateOfEmploy = new System.Windows.Forms.RadioButton();
            this.radioButtonDateOfEnemploy = new System.Windows.Forms.RadioButton();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonDepartment = new System.Windows.Forms.RadioButton();
            this.radioButtonPost = new System.Windows.Forms.RadioButton();
            this.radioButtonStatus = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonASC = new System.Windows.Forms.RadioButton();
            this.radioButtonDESC = new System.Windows.Forms.RadioButton();
            this.buttonBackToStartForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(353, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(631, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonBeginSearch
            // 
            this.buttonBeginSearch.Location = new System.Drawing.Point(756, 354);
            this.buttonBeginSearch.Name = "buttonBeginSearch";
            this.buttonBeginSearch.Size = new System.Drawing.Size(228, 84);
            this.buttonBeginSearch.TabIndex = 1;
            this.buttonBeginSearch.Text = "Начать поиск";
            this.buttonBeginSearch.UseVisualStyleBackColor = true;
            this.buttonBeginSearch.Click += new System.EventHandler(this.ButtonBeginSearch_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(156, 9);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(174, 29);
            this.textBoxStatus.TabIndex = 3;
            this.textBoxStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDepartment.Location = new System.Drawing.Point(156, 64);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(174, 29);
            this.textBoxDepartment.TabIndex = 4;
            this.textBoxDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPost.Location = new System.Drawing.Point(156, 122);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(174, 29);
            this.textBoxPost.TabIndex = 5;
            this.textBoxPost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPartName
            // 
            this.textBoxPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPartName.Location = new System.Drawing.Point(156, 179);
            this.textBoxPartName.Name = "textBoxPartName";
            this.textBoxPartName.Size = new System.Drawing.Size(174, 29);
            this.textBoxPartName.TabIndex = 6;
            this.textBoxPartName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Post";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Part of last name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.radioButtonDoNotSort);
            this.groupBox1.Controls.Add(this.radioButtonDateOfEmploy);
            this.groupBox1.Controls.Add(this.radioButtonDateOfEnemploy);
            this.groupBox1.Controls.Add(this.radioButtonName);
            this.groupBox1.Controls.Add(this.radioButtonDepartment);
            this.groupBox1.Controls.Add(this.radioButtonPost);
            this.groupBox1.Controls.Add(this.radioButtonStatus);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Location = new System.Drawing.Point(226, 354);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(336, 91);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите по какому елементу будет проведена сортировка";
            // 
            // radioButtonDoNotSort
            // 
            this.radioButtonDoNotSort.AutoSize = true;
            this.radioButtonDoNotSort.Location = new System.Drawing.Point(230, 45);
            this.radioButtonDoNotSort.Name = "radioButtonDoNotSort";
            this.radioButtonDoNotSort.Size = new System.Drawing.Size(106, 17);
            this.radioButtonDoNotSort.TabIndex = 6;
            this.radioButtonDoNotSort.TabStop = true;
            this.radioButtonDoNotSort.Text = "Не сортировать";
            this.radioButtonDoNotSort.UseVisualStyleBackColor = true;
            // 
            // radioButtonDateOfEmploy
            // 
            this.radioButtonDateOfEmploy.AutoSize = true;
            this.radioButtonDateOfEmploy.Location = new System.Drawing.Point(127, 69);
            this.radioButtonDateOfEmploy.Name = "radioButtonDateOfEmploy";
            this.radioButtonDateOfEmploy.Size = new System.Drawing.Size(108, 17);
            this.radioButtonDateOfEmploy.TabIndex = 5;
            this.radioButtonDateOfEmploy.TabStop = true;
            this.radioButtonDateOfEmploy.Text = "Date of unemploy";
            this.radioButtonDateOfEmploy.UseVisualStyleBackColor = true;
            // 
            // radioButtonDateOfEnemploy
            // 
            this.radioButtonDateOfEnemploy.AutoSize = true;
            this.radioButtonDateOfEnemploy.Location = new System.Drawing.Point(127, 46);
            this.radioButtonDateOfEnemploy.Name = "radioButtonDateOfEnemploy";
            this.radioButtonDateOfEnemploy.Size = new System.Drawing.Size(96, 17);
            this.radioButtonDateOfEnemploy.TabIndex = 4;
            this.radioButtonDateOfEnemploy.TabStop = true;
            this.radioButtonDateOfEnemploy.Text = "Date of employ";
            this.radioButtonDateOfEnemploy.UseVisualStyleBackColor = true;
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(127, 22);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(53, 17);
            this.radioButtonName.TabIndex = 3;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "Name";
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // radioButtonDepartment
            // 
            this.radioButtonDepartment.AutoSize = true;
            this.radioButtonDepartment.Location = new System.Drawing.Point(9, 46);
            this.radioButtonDepartment.Name = "radioButtonDepartment";
            this.radioButtonDepartment.Size = new System.Drawing.Size(80, 17);
            this.radioButtonDepartment.TabIndex = 2;
            this.radioButtonDepartment.TabStop = true;
            this.radioButtonDepartment.Text = "Department";
            this.radioButtonDepartment.UseVisualStyleBackColor = true;
            // 
            // radioButtonPost
            // 
            this.radioButtonPost.AutoSize = true;
            this.radioButtonPost.Location = new System.Drawing.Point(9, 69);
            this.radioButtonPost.Name = "radioButtonPost";
            this.radioButtonPost.Size = new System.Drawing.Size(46, 17);
            this.radioButtonPost.TabIndex = 1;
            this.radioButtonPost.TabStop = true;
            this.radioButtonPost.Text = "Post";
            this.radioButtonPost.UseVisualStyleBackColor = true;
            // 
            // radioButtonStatus
            // 
            this.radioButtonStatus.AutoSize = true;
            this.radioButtonStatus.Location = new System.Drawing.Point(9, 22);
            this.radioButtonStatus.Name = "radioButtonStatus";
            this.radioButtonStatus.Size = new System.Drawing.Size(55, 17);
            this.radioButtonStatus.TabIndex = 0;
            this.radioButtonStatus.TabStop = true;
            this.radioButtonStatus.Text = "Status";
            this.radioButtonStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonStatus.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonASC);
            this.groupBox2.Controls.Add(this.radioButtonDESC);
            this.groupBox2.Location = new System.Drawing.Point(615, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 77);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите вариант сортировки";
            // 
            // radioButtonASC
            // 
            this.radioButtonASC.AutoSize = true;
            this.radioButtonASC.Location = new System.Drawing.Point(6, 54);
            this.radioButtonASC.Name = "radioButtonASC";
            this.radioButtonASC.Size = new System.Drawing.Size(109, 17);
            this.radioButtonASC.TabIndex = 1;
            this.radioButtonASC.TabStop = true;
            this.radioButtonASC.Text = "По возрастанию";
            this.radioButtonASC.UseVisualStyleBackColor = true;
            // 
            // radioButtonDESC
            // 
            this.radioButtonDESC.AutoSize = true;
            this.radioButtonDESC.Location = new System.Drawing.Point(6, 31);
            this.radioButtonDESC.Name = "radioButtonDESC";
            this.radioButtonDESC.Size = new System.Drawing.Size(93, 17);
            this.radioButtonDESC.TabIndex = 0;
            this.radioButtonDESC.TabStop = true;
            this.radioButtonDESC.Text = "По убыванию";
            this.radioButtonDESC.UseVisualStyleBackColor = true;
            // 
            // buttonBackToStartForm
            // 
            this.buttonBackToStartForm.Location = new System.Drawing.Point(12, 392);
            this.buttonBackToStartForm.Name = "buttonBackToStartForm";
            this.buttonBackToStartForm.Size = new System.Drawing.Size(140, 46);
            this.buttonBackToStartForm.TabIndex = 25;
            this.buttonBackToStartForm.Text = "Назад к выбору режима";
            this.buttonBackToStartForm.UseVisualStyleBackColor = true;
            this.buttonBackToStartForm.Click += new System.EventHandler(this.ButtonBackToStartForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(996, 450);
            this.Controls.Add(this.buttonBackToStartForm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPartName);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonBeginSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Список сотрудников";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonBeginSearch;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.TextBox textBoxPartName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDepartment;
        private System.Windows.Forms.RadioButton radioButtonPost;
        private System.Windows.Forms.RadioButton radioButtonStatus;
        private System.Windows.Forms.RadioButton radioButtonDateOfEmploy;
        private System.Windows.Forms.RadioButton radioButtonDateOfEnemploy;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonDoNotSort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonASC;
        private System.Windows.Forms.RadioButton radioButtonDESC;
        private System.Windows.Forms.Button buttonBackToStartForm;
    }
}

