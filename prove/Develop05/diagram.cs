/*

+----------------------------------+
|           Program                |
+----------------------------------+
| - welcome: string                |
+----------------------------------+
| + Start()                        |
| + Quit()                         |
| + MainMenu()                     |
| + GoalMenu()                     |
| + Goal()                         |
| + CreateGoal(params)             |
| + ListGoal(params)               |
| + SaveGoal()                     |
| + LoadGoal()                     |
| + RecordEvent()                  |
+----------------------------------+
                ^
                |
                |
                |
                v
+----------------------------------+
|             Goal                 |
+----------------------------------+
| - name: string                   |
| - points: int                    |
| - status: string                 |
| - goals: List<Entry>             |
+----------------------------------+
| + Goal()                         |
| + CreateGoal(params): returnType |
| + ListGoal(params)               |
| + SaveGoal()                     |
| + LoadGoal()                     |
| + RecordEvent()                  |
+----------------------------------+
                ^
                |                           +----------------------------------+
                |                           |           SimpleGoal              |
                +-------------------------->|----------------------------------+
                |                           | - points: int                    |
                |                           | - description: string            |
                |                           | - status: string                 |
                |                           +----------------------------------+
                |                           | + SimpleGoal(params): returnType |
                |                           | + CreateGoal(params): returnType |
                |                           | + GetDescription(params)         |
                |                           | + CalculatePoints()              |
                |                           +----------------------------------+
                |
                |                           +----------------------------------+
                |                           |          EternalGoal              |
                +-------------------------->|----------------------------------+
                |                           | - points: int                    |
                |                           | - description: string            |
                |                           | - status: string                 |
                |                           +----------------------------------+
                |                           | + EternalGoal(params): returnType|
                |                           | + CreateGoal(params): returnType |
                |                           | + GetDescription(params)         |
                |                           | + CalculatePoints()              |
                |                           +----------------------------------+
                |
                |
                |
                |                           +----------------------------------+
                |                           |         ChecklistGoal            |
                +-------------------------->|----------------------------------+
                                            | - points: int                    |
                                            | - description: string            |
                                            | - bonus: int                     |
                                            | - frequency: int                 |
                                            | - status: string                 |
                                            +----------------------------------+
                                            | + ChecklistGoal(params): returnType |
                                            | + CreateGoal(params): returnType |
                                            | + GetDescription(params)         |
                                            | + CalculatePoints()              |
                                            | + CalculateBonus()               |
                                            +----------------------------------+

*/