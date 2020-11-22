using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldTime
{
    public partial class Form1 : Form
    {
        ReadOnlyCollection<TimeZoneInfo> timeZoneInfos = TimeZoneInfo.GetSystemTimeZones();
        string[] timeZoneInfoTexts = null;

        public Form1()
        {
            InitializeComponent();

            dateTimePickerSource.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePickerSource.Format = DateTimePickerFormat.Custom;
            //dateTimePickerTarget.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            //dateTimePickerTarget.Format = DateTimePickerFormat.Custom;

            timeZoneInfoTexts = new string[timeZoneInfos.Count()];
            for (int i = 0; i < timeZoneInfos.Count(); i++)
            {
                timeZoneInfoTexts[i] = timeZoneInfos[i].DisplayName;
            }
            comboBoxTimeZoneSource.Items.AddRange(timeZoneInfoTexts);
            comboBoxTimeZoneTarget.Items.AddRange(timeZoneInfoTexts);

            comboBoxTimeZoneSource.SelectedIndex = timeZoneInfos.IndexOf(TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));
            comboBoxTimeZoneTarget.SelectedIndex = timeZoneInfos.IndexOf(TimeZoneInfo.FindSystemTimeZoneById("China Standard Time"));

            DateTime utcDtNow = DateTime.UtcNow;
            dateTimePickerSource.Value = TimeZoneInfo.ConvertTimeFromUtc(utcDtNow, timeZoneInfos[comboBoxTimeZoneSource.SelectedIndex]);

            RefreshTimeText();

            this.dateTimePickerSource.ValueChanged += new System.EventHandler(this.dateTimePickerSource_ValueChanged);
            this.comboBoxTimeZoneSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeZoneSource_SelectedIndexChanged);
            this.comboBoxTimeZoneTarget.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeZoneTarget_SelectedIndexChanged);
        }

        private void dateTimePickerSource_ValueChanged(object sender, EventArgs e)
        {
            RefreshTimeText();
        }

        private void comboBoxTimeZoneSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTimeText();
        }

        private void comboBoxTimeZoneTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTimeText();
        }

        void RefreshTimeText()
        {
            textBoxTarget.Text = TimeZoneInfo.ConvertTime(dateTimePickerSource.Value, timeZoneInfos[comboBoxTimeZoneSource.SelectedIndex], timeZoneInfos[comboBoxTimeZoneTarget.SelectedIndex]).ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
