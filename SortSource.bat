@echo off &setlocal
set "extlist=.mkv|.mp4|.bat|"
for /r "c:\video" %%i in (*) do (
    set "fname=%%~i"
    setlocal enabledelayedexpansion
    if "!extlist:%%~xi|=!"=="%extlist%" echo del "!fname!"
    endlocal
)

for /f "usebackq delims=" %%d in (`"dir /ad/b/s | sort /R"`) do rd "%%d"

echo All Excess Files Removed