namespace BridgeCalculator

module ScoreTraveller = 
    let scoreEntry travellerEntry = 
        ()

    let getAvg side = ()

    let score traveller =
        let nsAvg = 
            traveller.Entries
            |> List.map(fun e -> e.Result)
            |> List.map(fun e -> e.DeclaredContract.Declarer, ScoreContract.score)

        ()