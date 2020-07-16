# _Scrabble_

#### _C# Test Driven Development practice for Epicodus, 07.16.2020_

#### By _**Beverly Potts & Brittany Lindgren**_

## Description

_An application to take in a word from a user and return the Scrabble score for that word. Now you can evaluate your word to achieve maximum point values!_

## Specifications

| Behavior   |   Input   |  Output |
|----------|:-------------:|------:|
| Program will take in a word from the user | "apple" | n/a |
| Program will separate a word into individual letters | "apple" | "a", "p", "p", "l", "e" |
| Program will give the numerical value of a letter | "a" | 1 |
| Program will add the value of each letter together | "a", "p", "p", "l", "e" | "a"= 1,  "p" = 3, "p" = 3, "l" = 1, "e" = 1  : total = 10 |
| If user enters a number, program does not proceed | 5 | error |
| If user enters more than one word, program does not proceed | "hello world" | error |
| If user enters special characters, program does not proceed | $#@!* | error |


## Setup/Installation Requirements


  1. Follow this [link to the project repository](REPOSITORY LINK HERE) on GitHub.   |    |    
  2. Click on the "Clone or download" button to copy the project link.     
  3. If you are comfortable with the command line, you can copy the project link and clone it through your command line with the command `git clone`. Otherwise, I recommend choosing "**Download ZIP**".     
   4. Once the ZIP file has finished downloading, you can right click on the file to view the zip folder in your downloads.     
  5. Right click on the project ZIP folder that you have just downloaded and choose the option "**Copy To...**", then choose the location where you would like to save this folder.      
  6. Navigate to the final location where you have chosen to save the project folder.      
  7. To view the code itself, right click, choose "open with..." and open using a text editor such as VS Code or Atom, etc.
  8. Open the terminal inside of your text editor.
  9. From inside of the Scrabble.Tests directory, type the command `dotnet restore` into your terminal and hit enter. You should see object files appear. They should be greyed out.
  10. Navigate to the Scrabble directory and type the command `dotnet build` into your terminal and hit enter. You should see files appear inside of your bin folder. The bin folder should appear greyed out.
  11. Repeat step 10 from inside of the Scrabble.Tests directory.   


#### Additional Setup/Installation Notes:

* No additional code is necessary to view this project.   

## Known Bugs

| Bug | Resolved (Y/N) |  How was the issue resolved?  |
| ------- | ----- | ------ |
|  |  |  | 


## Support and contact details

_Please feel free to contact the authors through GitHub (LINDGRENBA) or (BAPOTTS) with any feedback, questions or concerns._

## Technologies Used

* C# 
* .NET-Core 2.2
* Visual Studio Code
* Git Version Control 
* GitHub

### License

*This site is licensed under the MIT license.*

Copyright (c) 2020 **_{Beverly Potts & Brittany Lindgren}_**