namespace TestTaskProject
{
    partial class FormStaticInfo
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonHired = new System.Windows.Forms.RadioButton();
            this.radioButtonFired = new System.Windows.Forms.RadioButton();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.buttonBackToStartForm = new System.Windows.Forms.Button();
            this.buttonBeginSearch = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.radioButtonHired);
            this.groupBox3.Controls.Add(this.radioButtonFired);
            this.groupBox3.Controls.Add(this.comboBoxStatus);
            this.groupBox3.Controls.Add(this.dateTimePickerEndDate);
            this.groupBox3.Controls.Add(this.dateTimePickerStartDate);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 209);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выберите даты для  просмотра уволеных/нанятых работников";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Конечная дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Начальная дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Status";
            // 
            // radioButtonHired
            // 
            this.radioButtonHired.AutoSize = true;
            this.radioButtonHired.Location = new System.Drawing.Point(180, 167);
            this.radioButtonHired.Name = "radioButtonHired";
            this.radioButtonHired.Size = new System.Drawing.Size(124, 44);
            this.radioButtonHired.TabIndex = 28;
            this.radioButtonHired.TabStop = true;
            this.radioButtonHired.Text = "Нанятых \r\nсотрудников";
            this.radioButtonHired.UseVisualStyleBackColor = true;
            // 
            // radioButtonFired
            // 
            this.radioButtonFired.AutoSize = true;
            this.radioButtonFired.Location = new System.Drawing.Point(21, 167);
            this.radioButtonFired.Name = "radioButtonFired";
            this.radioButtonFired.Size = new System.Drawing.Size(124, 44);
            this.radioButtonFired.TabIndex = 27;
            this.radioButtonFired.Text = "Уволеных \r\nсотрудников";
            this.radioButtonFired.UseVisualStyleBackColor = true;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "On vacation",
            "Working",
            "Retired",
            "Fired"});
            this.comboBoxStatus.Location = new System.Drawing.Point(158, 58);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(159, 28);
            this.comboBoxStatus.TabIndex = 18;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(158, 124);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(159, 26);
            this.dateTimePickerEndDate.TabIndex = 20;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(158, 92);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(159, 26);
            this.dateTimePickerStartDate.TabIndex = 19;
            // 
            // buttonBackToStartForm
            // 
            this.buttonBackToStartForm.Location = new System.Drawing.Point(12, 392);
            this.buttonBackToStartForm.Name = "buttonBackToStartForm";
            this.buttonBackToStartForm.Size = new System.Drawing.Size(140, 46);
            this.buttonBackToStartForm.TabIndex = 24;
            this.buttonBackToStartForm.Text = "Назад к выбору режима";
            this.buttonBackToStartForm.UseVisualStyleBackColor = true;
            this.buttonBackToStartForm.Click += new System.EventHandler(this.ButtonBackToStartForm_Click);
            // 
            // buttonBeginSearch
            // 
            this.buttonBeginSearch.Location = new System.Drawing.Point(756, 354);
            this.buttonBeginSearch.Name = "buttonBeginSearch";
            this.buttonBeginSearch.Size = new System.Drawing.Size(228, 84);
            this.buttonBeginSearch.TabIndex = 25;
            this.buttonBeginSearch.Text = "Начать поиск";
            this.buttonBeginSearch.UseVisualStyleBackColor = true;
            this.buttonBeginSearch.Click += new System.EventHandler(this.ButtonBeginSearch_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(353, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(631, 327);
            this.dataGridView2.TabIndex = 26;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(996, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonBeginSearch);
            this.Controls.Add(this.buttonBackToStartForm);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form2";
            this.Text = "Статическая информация по списку сотрудников";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Button buttonBackToStartForm;
        private System.Windows.Forms.Button buttonBeginSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonHired;
        private System.Windows.Forms.RadioButton radioButtonFired;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}