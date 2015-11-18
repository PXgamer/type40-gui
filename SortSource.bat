@echo off &setlocal
set dir=%1
set "extlist=.mkv|.mp4|.bat|.srt|"
for /r %dir% %%i in (*) do (
    set "fname=%%~i"
    setlocal enabledelayedexpansion
    if "!extlist:%%~xi|=!"=="%extlist%" del "!fname!"
    endlocal

    DEST="%userprofile%/Desktop/Encodes"
    DEST_EXT=mp4

for FILE in "`ls $SRC`"
do
filename=$(basename $FILE)
extension=${filename##*.}
filename=${filename%.*}

HandbrakeCLI.exe -i $/$FILE -o "$DEST"/"$filename".$DEST_EXT "-E fdk_faac -A "English" - B 384k --mixdown 6ch -R 48 -e x264 -q 25 -r 23.976 --cfr -x level=4.1:cabac=1:ref=5:analyse=0x133:me=umh:subme=9:chroma-me=1:deadzone-inter=21:deadzone-intra=11:b-adapt=2:rc-lookahead=60:vbv-maxrate=10000:vbv-bufsize=10000:qpmax=69:bframes=4:b-adapt=2:direct=auto:crf-max=51:weightp=2:merange=24:chroma-qp-offset=-1:sync-lookahead=2:psy-rd=1.00,0.15:trellis=2:min-keyint=23:partitions=all"

echo Done
)

for /f "usebackq delims=" %%d in (`"dir /ad/b/s | sort /R"`) do rd "%%d"

CLS
echo All Excess Files Removed
echo %dir% cleaned