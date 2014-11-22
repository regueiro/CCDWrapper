namespace MultiMonitorHelper.DisplayModels.Win7.Enum
{
    /// <summary>
    /// Use this enum so that you don't have to hardcode magic values.
    /// </summary>
    internal enum StatusCode : uint
    {
        Success = 0,
        InvalidParameter = 87,
        NotSupported = 50,
        AccessDenied = 5,
        GenFailure = 31,
        BadConfiguration = 1610,
        InSufficientBuffer = 122,
    }
}