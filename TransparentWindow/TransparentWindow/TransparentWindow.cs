using Kbg.NppPluginNET.PluginInfrastructure;
using System.Windows.Forms;
using TransparentWindow.Forms;
using TransparentWindow.Helpers;
using static TransparentWindow.TransparentWindowConfig;

namespace TransparentWindow
{
    public class TransparentWindow
    {

        #region Menu command IDs
        public const int cmdIdIsEnable = 0,
                                      cmdIdOptions = 1,
                                      cmdIdSeparator1 = 2,
                                      cmdIdAbout = 3;
        private const int MaxOpacity = 255;
        #endregion

        #region Fields
        protected static TransparentWindowConfig config = new TransparentWindowConfig();

        /// <summary>
        /// Main options
        /// </summary>
        public static Options Options
        {
            get => config.options;
            set => config.options = value;
        }
        #endregion

        public TransparentWindow()
        {
        }

        #region NPP interface events

        /// <summary>
        /// Register menu commands
        /// </summary>
        public void CommandMenuInit()
        {
            #region Binding menu

            //Enable switch
            PluginBase.SetCommand(cmdIdIsEnable, "启用透明", IsEnableCommand, new ShortcutKey(true, true, false, Keys.D0), Options.isEnable);

            //Settings window
            PluginBase.SetCommand(cmdIdOptions, "设置...", SettingsCommand);

            //---Separator
            PluginBase.SetCommand(cmdIdSeparator1, "---", null);

            //About
            PluginBase.SetCommand(cmdIdAbout, "关于...", AboutCommand);

            #endregion


            #region Initialization work

            //Enable or disable
            config.options.isEnable = !Options.isEnable;
            IsEnableCommand();

            #endregion
        }

        /// <summary>
        /// Plug-in uninstall
        /// </summary>
        public void PluginCleanUp()
        {
            config.Save();
        }

        #endregion

        #region Menu commands

        /// <summary>
        /// Enable or disable features
        /// </summary>
        public void IsEnableCommand()
        {
            config.options.isEnable = !Options.isEnable;
            Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_SETMENUITEMCHECK, PluginBase._funcItems.Items[cmdIdIsEnable]._cmdID,
                Options.isEnable ? Win32.MF_CHECKED : Win32.MF_UNCHECKED);
            
            SetWindowOpacity(Options.Opacity);
            config.Save();
        }

        /// <summary>
        /// Open settings window
        /// </summary>
        public void SettingsCommand()
        {
            using (TransparentWindowSettings settings = new TransparentWindowSettings())
            {
                settings.ShowDialog(Control.FromHandle(PluginBase.GetCurrentScintilla()));
            }

            config.Save();
        }

        /// <summary>
        /// Show information about
        /// </summary>
        public void AboutCommand()
        {
            using (AboutDialog about = new AboutDialog())
            {
                about.ShowDialog(Control.FromHandle(PluginBase.GetCurrentScintilla()));
            }
        }

        #endregion

        #region Execution commands

        /// <summary>
        /// Set Notepad++ window opacity
        /// </summary>
        /// <param name="opacity">transparency</param>
        public static void SetWindowOpacity(int opacity)
        {
            WindowHelper.SetWindowOpacity((int)PluginBase.nppData._nppHandle, Options.isEnable ? (byte)opacity : (byte)MaxOpacity);
        }

        #endregion
    }
}
