Netduino-GCode
==============

A GCode tool written in C# which can be used to view and edit G-code files. G-code (http://en.wikipedia.org/wiki/G-code) is a standard language used in automation (CNC, numerical control) to instruct machines the movements they need to perform in other to build a shape designed in a CAD program. That CAD model is then converted to GCode by some CAM software and that GCode is parsed by this software to generate machine movements.

## Ideas

* Cross platform?
* Android/iOs?

## Building

The project is a VS2015 solution, that requires no extra components. 

To open a GCode file, click on the top yellow bar. An open file dialog will pop up letting you choose the GCode file. No error checking is performed, if you feed any other type of file, the app may crash. 

Review the toolpaths in the 3D viewer: 

* Left mouse click and drag to rotate the 3D view. 
* Shift + left click and drag to translate. (alternatively, click and drag with the mouse wheel or middle button)
* Mouse wheel to zoom in and out. (alternatively, Ctrl + left click and drag does the same)

## License

This code is licensed under the MIT license.
