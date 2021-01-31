namespace Rogue

module RogueDomain =
    type PlayerName = PlayerName of string

    type GetPlayerName = unit -> PlayerName

module Console =
    open System

    let clear () = Console.Clear()

    let readKey () = Console.ReadKey()

    let readLine () = Console.ReadLine()

    let setWindowSize w h = Console.SetWindowSize(w, h)

    let writeAt x y (m: string) =
        Console.SetCursorPosition(x, y)
        Console.Write(m)

module String =
    let substring startIndex length (x: string) =
        if (x.Length > startIndex + length) then
            x.Substring(startIndex, length)
        else
            x

module RogueImplementation =
    open RogueDomain

    let getPlayerName () =
        Console.clear ()
        Console.writeAt 0 1 "WorkingTitle, Copyright 2021"
        Console.writeAt 9 2 "By Andrew Grant"
        Console.writeAt 9 3 "Version 0"
        Console.writeAt 9 4 "See license for details"
        Console.writeAt 0 7 "Who are you? "

        Console.readLine ()
        |> String.substring 0 30
        |> PlayerName

module Main =
    open RogueImplementation

    [<EntryPoint>]
    let main _ =
        Console.setWindowSize 80 25
        getPlayerName () |> ignore
        0
