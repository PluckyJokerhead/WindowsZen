Start powershell -WindowStyle hidden -c (New-Object Media.SoundPlayer "Windows Hardware Insert.wav").PlaySync();
if not exist "C:\WindowsSoundsNew" mkdir "C:\WindowsSoundsNew" 
echo f | xcopy /f "%~dp0\asterisk, beep, exclamation.wav" "C:\WindowsSoundsNew"
echo f | xcopy /f "%~dp0\calendar, mail, im, notification, sysnotification.wav" "C:\WindowsSoundsNew"
echo f | xcopy /f "%~dp0\Windows Battery Critical.wav" "C:\WindowsSoundsNew"
echo f | xcopy /f "%~dp0\Windows Battery Low.wav" "C:\WindowsSoundsNew"
echo f | xcopy /f "%~dp0\calendar, mail, im, notification, sysnotification.wav" "C:\WindowsSoundsNew"
echo f | xcopy /f "%~dp0\Windows Critical Stop" "C:\WindowsSoundsNew"
echo f | xcopy /f "%~dp0\Windows Hardware Fail.wav" "C:\WindowsSoundsNew"
echo f | xcopy /f "%~dp0\Windows Hardware Insert.wav" "C:\WindowsSoundsNew"
echo f | xcopy /f "%~dp0\Windows Hardware Remove.wav" "C:\WindowsSoundsNew"
echo f | xcopy /f "%~dp0\Windows Logon Sound.wav" "C:\WindowsSoundsNew"
echo f | xcopy /f "%~dp0\Windows Shutdown.wav" "C:\WindowsSoundsNew"
echo f | xcopy /f "%~dp0\Windows User Account Control.wav" "C:\WindowsSoundsNew"
@reg add "HKEY_CURRENT_USER\AppEvents\Schemes"                                             /t REG_SZ /d ".Test"  /f
@reg add "HKEY_CURRENT_USER\AppEvents\Schemes\Apps\.Default\.Default\.Current"             /t REG_SZ /d ""       /f
@reg add "HKEY_CURRENT_USER\AppEvents\Schemes\Apps\.Default\DeviceConnect\.Current"        /t REG_SZ /d "C:\WindowsSoundsNew\Windows Hardware Insert.wav"       /f
@reg add "HKEY_CURRENT_USER\AppEvents\Schemes\Apps\.Default\DeviceDisconnect\.Current"      /t REG_SZ /d "C:\WindowsSoundsNew\Windows Hardware Remove.wav"       /f
@reg add "HKEY_CURRENT_USER\AppEvents\Schemes\Apps\.Default\SystemAsterisk\.Current"        /t REG_SZ /d "C:\WindowsSoundsNew\asterisk, beep, exclamation.wav"       /f
@reg add "HKEY_CURRENT_USER\AppEvents\Schemes\Apps\.Default\CriticalBatteryAlarm\.Current"      /t REG_SZ /d "C:\WindowsSoundsNew\Windows Battery Critical.wav"       /f
@reg add "HKEY_CURRENT_USER\AppEvents\Schemes\Apps\.Default\SystemNotification\.Current"        /t REG_SZ /d "C:\WindowsSoundsNew\Windows Notify.wav"       /f
@reg add "HKEY_CURRENT_USER\AppEvents\Schemes\Apps\.Default\WindowsUAC\.Current"      /t REG_SZ /d "C:\WindowsSoundsNew\Windows User Account Control.wav"       /f
@reg add "HKEY_CURRENT_USER\AppEvents\Schemes\Apps\.Default\Notification.Default\.Current"        /t REG_SZ /d "C:\WindowsSoundsNew\Windows Notify.wav"       /f
@reg add "HKEY_CURRENT_USER\AppEvents\Schemes\Apps\.Default\Notification.Mail\.Current"      /t REG_SZ /d "C:\WindowsSoundsNew\Windows Notify.wav"       /f
@reg add "HKEY_CURRENT_USER\AppEvents\Schemes\Apps\.Default\WindowsLogon\.Current"        /t REG_SZ /d "C:\WindowsSoundsNew\Windows Logon Sound.wav"
@reg add "HKEY_CURRENT_USER\AppEvents\Schemes\Apps\.Default\WindowsLogoff\.Current"        /t REG_SZ /d "C:\WindowsSoundsNew\Windows Shutdown.wav"       /f
@reg add "HKEY_CURRENT_USER\AppEvents\Schemes\Apps\.Default\DeviceFail\.Current"        /t REG_SZ /d "C:\WindowsSoundsNew\Windows Hardware Fail.wav"       /f
@reg add "HKEY_CURRENT_USER\AppEvents\Schemes\Apps\.Default\.Default\.Current"        /t REG_SZ /d "C:\WindowsSoundsNew\asterisk, beep, exclamation.wav"       /f
TIMEOUT 3
 