namespace WorldTime
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePickerSource = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTimeZoneSource = new System.Windows.Forms.ComboBox();
            this.comboBoxTimeZoneTarget = new System.Windows.Forms.ComboBox();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePickerSource
            // 
            this.dateTimePickerSource.Location = new System.Drawing.Point(12, 12);
            this.dateTimePickerSource.Name = "dateTimePickerSource";
            this.dateTimePickerSource.Size = new System.Drawing.Size(160, 23);
            this.dateTimePickerSource.TabIndex = 0;
            // 
            // comboBoxTimeZoneSource
            // 
            this.comboBoxTimeZoneSource.FormattingEnabled = true;
            this.comboBoxTimeZoneSource.Location = new System.Drawing.Point(178, 12);
            this.comboBoxTimeZoneSource.Name = "comboBoxTimeZoneSource";
            this.comboBoxTimeZoneSource.Size = new System.Drawing.Size(390, 25);
            this.comboBoxTimeZoneSource.TabIndex = 2;
            // 
            // comboBoxTimeZoneTarget
            // 
            this.comboBoxTimeZoneTarget.FormattingEnabled = true;
            this.comboBoxTimeZoneTarget.Location = new System.Drawing.Point(178, 41);
            this.comboBoxTimeZoneTarget.Name = "comboBoxTimeZoneTarget";
            this.comboBoxTimeZoneTarget.Size = new System.Drawing.Size(390, 25);
            this.comboBoxTimeZoneTarget.TabIndex = 3;
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTarget.Location = new System.Drawing.Point(12, 43);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.ReadOnly = true;
            this.textBoxTarget.Size = new System.Drawing.Size(160, 23);
            this.textBoxTarget.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 81);
            this.Controls.Add(this.textBoxTarget);
            this.Controls.Add(this.comboBoxTimeZoneTarget);
            this.Controls.Add(this.comboBoxTimeZoneSource);
            this.Controls.Add(this.dateTimePickerSource);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorldTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerSource;
        private System.Windows.Forms.ComboBox comboBoxTimeZoneSource;
        private System.Windows.Forms.ComboBox comboBoxTimeZoneTarget;
        private System.Windows.Forms.TextBox textBoxTarget;
    }
}

