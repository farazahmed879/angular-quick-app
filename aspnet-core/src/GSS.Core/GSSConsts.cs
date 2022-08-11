using GSS.Debugging;

namespace GSS
{
    public class GSSConsts
    {
        public const string LocalizationSourceName = "GSS";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "c705dce953e44ade88e1f9978927343c";
    }
}
