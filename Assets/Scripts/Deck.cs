using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck {

    public List<Card> cards;

	// Use this for initialization
	public Deck() {
        cards = new List<Card>();
        GenerateCards();
        ShuffleCards();
	}
	
	void GenerateCards() {
        Debug.Log("Generating a new deck");
        Card nCard;
        int i = 0;
        for (int iColor = 0; iColor < 4; iColor++) {
            for (int iValue = 1; iValue < 13; iValue++) {
                nCard = new Card(iValue, (CardColors)iColor);
                cards.Add(nCard);
                i++;
            }
        }
    }

    void ShuffleCards() {
        Debug.Log("Everyday I'm shuffling");
        Random rng = new Random();
        int k;
        Card tmp;
        for (int i = cards.Count - 1; i > 0; i--) { 
            k = Random.Range(0, i);
            tmp = cards[i];
            //permutes
            cards[i] = cards[k];
            cards[k] = tmp;
        }
    }

    public int cardsLeft() {
        return cards.Count;
    }

    public List<Card> getNext(int howMany) {
        List<Card> backup = new List<Card>();
        List<Card> hand = new List<Card>();

        for (int i = 0; i < cards.Count; i++) {
            if (i < howMany) {
                hand.Add(cards[i]);
            } else {
                backup.Add(cards[i]);
            }
        }
        cards = backup;
        Debug.Log("Got " + hand.Count + " cards from deck");
        return hand;
    }

    public void putBack(List<Card> leftovers) {
        foreach (Card c in leftovers) {
            cards.Add(c);
        }
        Debug.Log("Put back " + leftovers.Count + " cards in deck");
    }
}
