// -----------------------------
// SECTION 1: Define the Model
// -----------------------------

// Define the Coach record
type Coach = {
    Name: string
    FormerPlayer: bool
}

// Define the Stats record
type Stats = {
    Wins: int
    Losses: int
}

// Define the Team record
type Team = {
    Name: string
    Coach: Coach
    Stats: Stats
}

// ----------------------------------
// SECTION 2: Create a List of 5 Teams
// ----------------------------------

// Based on ESPN and Wikipedia sources as of 2025

let team1 = {
    Name = "Boston Celtics"
    Coach = { Name = "Joe Mazzulla"; FormerPlayer = true }
    Stats = { Wins = 61; Losses = 21 }
}

let team2 = {
    Name = "Golden State Warriors"
    Coach = { Name = "Steve Kerr"; FormerPlayer = true }
    Stats = { Wins = 48; Losses = 34 }
}

let team3 = {
    Name = "Indiana Pacers"
    Coach = { Name = "Rick Carlisle"; FormerPlayer = true }
    Stats = { Wins = 50; Losses = 32 }
}

let team4 = {
    Name = "Miami Heat"
    Coach = { Name = "Erik Spoelstra"; FormerPlayer = false }
    Stats = { Wins = 37; Losses = 45 }
}

let team5 = {
    Name = "Los Angeles Lakers"
    Coach = { Name = "JJ Redick"; FormerPlayer = false }
    Stats = { Wins = 50; Losses = 32 }
}

// Combine all 5 teams into a list
let nbaTeams = [ team1; team2; team3; team4; team5 ]

// ----------------------------------
// SECTION 3: Filtering the List
// ----------------------------------

// Filter teams with more wins than losses
let successfulTeams =
    nbaTeams
    |> List.filter (fun team -> team.Stats.Wins > team.Stats.Losses)

// ----------------------------------
// SECTION 4: Mapping the List
// ----------------------------------

// Map each team to its success percentage
let successPercentages =
    nbaTeams
    |> List.map (fun team ->
        let wins = float team.Stats.Wins
        let total = float (team.Stats.Wins + team.Stats.Losses)
        let percentage = (wins / total) * 100.0
        (team.Name, percentage)
    )

// ----------------------------------
// SECTION 5: Print Output
// ----------------------------------

// Print list of successful teams
printfn " Successful Teams:"
successfulTeams |> List.iter (fun team -> printfn "- %s" team.Name)

// Print each team's success percentage
printfn "\n Team Success Percentages:"
successPercentages
|> List.iter (fun (name, percent) ->
    printfn "- %s: %.2f%%" name percent
)
