/* 
-------------------------------------------------------------Program Diagram-----------------------------------------------------------

                                                    +-----------------------------------+
                                                    |       Mindfulness App             |
                                                    +-----------------------------------+
                                                    |        - Menu                     |       
                                                    +-----------------------------------+                        
                                                    |   + startMenu()                   |
                                                    |   + breathingActivity()           |
                                                    |   + reflectionActivity()          |
                                                    |   + listingActivity()             |        
                                                    |                                   |   
                                                    |                                   | 
                                                    +-----------------------------------+
                                                    |       Class Menu:                 |
                                                    +-----------------------------------+
                                                    |  - activities: list of Activity   |
                                                    +-----------------------------------+  
                                                    |       Class Activity:             |   
                                                    +-----------------------------------+
                                                    |  - name: str                      |
                                                    |  - description: str               |
                                                    |  - duration: int                  |
                                                    |                                   | 
                                                    |  + start(): None                  |   
                                                    |  + end(): None                    |   
                                                    +-----------------------------------+
                                                                    ^
                                                                    |
                                                                    |
                            +----------------------------------------+-----------------------------------+
                            |                                        |                                   |   
                            |                                        |                                   |    
            +-----------------------------+      +----------------------------------+       +-----------------------------+      
            | Class BreathingActivity     |      |   Class ReflectionActivity       |       | Class ListingActivity       | 
            |       (Activity):           |      |          (Activity):             |       |        (Activity):          |                                
            +-----------------------------+      +----------------------------------+       +-----------------------------+
            |                             |      | - starting_message()             |       | - starting_message()        |    
            | - starting_message()        |      | - prompt_duration: str           |       | - prompt_duration: str      |    
            | - prompt_dration: str       |      | - description_activity()         |       | - description_activity: str | 
            | - description activity():   |      | - questions: list of str         |       | - items: list of str        | 
            |                             |      |                                  |       |                             |  
            | - Finishing_message()       |      | - Fnishing massage ()            |       | + Finishing message():      | 
            | + displayAnimation(): None  |      | + displayAnimation(): None       |       | + displayAnimation(): None  |                                             
            +-----------------------------+      +----------------------------------+       +-----------------------------+

*/