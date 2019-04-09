using Kbg.NppPluginNET.PluginInfrastructure;

namespace TransparentWindow
{
    public class Main
    {
        #region Fields
        public const string PluginName = "透明窗体";

        /// <summary>
        /// "Singleton" for this plugin of the actual implementation
        /// </summary>
        private static readonly TransparentWindow transparentWindow = new TransparentWindow();
        #endregion

        #region NPP interface events
        internal static void CommandMenuInit()
        {
            transparentWindow.CommandMenuInit();
        }

        internal static void SetToolBarIcon()
        {
        }

        internal static void PluginCleanUp()
        {
            transparentWindow.PluginCleanUp();
        }

        /// <summary>
        /// This method is invoked whenever something is happening in notepad++
        /// use eg. as
        /// if (notification.Header.Code == (uint)NppMsg.NPPN_xxx)
        /// { ... }
        /// or
        ///
        /// if (notification.Header.Code == (uint)SciMsg.SCNxxx)
        /// { ... }
        /// </summary>
        /// <param name="notification"></param>
        public static void OnNotification(ScNotification notification)
        {
        }
        #endregion

    }
}