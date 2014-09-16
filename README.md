MultiMonitorHelper
==================

API decided to help manage states of multiple monitors, using C# language. 
It will allow to extend and clone monitors easily(abstracting WinXP, Vista, 7, and 8)


Solution needs to support next features(RELEASE ONE);
enumerating over the active and inactive monitors, and their states.
extending and cloning monitors / getting information about topology.
abstracting away different display models(extending/cloning in XP/Win7 is absolutely different).
swaping monitors easily.
rotating monitors.
taking screenshots.
getting orientation(landscape / portrait)

Architecture will be laid out so that it can be extended to other platforms later. Such as linux. 
