namespace TailwindTraders.Mobile.Features.Settings
{
    public static class DefaultSettings
    {
        public const string ApiAuthorizationHeader = "Authorization";

        public static string AccessToken = string.Empty;

        public const string AppCenterAndroidSecret = "294a0c40-09f6-46ee-8166-edc53dd99f80";

        public const string AppCenteriOSSecret = "b8ef3bcf-bbce-484a-931a-c1675a638c41";

        public const bool UseFakeAPIs = UITestMode || DebugMode;

        public const bool UseFakeAuthentication = UITestMode || DebugMode;

        public const bool ForceAutomaticLogin = !UITestMode && DebugMode;

        public const bool BreakNetworkRandomly = !UITestMode && DebugMode;

        public const bool AndroidDebuggable = DebugMode;

        public const bool UseDebugLogging = UITestMode || DebugMode;

        public const bool EnableARDiagnostics = DebugMode;

        public const bool DebugMode =
#if DEBUG 
            true;
#else
            false;
#endif

        public const bool UITestMode =
#if IS_UI_TEST
            true;
#else
            false;
#endif

        public static string RootApiUrl { get; set; } = "https://mobileapi.com";

        public static string RootWebApiUrl
        { get; set; } = "https://mobilewebapi";
    }
}
