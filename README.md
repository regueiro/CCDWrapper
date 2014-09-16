MultiMonitorHelper
==================

API decided to help manage states/query of multiple monitors, using C# language. 

It allows to extend and clone monitors easily(abstracting WinXP, Vista, 7, and 8), at the same time,
you can query information about your monitors. 

The motivation for this library came from the fact that the existing Winforms Screen.cs is weak.

First of all, it's missing a lot of functionality. 
Second of all, it does not show "latest" information.

The other option is to use pInvoke, but that's madness, since if you want to extend monitor
on XP, you need to do a lot of non-sense. At the same time, extending monitors on windows7/8 is completely
another issue. 
