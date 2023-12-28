# Ecosystem Project 
A windows application that simulates a preditor-prey environment. 

![](/ReadMe_Images/screenshot1.png)

Entities: 
| Name | Char | Description |
| --- | --- | --- |
| Grass | " | Grass has a random chance to spread each day.            |
| Sheep | a | Adolescent sheep. Consumes grass. Matures after 10 days. |
|       | @ | Adult sheep. Consumes grass. Will seek out mate if fed.  |
| Wolf  | v | Adolescent wolf. Consumes sheep. Matures after 20 days.  |
|       | ¥ | Adult wolf. Consumes sheep. Will seek out mate if fed.   |

## Download
[Download Executable Here](https://JollyWolly.github.io/EcosystemProject/blob/main/EcosystemProject/bin/Debug/EcosystemProject.exe)

## Usage
### Creation
| Control | Description | 
| --- | --- |
| Height             | Number of tiles high environment is. |
| Width              | Number of tiles wide environment is. |
| Prevent Extinction | If a species would go extinct, spawn in a new one after some time. |
| Spawn Rate         | Controls the amount of a species that is initially generated. |
| Create Eco         | Create an ecosystem with the above parameters. |

### Progression
| Control | Description |
| --- | --- |
| Skip Days | Set number of days to skip. | 
| Skip      | Skip the set amount of days. |
| Next Day  | Progress to next day in simulation. |

### Info
| Button | Option |  Description |
| --- | --- | --- |
| Pop. Graph |    | Opens new window showing population over time.        |
|            | g  | Include grass population in graph.                    |
|            | s  | Include sheep population in graph.                    |
|            | w  | Include wolf popuation in graph.                      |
| Gro. Graph |    | Opens new window showing population growth over time. |
|            | g' | Include grass growth in graph.                        |
|            | s' | Include sheep growth in graph.                        |
|            | w' | Include wolf growth in graph.                         |

![](/ReadMe_Images/screenshot2.png)

Save buttons save a txt file containing graph's data for that population. Formatted as '(day, number)'. 

### Appearance 
| Theme | Description | 
| --- | --- |
| night mode | Toggle for night mode. | 
| colored grid | Add color to the grid. Helps with identifying entities, but lags the program a bit. |
