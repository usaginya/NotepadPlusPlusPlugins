using System;
using System.Windows.Forms;
using static TransparentWindow.TransparentWindowConfig;

namespace TransparentWindow.Forms
{
    public partial class TransparentWindowSettings : Form
    {
        private Options originalOptions, settingsOptions;

        public TransparentWindowSettings()
        {
            InitializeComponent();

            settingsOptions = originalOptions = TransparentWindow.Options;

            //Temporarily enabled at settings
            settingsOptions.isEnable = true;
            TransparentWindow.Options = settingsOptions;
            TransparentWindow.SetWindowOpacity(settingsOptions.Opacity);

            //Set control values
            trackBarTransparency.Value = originalOptions.Opacity;
            labelTransparency.Text = originalOptions.Opacity.ToString();
        }

        /// <summary>
        /// Change window opacity
        /// </summary>
        private void TrackBarTransparency_Scroll(object sender, EventArgs e)
        {
            settingsOptions.Opacity = trackBarTransparency.Value;
            labelTransparency.Text = settingsOptions.Opacity.ToString();
            TransparentWindow.SetWindowOpacity(settingsOptions.Opacity);
        }

        /// <summary>
        /// Confirm settings
        /// </summary>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            buttonOK.Tag = 1;
            Close();
        }

        /// <summary>
        /// Cancel settings
        /// </summary>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Form Closing
        /// Restore or set options
        /// </summary>
        private void TransparentWindowSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            settingsOptions.isEnable = originalOptions.isEnable;
            if (buttonOK.Tag == null)
            {
                //Restore options
                settingsOptions = originalOptions;
            }

            TransparentWindow.Options = settingsOptions;
            TransparentWindow.SetWindowOpacity(settingsOptions.Opacity);
        }

    }
}
