/*

    Project 1

+---------------------------+
|        Video              |
+---------------------------+
| - title: string           |
| - author: string          |
| - length: int             |
| - comments: List<Comment> |
+--------------------------------------+
| + GetNumberOfComments(): int         |
| + AddComment(comment: Comment): void |
| + DisplayInfo(): void                |
+--------------------------------------+
                |
+------------------------+
|       Comment          |
+------------------------+
| - commenter: string    |
| - text: string         |
+--------------------------+
| + GetCommenter(): string |
| + GetText(): string      |
+--------------------------+



Project 2

+---------------------------+
|           Order           |
+---------------------------+
| - customer: Customer      |
| - products: List<Product> |
+-----------------------------------+
| + CalculateTotalCost(): decimal   |
| + GeneratePackingLabel(): string  |
| + GenerateShippingLabel(): string |
+-----------------------------------+
                |
+-----------------------------+
|           Product           |
+-----------------------------+
| - name: string              |
| - productId: int            |
| - price: decimal            |
| - quantity: int             |
+-----------------------------+
| + CalculatePrice(): decimal |
+-----------------------------+
            |
+-------------------------+
|        Customer         |
+-------------------------+
| - name: string          |
| - address: Address      |
+-------------------------+
| + IsUSACustomer(): bool |
+-------------------------+
            |
+----------------------------+
|           Address          |
+----------------------------+
| - street: string           |
| - city: string             |
| - stateProvince: string    |
| - country: string          |
+----------------------------+
| + IsUSAAddress(): bool     |
| + GetFullAddress(): string |
+----------------------------+


Project 3

+-----------------------+
|          Event        |
+-----------------------+
| - title: string       |
| - description: string |
| - date: DateTime      |
| - time: TimeSpan      |
| - address: Address    |
+-----------------------------------+
| + GetStandardDetails(): string    |
| + GetFullDetails(): string        |
| + GetShortDescription(): string   |
+-----------------------------------+
            ^
            |
            |
+-----------------------+
|       Lecture         |
+-----------------------+
| - speaker: string     |
| - capacity: int       |
+----------------------------+
| + GetFullDetails(): string |
+----------------------------+
                ^
                |
                |
+----------------------------+
|       Reception            |
+----------------------------+
| - rsvpEmail: string        |
+----------------------------+
| + GetFullDetails(): string |
+----------------------------+
                ^
                |
                |
+----------------------------+
|   OutdoorGathering         |
+----------------------------+
| - weatherForecast: string  |
+----------------------------+
| + GetFullDetails(): string |
+----------------------------+
            |
+-----------------------+
|       Address         |
+-----------------------+
| - street: string      |
| - city: string        |
| - state: string       |
| - country: string     |
+----------------------------+
| + GetFullAddress(): string |
+----------------------------+


Project 4

+-------------------------+
|           Activity      |
+-------------------------+
| - date: DateTime        |
| - length: int           |
+-------------------------+
| + GetDistance(): double |
| + GetSpeed(): double    |
| + GetPace(): double     |
| + GetSummary(): string  |
+-------------------------+
            ^
            |
            |
+-------------------------+
|        Running          |
+-------------------------+
| - distance: double      |
+-------------------------+
| + GetDistance(): double |
| + GetSpeed(): double    |
| + GetPace(): double     |
| + GetSummary(): string  |
+-------------------------+
            ^
            |
            |
+-------------------------+
|     StationaryBike      |
+-------------------------+
| - speed: double         |
+-------------------------+
| + GetDistance(): double |
| + GetSpeed(): double    |
| + GetPace(): double     |
| + GetSummary(): string  |
+-------------------------+
            ^
            |
            |
+-------------------------+
|       Swimming          |
+-------------------------+
| - laps: int             |
+-------------------------+
| + GetDistance(): double |
| + GetSpeed(): double    |
| + GetPace(): double     |
| + GetSummary(): string  |
+-------------------------+

*/