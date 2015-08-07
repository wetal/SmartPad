namespace SmartPad
{
    partial class FormEventEditor
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
            this.groupBoxEventContent = new System.Windows.Forms.GroupBox();
            this.groupBoxEventNavigator = new System.Windows.Forms.GroupBox();
            this.labelCurrentIndex = new System.Windows.Forms.Label();
            this.buttonNextEvent = new System.Windows.Forms.Button();
            this.buttonPrevEvent = new System.Windows.Forms.Button();
            this.checkBoxNoViewEndDate = new System.Windows.Forms.CheckBox();
            this.textBoxPlacement = new System.Windows.Forms.TextBox();
            this.labelPlacement = new System.Windows.Forms.Label();
            this.label_5 = new System.Windows.Forms.Label();
            this.label_4 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_0 = new System.Windows.Forms.Label();
            this.buttonSaveAndClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.trackBarImportance = new System.Windows.Forms.TrackBar();
            this.labelImportance = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxEventContent.SuspendLayout();
            this.groupBoxEventNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarImportance)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEventContent
            // 
            this.groupBoxEventContent.Controls.Add(this.groupBoxEventNavigator);
            this.groupBoxEventContent.Controls.Add(this.checkBoxNoViewEndDate);
            this.groupBoxEventContent.Controls.Add(this.textBoxPlacement);
            this.groupBoxEventContent.Controls.Add(this.labelPlacement);
            this.groupBoxEventContent.Controls.Add(this.label_5);
            this.groupBoxEventContent.Controls.Add(this.label_4);
            this.groupBoxEventContent.Controls.Add(this.label_3);
            this.groupBoxEventContent.Controls.Add(this.label_2);
            this.groupBoxEventContent.Controls.Add(this.label_1);
            this.groupBoxEventContent.Controls.Add(this.label_0);
            this.groupBoxEventContent.Controls.Add(this.buttonSaveAndClose);
            this.groupBoxEventContent.Controls.Add(this.buttonSave);
            this.groupBoxEventContent.Controls.Add(this.trackBarImportance);
            this.groupBoxEventContent.Controls.Add(this.labelImportance);
            this.groupBoxEventContent.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxEventContent.Controls.Add(this.labelEndDate);
            this.groupBoxEventContent.Controls.Add(this.labelStartDate);
            this.groupBoxEventContent.Controls.Add(this.dateTimePickerStart);
            this.groupBoxEventContent.Controls.Add(this.labelDescription);
            this.groupBoxEventContent.Controls.Add(this.textBoxDescription);
            this.groupBoxEventContent.Controls.Add(this.textBoxName);
            this.groupBoxEventContent.Controls.Add(this.labelName);
            this.groupBoxEventContent.Location = new System.Drawing.Point(3, 5);
            this.groupBoxEventContent.Name = "groupBoxEventContent";
            this.groupBoxEventContent.Size = new System.Drawing.Size(446, 394);
            this.groupBoxEventContent.TabIndex = 0;
            this.groupBoxEventContent.TabStop = false;
            this.groupBoxEventContent.Text = "Контент события";
            // 
            // groupBoxEventNavigator
            // 
            this.groupBoxEventNavigator.Controls.Add(this.labelCurrentIndex);
            this.groupBoxEventNavigator.Controls.Add(this.buttonNextEvent);
            this.groupBoxEventNavigator.Controls.Add(this.buttonPrevEvent);
            this.groupBoxEventNavigator.Location = new System.Drawing.Point(12, 341);
            this.groupBoxEventNavigator.Name = "groupBoxEventNavigator";
            this.groupBoxEventNavigator.Size = new System.Drawing.Size(201, 44);
            this.groupBoxEventNavigator.TabIndex = 21;
            this.groupBoxEventNavigator.TabStop = false;
            this.groupBoxEventNavigator.Text = "Навигация";
            // 
            // labelCurrentIndex
            // 
            this.labelCurrentIndex.AutoSize = true;
            this.labelCurrentIndex.Location = new System.Drawing.Point(148, 20);
            this.labelCurrentIndex.Name = "labelCurrentIndex";
            this.labelCurrentIndex.Size = new System.Drawing.Size(24, 13);
            this.labelCurrentIndex.TabIndex = 2;
            this.labelCurrentIndex.Text = "0/0";
            // 
            // buttonNextEvent
            // 
            this.buttonNextEvent.Location = new System.Drawing.Point(64, 15);
            this.buttonNextEvent.Name = "buttonNextEvent";
            this.buttonNextEvent.Size = new System.Drawing.Size(47, 23);
            this.buttonNextEvent.TabIndex = 1;
            this.buttonNextEvent.Text = ">>";
            this.buttonNextEvent.UseVisualStyleBackColor = true;
            this.buttonNextEvent.Click += new System.EventHandler(this.buttonNextEvent_Click);
            // 
            // buttonPrevEvent
            // 
            this.buttonPrevEvent.Location = new System.Drawing.Point(11, 15);
            this.buttonPrevEvent.Name = "buttonPrevEvent";
            this.buttonPrevEvent.Size = new System.Drawing.Size(47, 23);
            this.buttonPrevEvent.TabIndex = 0;
            this.buttonPrevEvent.Text = "<<";
            this.buttonPrevEvent.UseVisualStyleBackColor = true;
            this.buttonPrevEvent.Click += new System.EventHandler(this.buttonPrevEvent_Click);
            // 
            // checkBoxNoViewEndDate
            // 
            this.checkBoxNoViewEndDate.AutoSize = true;
            this.checkBoxNoViewEndDate.Location = new System.Drawing.Point(281, 137);
            this.checkBoxNoViewEndDate.Name = "checkBoxNoViewEndDate";
            this.checkBoxNoViewEndDate.Size = new System.Drawing.Size(101, 17);
            this.checkBoxNoViewEndDate.TabIndex = 20;
            this.checkBoxNoViewEndDate.Text = "не отображать";
            this.checkBoxNoViewEndDate.UseVisualStyleBackColor = true;
            this.checkBoxNoViewEndDate.CheckedChanged += new System.EventHandler(this.checkBoxNoViewEndDate_CheckedChanged);
            // 
            // textBoxPlacement
            // 
            this.textBoxPlacement.Location = new System.Drawing.Point(121, 65);
            this.textBoxPlacement.Name = "textBoxPlacement";
            this.textBoxPlacement.Size = new System.Drawing.Size(311, 20);
            this.textBoxPlacement.TabIndex = 19;
            // 
            // labelPlacement
            // 
            this.labelPlacement.AutoSize = true;
            this.labelPlacement.Location = new System.Drawing.Point(9, 68);
            this.labelPlacement.Name = "labelPlacement";
            this.labelPlacement.Size = new System.Drawing.Size(99, 13);
            this.labelPlacement.TabIndex = 18;
            this.labelPlacement.Text = "Местоположение*";
            // 
            // label_5
            // 
            this.label_5.AutoSize = true;
            this.label_5.Location = new System.Drawing.Point(318, 202);
            this.label_5.Name = "label_5";
            this.label_5.Size = new System.Drawing.Size(13, 13);
            this.label_5.TabIndex = 17;
            this.label_5.Text = "5";
            // 
            // label_4
            // 
            this.label_4.AutoSize = true;
            this.label_4.Location = new System.Drawing.Point(278, 202);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(13, 13);
            this.label_4.TabIndex = 16;
            this.label_4.Text = "4";
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Location = new System.Drawing.Point(239, 202);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(13, 13);
            this.label_3.TabIndex = 15;
            this.label_3.Text = "3";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Location = new System.Drawing.Point(200, 202);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(13, 13);
            this.label_2.TabIndex = 14;
            this.label_2.Text = "2";
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(160, 202);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(13, 13);
            this.label_1.TabIndex = 13;
            this.label_1.Text = "1";
            // 
            // label_0
            // 
            this.label_0.AutoSize = true;
            this.label_0.Location = new System.Drawing.Point(123, 202);
            this.label_0.Name = "label_0";
            this.label_0.Size = new System.Drawing.Size(13, 13);
            this.label_0.TabIndex = 12;
            this.label_0.Text = "0";
            // 
            // buttonSaveAndClose
            // 
            this.buttonSaveAndClose.Location = new System.Drawing.Point(351, 343);
            this.buttonSaveAndClose.Name = "buttonSaveAndClose";
            this.buttonSaveAndClose.Size = new System.Drawing.Size(81, 42);
            this.buttonSaveAndClose.TabIndex = 11;
            this.buttonSaveAndClose.Text = "Закрыть";
            this.buttonSaveAndClose.UseVisualStyleBackColor = true;
            this.buttonSaveAndClose.Click += new System.EventHandler(this.buttonSaveAndClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(253, 343);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 42);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // trackBarImportance
            // 
            this.trackBarImportance.LargeChange = 1;
            this.trackBarImportance.Location = new System.Drawing.Point(115, 174);
            this.trackBarImportance.Maximum = 5;
            this.trackBarImportance.Name = "trackBarImportance";
            this.trackBarImportance.Size = new System.Drawing.Size(222, 45);
            this.trackBarImportance.TabIndex = 9;
            // 
            // labelImportance
            // 
            this.labelImportance.AutoSize = true;
            this.labelImportance.Location = new System.Drawing.Point(9, 184);
            this.labelImportance.Name = "labelImportance";
            this.labelImportance.Size = new System.Drawing.Size(101, 13);
            this.labelImportance.TabIndex = 8;
            this.labelImportance.Text = "Степень важности";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(121, 135);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(145, 20);
            this.dateTimePickerEnd.TabIndex = 7;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(9, 138);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(89, 13);
            this.labelEndDate.TabIndex = 6;
            this.labelEndDate.Text = "Дата окончания";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(9, 103);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(75, 13);
            this.labelStartDate.TabIndex = 5;
            this.labelStartDate.Text = "Дата начала*";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(121, 100);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(145, 20);
            this.dateTimePickerStart.TabIndex = 4;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(9, 270);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(103, 13);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Описание события";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(121, 230);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(310, 105);
            this.textBoxDescription.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(121, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(311, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(61, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название*";
            // 
            // FormEventEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 400);
            this.Controls.Add(this.groupBoxEventContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEventEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор событий";
            this.groupBoxEventContent.ResumeLayout(false);
            this.groupBoxEventContent.PerformLayout();
            this.groupBoxEventNavigator.ResumeLayout(false);
            this.groupBoxEventNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarImportance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEventContent;
        private System.Windows.Forms.Button buttonSaveAndClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TrackBar trackBarImportance;
        private System.Windows.Forms.Label labelImportance;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label_5;
        private System.Windows.Forms.Label label_4;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label_0;
        private System.Windows.Forms.CheckBox checkBoxNoViewEndDate;
        private System.Windows.Forms.TextBox textBoxPlacement;
        private System.Windows.Forms.Label labelPlacement;
        private System.Windows.Forms.GroupBox groupBoxEventNavigator;
        private System.Windows.Forms.Label labelCurrentIndex;
        private System.Windows.Forms.Button buttonNextEvent;
        private System.Windows.Forms.Button buttonPrevEvent;
    }
}