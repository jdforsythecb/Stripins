@echo off

if not exist c:\eps md c:\eps
if not exist c:\eps\dump md c:\eps\dump

REM ***** remove old version
if exist C:\stripins\photoshop del c:\stripins\photoshop\*.*
if exist C:\stripins del c:\stripins\*.*

if not exist c:\stripins md c:\stripins
if not exist C:\stripins\photoshop md c:\stripins\photoshop

copy /y G:\jdforsythe\stripins\*.* c:\stripins
copy /y G:\jdforsythe\stripins\photoshop\*.* c:\stripins\photoshop

REM ***** which version of photoshop
if exist "C:\Program Files\Adobe\Adobe Photoshop CS4\Presets\Scripts" copy /y G:\jdforsythe\stripins\photoshop\script "C:\Program Files\Adobe\Adobe Photoshop CS4\Presets\Scripts"
if exist "C:\Program Files\Adobe\Adobe Photoshop CS5\Presets\Scripts" copy /y G:\jdforsythe\stripins\photoshop\script "C:\Program Files\Adobe\Adobe Photoshop CS5\Presets\Scripts"
if exist "C:\Program Files\Adobe\Adobe Photoshop CS5.1\Presets\Scripts" copy /y G:\jdforsythe\stripins\photoshop\script "C:\Program Files\Adobe\Adobe Photoshop CS5.1\Presets\Scripts"
if exist "C:\Program Files\Adobe\Adobe Photoshop CS6\Presets\Scripts" copy /y G:\jdforsythe\stripins\photoshop\script "C:\Program Files\Adobe\Adobe Photoshop CS6\Presets\Scripts"

REM ***** move shortcuts
move "C:\stripins\Create Stripins.lnk" "%USERPROFILE%\Desktop"
move "C:\stripins\Create Images.lnk" "%USERPROFILE%\Desktop"

echo If you have a different version of Photoshop than CS5, you will need to
echo edit the properties of the "Create Images" shortcut on your desktop.

pause