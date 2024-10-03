using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security;


public class Hand
{
    public string? Name {get; set; }
    public List<Card> Cards { get; set; } = new List<Card>();


    #region Contsturctors
    public Hand()
    {
        // Cards already instantiated in class attributes
    }
    public Hand(string Name)
    {
        this.Name = Name;
    }
    public Hand(int numCards, Deck deck)
    {
        Cards = deck.Deal(numCards);
    }
    #endregion
    public Hand(string Name, int numCards, Deck deck)
    {
        this.Name = Name;
        Cards = deck.Deal(numCards);
    }

    public void Add(List<Card> dealtCards)
    {
        foreach (Card card in dealtCards)
        {
            Cards.Add(card);
        }
    }
    public void Show()
    {
        int n = 0;
        foreach (var card in Cards)
        {
            if (n == Cards.Count()-1) { Console.WriteLine(card.Rank[0] + Card.SuitUnicode[card.Suit]); break; }
            Console.Write(card.Rank[0] + Card.SuitUnicode[card.Suit] + ", ");
            n++; 
            //Console.WriteLine(card.Rank[0] + SuitUnicode[card.Suit]); 
        }
    }

    public void ShowTop()
    {
        Card card = Cards[Cards.Count()-1];
        Console.WriteLine(card.Rank[0] + Card.SuitUnicode[card.Suit]);
    }

}