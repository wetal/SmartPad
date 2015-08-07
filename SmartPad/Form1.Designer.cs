namespace SmartPad
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.groupBoxFilterMenu = new System.Windows.Forms.GroupBox();
            this.groupBoxEventMenu = new System.Windows.Forms.GroupBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCreateEvent = new System.Windows.Forms.Button();
            this.groupBoxView = new System.Windows.Forms.GroupBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxEventDescription = new System.Windows.Forms.TextBox();
            this.checkedListBoxEventsHeaders = new System.Windows.Forms.CheckedListBox();
            this.groupBoxMenu.SuspendLayout();
            this.groupBoxEventMenu.SuspendLayout();
            this.groupBoxView.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMenu.Controls.Add(this.groupBoxFilterMenu);
            this.groupBoxMenu.Controls.Add(this.groupBoxEventMenu);
            this.groupBoxMenu.Location = new System.Drawing.Point(1, 0);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(513, 83);
            this.groupBoxMenu.TabIndex = 0;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Меню";
            // 
            // groupBoxFilterMenu
            // 
            this.groupBoxFilterMenu.Location = new System.Drawing.Point(216, 15);
            this.groupBoxFilterMenu.Name = "groupBoxFilterMenu";
            this.groupBoxFilterMenu.Size = new System.Drawing.Size(104, 62);
            this.groupBoxFilterMenu.TabIndex = 3;
            this.groupBoxFilterMenu.TabStop = false;
            this.groupBoxFilterMenu.Text = "Фильтр";
            // 
            // groupBoxEventMenu
            // 
            this.groupBoxEventMenu.Controls.Add(this.buttonEdit);
            this.groupBoxEventMenu.Controls.Add(this.buttonDelete);
            this.groupBoxEventMenu.Controls.Add(this.buttonCreateEvent);
            this.groupBoxEventMenu.Location = new System.Drawing.Point(5, 15);
            this.groupBoxEventMenu.Name = "groupBoxEventMenu";
            this.groupBoxEventMenu.Size = new System.Drawing.Size(206, 62);
            this.groupBoxEventMenu.TabIndex = 2;
            this.groupBoxEventMenu.TabStop = false;
            this.groupBoxEventMenu.Text = "События";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(72, 19);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(60, 37);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(138, 19);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(60, 37);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCreateEvent
            // 
            this.buttonCreateEvent.Location = new System.Drawing.Point(6, 19);
            this.buttonCreateEvent.Name = "buttonCreateEvent";
            this.buttonCreateEvent.Size = new System.Drawing.Size(60, 37);
            this.buttonCreateEvent.TabIndex = 0;
            this.buttonCreateEvent.Text = "Создать";
            this.buttonCreateEvent.UseVisualStyleBackColor = true;
            this.buttonCreateEvent.Click += new System.EventHandler(this.buttonCreateEvent_Click);
            // 
            // groupBoxView
            // 
            this.groupBoxView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxView.Controls.Add(this.textBoxLog);
            this.groupBoxView.Controls.Add(this.textBoxEventDescription);
            this.groupBoxView.Controls.Add(this.checkedListBoxEventsHeaders);
            this.groupBoxView.Location = new System.Drawing.Point(1, 83);
            this.groupBoxView.Name = "groupBoxView";
            this.groupBoxView.Size = new System.Drawing.Size(513, 237);
            this.groupBoxView.TabIndex = 1;
            this.groupBoxView.TabStop = false;
            this.groupBoxView.Text = "Просмотр событий";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.Location = new System.Drawing.Point(5, 194);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(502, 37);
            this.textBoxLog.TabIndex = 2;
            this.textBoxLog.TextChanged += new System.EventHandler(this.textBoxLog_TextChanged);
            // 
            // textBoxEventDescription
            // 
            this.textBoxEventDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEventDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxEventDescription.Location = new System.Drawing.Point(169, 19);
            this.textBoxEventDescription.Multiline = true;
            this.textBoxEventDescription.Name = "textBoxEventDescription";
            this.textBoxEventDescription.ReadOnly = true;
            this.textBoxEventDescription.Size = new System.Drawing.Size(338, 169);
            this.textBoxEventDescription.TabIndex = 1;
            // 
            // checkedListBoxEventsHeaders
            // 
            this.checkedListBoxEventsHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBoxEventsHeaders.FormattingEnabled = true;
            this.checkedListBoxEventsHeaders.Location = new System.Drawing.Point(5, 19);
            this.checkedListBoxEventsHeaders.Name = "checkedListBoxEventsHeaders";
            this.checkedListBoxEventsHeaders.Size = new System.Drawing.Size(158, 169);
            this.checkedListBoxEventsHeaders.TabIndex = 0;
            this.checkedListBoxEventsHeaders.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxEventsHeaders_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 321);
            this.Controls.Add(this.groupBoxView);
            this.Controls.Add(this.groupBoxMenu);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartPad";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxEventMenu.ResumeLayout(false);
            this.groupBoxView.ResumeLayout(false);
            this.groupBoxView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Button buttonCreateEvent;
        private System.Windows.Forms.GroupBox groupBoxView;
        private System.Windows.Forms.CheckedListBox checkedListBoxEventsHeaders;
        private System.Windows.Forms.TextBox textBoxEventDescription;
        private System.Windows.Forms.GroupBox groupBoxFilterMenu;
        private System.Windows.Forms.GroupBox groupBoxEventMenu;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;

    }
}

