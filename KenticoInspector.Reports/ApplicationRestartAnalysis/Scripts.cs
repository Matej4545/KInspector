﻿namespace KenticoInspector.Reports.ApplicationRestartAnalysis
{
    public class Scripts
    {
        public static string BaseDirectory = $"{nameof(ApplicationRestartAnalysis)}/Scripts";

        public static string GetCmsEventLogsWithStartOrEndCode = $"{BaseDirectory}/{nameof(GetCmsEventLogsWithStartOrEndCode)}.sql";
    }
}