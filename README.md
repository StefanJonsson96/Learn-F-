# Learn F#

This project consists of a bunch of small files to learn F# syntax. I try to include code comments to explain what I was doing. I used Visual Studio to write and test code, however VsCode might be better suited for this. 

**TODO: Try VSCode.**

# Notes:
* **Material used:**
  - Microsoft docs: https://learn.microsoft.com/en-us/dotnet/fsharp/
  - Pluralsight course: https://app.pluralsight.com/library/courses/f-sharp-6-fundamentals/table-of-contents
  - Google Bard AI: https://bard.google.com/ (you can send it small code snippets and ask for assistance, with clever prompting you can ask it how to figure out why something doesn't work instead of just fixing the code directly.)

* **Is your file not running?:** The default behaviour is for files to not be built. You would have to click the file(s) that you care about building in Solution Explorer, and under Properties => Build action: F# Compiler. 

    **TODO: Find a better workaround for this, since its quite annoying.** Current workaround is to copy files instead of creating new files so I keep the setting.

* **Why cant i open module x?:** File x that needs to open file y needs to be the further down in the folder since the F# compiler reads top to bottom. 

    You can right click to move up and down or **(Alt+Up or Alt+Down arrow shortcuts.)** 
    
    OR you need to Build :-) (**Ctrl+Shift+B**)

* **How to debug?:** Program.fs will be ran when you start debugging. All the open statements are alredy prepared. Just call the function you want to try out. :-)
    
    Note: Global open is not supported in F#. 

    See links for more info:   
    https://github.com/fsharp/fslang-suggestions/issues/1029 
    
     https://github.com/fsharp/fslang-suggestions/issues/1096 
    
* Workflow explained:
    
    1: Make a new .fsx file in a new or existing folder.
    

    2: Set namespace to projectname.foldername 

    3: Set module name to filename

    4: Write some code and add breakpoints if needed.
    
    5: Add open statement in Program.fs

    6: Replace the function call below **[<EntrypPoint\>]** attribute with the new function.

    7: Debug the application and fix the code if it doesn't work.

    8: Repeat.
    
