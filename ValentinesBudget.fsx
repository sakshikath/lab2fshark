// SECTION 1: Define the Cuisine Discriminated Union
type Cuisine =
    | Korean
    | Turkish

// SECTION 2: Define the MovieType Discriminated Union
type MovieType =
    | Regular
    | IMAX
    | DBOX
    | RegularWithSnacks
    | IMAXWithSnacks
    | DBOXWithSnacks

// SECTION 3: Define the Activity Discriminated Union
type Activity =
    | BoardGame
    | Chill
    | Movie of MovieType
    | Restaurant of Cuisine
    | LongDrive of int * float  // (distance in km, fuel rate per km)

// SECTION 4: Function to Calculate Budget for Each Activity
let calculateBudget activity =
    match activity with
    | BoardGame -> 0.0
    | Chill -> 0.0
    | Movie mt ->
        match mt with
        | Regular -> 12.0
        | IMAX -> 17.0
        | DBOX -> 20.0
        | RegularWithSnacks -> 12.0 + 5.0
        | IMAXWithSnacks -> 17.0 + 5.0
        | DBOXWithSnacks -> 20.0 + 5.0
    | Restaurant cuisine ->
        match cuisine with
        | Korean -> 70.0
        | Turkish -> 65.0
    | LongDrive (km, ratePerKm) ->
        float km * ratePerKm

// SECTION 5: Create Sample Activities
let activities = [
    BoardGame
    Chill
    Movie Regular
    Movie DBOXWithSnacks
    Restaurant Korean
    LongDrive (60, 0.20)  // updated here
]

// SECTION 6: Display Each Activity's Budget
printfn "\nValentine's Day Budget Estimates:"
activities
|> List.iter (fun act -> printfn "%A = $%.2f CAD" act (calculateBudget act))

// SECTION 7: Calculate and Display Total Cost
let totalCost =
    activities
    |> List.map calculateBudget
    |> List.sum

printfn "\nTotal Valentine's Day Budget = $%.2f CAD" totalCost
