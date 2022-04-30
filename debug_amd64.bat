cls
windres xivpvp.rc -O coff -o xivpvp.res
gcc -s -O2 -g -Iinclude xivpvp.c xivpvp.res -o amd64/XIVPvP.exe -Wall -lz -lWinDivert -lws2_32 -mwindows -Lamd64
