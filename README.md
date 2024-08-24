<!-- TOC --><a name="spongebobmockingtextgen"></a>
# SpongebobMockingTextGen
a command line program to turn any text into "Spongebob mocking Text"

<!-- TOC --><a name="info"></a>
### Info
+ **version:** [1.1.0](https://github.com/aSilentInferno/spongebobMockingTextGen/releases/latest)
+ **language:** `C#`
+ **OS**: Windows

<!-- TOC --><a name="table-of-contents"></a>
## Table of contents
<!-- TOC start (generated with https://github.com/derlin/bitdowntoc) -->

- [SpongebobMockingTextGen](#spongebobmockingtextgen)
      + [Info](#info)
   * [Table of contents](#table-of-contents)
   * [How to use](#how-to-use)
      + [Running the exe directly](#running-the-exe-directly)
   * [Setting the program up as an environmental variable](#setting-the-program-up-as-an-environmental-variable)
   * [Constraints/edge-case behavior](#constraintsedge-case-behavior)

<!-- TOC end -->


<!-- TOC --><a name="how-to-use"></a>
## How to use
1. [download](https://github.com/aSilentInferno/spongebobMockingTextGen/releases/latest) the exe
2. open the folder containing the exe in the cmd. If you are in the file explorer you can do this by right-clicking the folder and clicking open in Terminal
3. run the exe by running `.\exeName`, for example, `.\SpongeBobMockingTextGen-1.1.0-win-64x.exe`
     + If you want the program to read the text to be converted from a file instead of the Terminal you can add a `-f` at the end e.g. `.\SpongeBobMockingTextGen-1.1.0-win-64x.exe -f`
5. the program should now be running

<!-- TOC --><a name="running-the-exe-directly"></a>
### Running the exe directly
you *can* run the exe directly (by double-clicking it) however, it is not recommended as the program will close immediately and you won't have time to copy the result  
please note that there is also no way of using the -f argument if you decide to run the program by double-clicking it

<!-- TOC --><a name="setting-the-program-up-as-an-environmental-variable"></a>
## Setting the program up as an environmental variable
*right now there is no automation for this process, but maybe there will be in the future*  
If you want to be able to execute the program from everywhere you can modify the PATH variable to include this program  
### Important: Modifying the PATH variable is a standard process but should be done with care. Follow the steps below closely to ensure that your system continues to run smoothly. If you're unfamiliar with this process, consider following a detailed guide or consulting a knowledgeable resource.
1. place the file in another directory in `c:/` for example in `C:\Program Files\ProgramspongeSpongeBobMockingTextGen`
2. modify the PATH variable. If you don't know what this/how this works you should probably not do it ~~(aka google it, I'm too lazy to explain)~~
3. In the System variables section, find the Path variable and click Edit.
4. Click New and add the path to the directory where you placed your executable (e.g., `C:\Program Files\ProgramspongeSpongeBobMockingTextGen`).
5. Click OK to close all dialogs
Check if the modification was successfully
+ Check if the modification was successful by opening the cmd and typing `echo %PATH%`
+ If you see the path to the folder in which the exe recorded it worked

<!-- TOC --><a name="constraintsedge-case-behavior"></a>
## Constraints/edge-case behavior
+ The program will turn any text into SpongebobMockingText  
+ It will ignore any spaces and non-letters e.g., `Hello World123a` -> `hElLo wOrLd123A`
+ The first letter will be a small one 'a'
+ Any previous capitalization will be ignored
