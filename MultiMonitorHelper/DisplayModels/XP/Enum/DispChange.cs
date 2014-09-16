using System;

namespace MultiMonitorHelper.DisplayModels.XP.Enum
{
	[Flags]
	public enum DispChange
	{
		Successful = 0,
		Restart = 1,
		Failed = -1,
		BadMode = -2,
		NotUpdated = -3,
		BadFlags = -4,
		BadParam = -5,
		BadDualView = -1
	}
}