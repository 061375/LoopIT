# LoopIT
Just a simple program to loop a Windows Directory

Proof of Concept:

This program loops over the file structure of a Windows directory.
It runs from the Windows Command Line Prompt.

The program in theory could be used to:
1. Translate the file structure to a document
2. Run operations of the files such as versioning or add prefixes to files prior to adding to IQMS.
3. Import files into IQMS

Program requires at least one argument
[1] - path to folder to loop
[2] - target directory or file [dir,file] optional - default is dir
[3] - directories to skip - can be a single value or list delimitted by commas Example: "Archive,Archive 2"

Usage Example:

C:\Path\To\File\LoopIT.exe "U:\IQMS TRANSFER DOCUMENTS" dir "Archive,Archive 2"

In addition to allowing directories to be skipped the program also checks against the path length limit of 250 characters.
Directory paths greater than or equal to are skipped.
