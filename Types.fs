namespace BridgeCalculator

[<AutoOpen>]
module Types =
    type Position = 
        | North 
        | South
        | East
        | West

    type Suit = C | D | H | S | NT

    type Double = N | X | XX

    //type ImmediateBonus
   
    type Contract =
        {
            Declarer : Position
            DeclaredSuit : Suit
            DeclaredTricks : int
            Vulnerable : bool
            Doubled : Double
        }

    type HandResult =
        {
            DeclaredContract : Contract
            Tricks : int
        }

    type Pair = 
        {
            Id : int
            PlayerNames : string * string
        }

    type TravellerEntry =
        {
            NSPair : Pair
            EWPair : Pair
            Result : HandResult
        }

    type TravellerEntryScored =
        {
            NSPair: Pair
            EWPair: Pair
            NSPointResult : int
            EWPointResult : int
        }

    type Traveller = 
        {
            BoardNumber : int
            Entries: TravellerEntry list
        }
