
<br />
<div align="center">
  <a href="https://github.com/OscarWright/HSCSDD-T2-4P1W">
    <img src="icon.png" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">4 Pics 1 Word</h3>

  <p align="center">
    HSC Software Design & Development - Task 2
    <br />
    <br />
    <a href="https://github.com/OscarWright/HSCSDD-T2-4P1W/raw/main/4P1W/bin/Debug/4P1W.exe">Download Build (.exe)</a>
    |
    <a href="https://github.com/OscarWright/HSCSDD-T2-4P1W/archive/refs/heads/main.zip">Download Source (.zip)</a>
  </p>
</div>


<!-- ABOUT THE PROJECT -->
## About The Project
<!--[![Product Name Screen Shot][product-screenshot]](https://example.com)-->
4 pics 1 word is a popular puzzle game for mobile devices that contains four pictures with one thing in common. The developer of 4 pics 1 word, LOTUM has enlisted you to develop a desktop version of the game. The game must randomise the pictures and letters, include at least six levels, maximum five guesses per word with a hint after the third attempt and a printable scoreboard.

## Task specifications

Students are to design and construct a full software solution in Visual Studio (Visual C#) to ONE of the following case problems. Each product should allow for at least ten minutes of varied interaction by the user, be appropriate for the intended audience and utilise logical coding structures and project management techniques. Students should endeavour to find an efficient software solution with appropriate use of features applicable to their chosen problem.

## Table of Contents

- [Getting Started](#getting-started)
	- [Install](#install)
	- [How to play](#how-to-play)
- [Specifications](#specifications)
	- [IPO Chart](#IPO-Chart)
	- [Context Diagram](#Context-Diagram)
	- [Data Flow Diagram](#data-flow-diagram)
	- [Structure Chart](#Structure-chart)
	- [Data Dictionary](#data-dictionary)
	- [Storyboard](#storyboard)
- [Changelog](#changelog)
- [License](#License)

## Getting Started

### Install

> Windows x64 Portable - [Download](https://github.com/OscarWright/HSCSDD-T2-4P1W/raw/main/4P1W/bin/Debug/4P1W.exe)


### How to play
 The aim of four pics one word is to correctly guess a word in which 4 relevant pictures are shown as clues, you will have 5 attempts to correctly guess a word and after 3 attempts you will be prompted with a hint. 
 
 <img align="right" width="100" height="100" src="https://github.com/OscarWright/HSCSDD-T2-4P1W/blob/main/DOCS/how2.gif">

 
> To input a guess, click the letters at the bottom of the screen in sequence to form a word
>
> Click the 'Check' Button to see if your guess is correct or not. 
>
> To clear your selection press the 'Clear' button.

## Specifications

### IPO Chart

| Input| Process | Output | 
| :---: | :---: | :---: |
| User clicks 'Play'  | `Game form is opened and Main form is hidden`  | Game form is show and Game starts  |
| User clicks 'How to play'  | `Help form is opened and Main form is hidden`  | Help form is shown  |
| User selects a guess letter | `locate the leftest empty answer box, set the text in the answer box to the guessed letter` | Guessed letter is shown in the array of answer boxes |
| User clicks 'Clear' | `Clear the answer boxes, Reset and randomise the possible guess buttons `| Guesses and possible guesses are returned to their original positon.|
| User clicks 'Check' | `Concatenate all text inside the answer boxes and compare to the string to original word` | Confirmation of guess (Correct/Incorrect), notify player of remaining attempts, update score, update index variables |
| User guesses correctly | ` Show message box with confirmation, increment indecies, reset attempts, generate message box, call the game function.` | Confirmation, score |
| User guesses incorrectly | `Increment attempts by 1, Show message box with confirmation and attempts remaining (5 - Attempts), call the game function.` | Confirmation, Attempts remaining |
| User fails to guess the word after 3 attempts | ` Pull the index specific hint from the Hints array and display it via a message box ` | Hint |
| User fails to guess the word after 5 attempts | ` Generate message box to show user that the game is over` | Game over notification, User is sent to Form1 | 

### Context Diagram

<div align="center">

![Context](https://github.com/OscarWright/HSCSDD-T2-4P1W/blob/main/DOCS/Context.png?raw=true)

</div>

### Data Flow Diagram


### Structure Chart


### Data Dictionary

| Data Item  | Data Type | Format | Bytes of Storage | Size for Display | Description | Example | Validation |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| `Content Cell`  | Content Cell  | Content Cell  | Content Cell  | Content Cell  | Content Cell  | Content Cell  | Content Cell  |
| `Content Cell`  | Content Cell  | Content Cell  | Content Cell  | Content Cell  | Content Cell  | Content Cell  | Content Cell  |

### Storyboard

<div align="center">
	
![StoryBoard](https://github.com/OscarWright/HSCSDD-T2-4P1W/blob/main/DOCS/storyboardv2.png?raw=true)
	
</div>

## Changelog

[Changelog](https://github.com/OscarWright/HSCSDD-T2-4P1W/blob/main/changelog.md)

## License

[MIT License](https://github.com/OscarWright/HSCSDD-T2-4P1W/blob/main/LICENSE) © 2022 [Oscar Wright](https://github.com/OscarWright).
