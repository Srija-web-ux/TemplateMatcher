# Template Matcher

## Overview
This project implements a flexible **template matcher** that verifies if a given text conforms to a specified pattern.  
The template consists of a combination of rules:
1. **Wildcard (`*`)** - Matches any character.
2. **Character List (`(A|B|C)`)** - List of chars surrounded by brackets () and delmited by pipe | Matches any character in the 
    list (case insensitive).
3. **Exact Character (`X`)** - Matches only the specific character (case insensitive).
4. **Not Character (`!X`)** - Matches any character **except** the specified one.

## Features
- Supports various matching rules.
- Throws exceptions for invalid inputs.
- Designed to be extensible—new rules can be added easily.
- Fully unit-tested for correctness.

### Prerequisites
- .NET 6.0+ installed on your system.
- A C# development environment like Visual Studio.

### Clone the Repository
- git clone https://github.com/Srija-web-ux/TemplateMatcher.git
- cd TemplateMatcher

### Running the Project
dotnet build

Created test project for testing all the rules individually using xUnit

### Running the tests
dotnet test

### Usage

Example : Match the text against a template

Template : (B|D|E)**AC*
Text : BPQACC
IsMatch((B|D|E)**AC*, BPQACC) == true
Matches the template

Template : (B|D|E)**AC*
Text : BPQBCC
IsMatch((B|D|E)**AC*, BPQBCC) == false
does not match because 4th char is not 'A'


