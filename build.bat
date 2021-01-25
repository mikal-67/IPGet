@ECHO off
cd src
csc Program.cs Form1.cs Form1.Designer.cs
ren Program.exe IPGet.exe
move IPGet.exe ..
cd ..