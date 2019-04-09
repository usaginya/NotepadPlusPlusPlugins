using System;
using System.Reflection;
using System.Windows.Forms;

namespace TransparentWindow.Forms
{
    public partial class AboutDialog : Form
    {

        //Get the assembly information
        private string title = ((AssemblyTitleAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyTitleAttribute), false)).Title,
                    description = ((AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyDescriptionAttribute), false)).Description,
                    version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        private const string creator = "YIU",
        github = "https://github.com/usaginya/NotepadPlusPlusPlugins/tree/master/TransparentWindow";

        public AboutDialog()
        {
            InitializeComponent();

            labelAbout.Text = $@"{title}
{description}

Version: {version}
Creator: {creator}";

        }

        private void ButtonGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(github);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
