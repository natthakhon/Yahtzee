# Yahtzee
## Solution Structure
The solution contains 3 projects
| Project | Description |
| ------ | ------ |
| YahtzeeModel | Class library |
| YahtzeeModel.Test | Unit test |
| YahtzeeUI | Win form UI |

## YahtzeeModel
There are 2 main abstract classes
| Class |  Description
| ------ | ------- |
| Category | Mother of all categories class
| NofaKindCategory | Inherits from Category with linq result

Most of the rest are inherited classes of those two. 
There are, however, two more classes used for representing the result on Ui

## YahtzeeModel.Test
The unit test project to test different categories

## YahtzeeUI
Win form just to show the result of different dice results on screen 
