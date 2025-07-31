# Lab 2 – F# Programming: Records and Discriminated Unions
I created the valentinebudget.fsx file with the assistance of ChatGPT. The program uses Discriminated Unions in F# to represent different Valentine's Day activities and calculates their total budget based on the selected options.

## Overview

This lab includes two sections:

1. Tracking NBA Basketball Statistics using Records
2. Calculating Valentine's Day Budget using Discriminated Unions

---

##  Part A: NBA Basketball Statistics (Using Records)

###  Objective
To understand how to define and use F# records to track NBA basketball team statistics and apply list operations like filter and map.

### What the Part A Does
Creates 5 NBA teams with:

##  Team name
Coach info (name + whether they were a former player)
Win/loss stats

## Filters out successful teams, where:
Wins > Losses

## Calculates the success percentage for all teams using:
(Wins / (Wins + Losses)) * 100
Prints:
Names of successful teams
Success percentages of all teams
 Data Recap
Team	Wins	Losses
Boston Celtics	61	21
Golden State	48	34
Indiana Pacers	50	32
Miami Heat	37	45
LA Lakers	50	32

## Expected Output
 Successful Teams (Wins > Losses):
Boston Celtics → 61 > 21 
Golden State Warriors → 48 > 34 
Indiana Pacers → 50 > 32 
Miami Heat → 37 < 45 
LA Lakers → 50 > 32 

## So the successful teams are:
 Successful Teams:
- Boston Celtics
- Golden State Warriors
- Indiana Pacers
- Los Angeles Lakers
 Success Percentages
Formula:
(wins / (wins + losses)) * 100

## Let’s calculate it for each team:
Boston Celtics: (61 / (61+21)) * 100 = (61 / 82) * 100 ≈ 74.39%
Golden State: (48 / 82) * 100 ≈ 58.54%
Indiana Pacers: (50 / 82) * 100 ≈ 60.98%
Miami Heat: (37 / 82) * 100 ≈ 45.12%
LA Lakers: (50 / 82) * 100 ≈ 60.98%

## Final Output:
Successful Teams:
- Boston Celtics
- Golden State Warriors
- Indiana Pacers
- Los Angeles Lakers

 Team Success Percentages:
- Boston Celtics: 74.39%
- Golden State Warriors: 58.54%
- Indiana Pacers: 60.98%
- Miami Heat: 45.12%
- Los Angeles Lakers: 60.98%

## Part B: Valentine's Day Budget (Using Discriminated Unions)

###  Objective
To learn how to use Discriminated Unions and pattern matching in F# for modeling real-world scenarios.

###  Discriminated Unions Defined

- `Cuisine`: Korean | Turkish  
- `MovieType`: Regular | IMAX | DBOX | RegularWithSnacks | IMAXWithSnacks | DBOXWithSnacks  
- `Activity`: BoardGame | Chill | Movie of MovieType | Restaurant of Cuisine | LongDrive of (int * float)

### Budget Calculation Rules

| Activity            | Cost                                                       
|------------------   |-------------------------------                    
| Board Game          | $0 CAD                              
| Chill               | $0 CAD                              
| Movie               | Regular: $12, IMAX: $17, DBOX: $20 
|                     | +$5 if snacks are included    
| Restaurant          | Korean: $70/couple, Turkish: $65/couple 
| Long Drive          | `kilometres * rate per km`    

### Example
calculateBudget (Movie IMAXWithSnacks) // Output: 22.0
calculateBudget (Restaurant Korean)    // Output: 70.0
calculateBudget (LongDrive (60, 0.20)) // Output: 12.0
Total would be 119.
