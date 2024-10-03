using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security;

// Example usage:
public class Program
{
    public static void Main()
    {
        int numPlayers = 3;
        int numDecks = 1;
        BlackjackGame bj = new BlackjackGame(numPlayers,numDecks);
        bj.StartBlackjackGame(numPlayers,numDecks); 

        // Testing Functionality ... 
        Deck deck = new Deck();
        deck.Show();
        deck.Shuffle();
        Console.WriteLine(" ... Shuffled Deck ..."); 
        deck.Show();
        Console.WriteLine(" ");

        // Now it is time to Play some Blackjack:
        bj.StartBlackjackGame(numPlayers,numDecks);

    }



}
