using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;
using System.Security;


public class Hand
{
    public string? Name {get; set; }
    public virtual List<Card> Cards { get; set; } = new List<Card>();


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
    public Hand(string Name, int numCards, Deck deck)
    {
        this.Name = Name;
        Cards = deck.Deal(numCards);
    }
    #endregion

    # region Methods
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
    public virtual bool Contains(string suitOrRank)
    {
        foreach (var card in Cards)
        {
            if (string.Equals(card.Rank.ToLower(),suitOrRank.ToLower())) // If same rank is true
            return true; 
            if (string.Equals(card.Suit.ToLower(),suitOrRank.ToLower())) // If same suit is true
            return true; 
        }
        return false; 
    }
    public virtual bool Contains(Card cardToMatch)
    {
        foreach (var card in Cards)
        {
            if (string.Equals(card.Rank.ToLower(),cardToMatch.Rank.ToLower()) && string.Equals(card.Suit.ToLower(),cardToMatch.Suit.ToLower()))
            return true; 
        }
        return false; 
    }
    public virtual int Count(string suitOrRank)
    {
        int count = 0;
        foreach (var card in Cards)
        {
            if (string.Equals(card.Rank.ToLower(),suitOrRank.ToLower())) // If same rank is true
                { count += 1; }
            if (string.Equals(card.Suit.ToLower(),suitOrRank.ToLower())) // If same suit is true
                { count += 1; } 
        }     
        return count;    
    }
        public virtual int Count(Card cardToMatch)
    {
        int count = 0;
        foreach (var card in Cards)
        {
            if (string.Equals(card.Rank.ToLower(),cardToMatch.Rank.ToLower()) && string.Equals(card.Suit.ToLower(),cardToMatch.Suit.ToLower()))
            { count += 1; }
        }
        return count; 
    }
    public virtual int GetValue()
    {
        int handValue = 0;
        foreach (var card in Cards)
        {
            handValue += card.Value;
        }
        return handValue;
    }
    #endregion

}