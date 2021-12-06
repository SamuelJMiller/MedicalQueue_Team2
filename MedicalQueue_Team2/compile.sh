#!/bin/bash
dpkg -s mono-complete > /dev/null 2>&1
if [ $? -eq 0 ]
then
	mcs *.cs
	./ERQueue.exe
else
	echo "Mono is required to compile C# code on Linux."
	echo "Opening APT to install mono-complete... Press CTRL+C to abort."
	sudo apt install mono-complete
fi