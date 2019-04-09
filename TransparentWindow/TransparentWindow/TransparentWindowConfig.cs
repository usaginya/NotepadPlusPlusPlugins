using Kbg.NppPluginNET.PluginInfrastructure;
using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace TransparentWindow
{
    public class TransparentWindowConfig
    {
        #region Fields
        protected string iniFilePath = string.Empty;
        protected string assemblyName = string.Empty;

        public struct Options
        {
            public const int MinimumOpacity = 50;
            public const int MaxOpacity = 250;

            public bool isEnable;

            /// <summary>
            /// Notepad++ window opacity
            /// </summary>
            private int opacity;
            public int Opacity
            {
                get => opacity > MaxOpacity ? MaxOpacity : (opacity < MinimumOpacity ? MinimumOpacity : opacity);
                set => opacity = value > MaxOpacity ? MaxOpacity : (value < MinimumOpacity ? MinimumOpacity : value);
            }
        }

        /// <summary>
        /// Default options
        /// </summary>
        public Options options = new Options()
        {
            isEnable = false,
            Opacity = 220
        };
        #endregion


        public TransparentWindowConfig()
        {
            assemblyName = Assembly.GetExecutingAssembly().GetName().Name;

            #region Initialization
            StringBuilder sbIniFilePath = new StringBuilder(Win32.MAX_PATH);
            Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_GETPLUGINSCONFIGDIR, Win32.MAX_PATH, sbIniFilePath);
            iniFilePath = sbIniFilePath.ToString();

            if (!Directory.Exists(iniFilePath))
            {
                Directory.CreateDirectory(iniFilePath);
            }

            iniFilePath = Path.Combine(iniFilePath, assemblyName + ".ini");
            #endregion

            Load();
        }

        /// <summary>
        /// Load all configuration settings
        /// </summary>
        /// <returns>False returns when loading errors</returns>
        public bool Load()
        {
            //Box magic to set structs
            object options = this.options;

            try
            {
                foreach (FieldInfo field in this.options.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
                {
                    if (field.FieldType == typeof(bool))
                    {
                        field.SetValue(options, Win32.GetPrivateProfileInt(assemblyName, field.Name, 0, iniFilePath) > 0);
                    }
                    else if (field.FieldType == typeof(int))
                    {
                        int defaultValue = 0;
                        defaultValue = field.Name.Equals(nameof(Options.Opacity), StringComparison.OrdinalIgnoreCase) ? this.options.Opacity : defaultValue;
                        field.SetValue(options, Win32.GetPrivateProfileInt(assemblyName, field.Name, defaultValue, iniFilePath));
                    }
                }

                //Unbox magic to set structs
                this.options = (Options)options;
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Save all configuration settings
        /// </summary>
        /// <returns>False returns when saving errors</returns>
        public bool Save()
        {
            try
            {
                bool result = false;

                foreach (FieldInfo field in options.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
                {
                    object value = field.GetValue(options);

                    if (field.FieldType == typeof(bool))
                    {
                        value = value ?? false;
                        result = Win32.WritePrivateProfileString(assemblyName, field.Name, ((bool)value) ? "1" : string.Empty, iniFilePath);
                    }
                    else if (field.FieldType == typeof(int))
                    {
                        value = value ?? 0;
                        result &= Win32.WritePrivateProfileString(assemblyName, field.Name, value.ToString(), iniFilePath);
                    }
                }

                return result;
            }
            catch
            {
                return false;
            }
        }

    }
}
