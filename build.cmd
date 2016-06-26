@ECHO OFF
SETLOCAL
SET path=%1
csc WiringPiSharp\*.cs /target:library /out:WiringPiSharp.dll /doc:WiringPiSharp.xml

