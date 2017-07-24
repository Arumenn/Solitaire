using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pile {

    public int pileColumn; //1 to 7
    public List<Card> cardsInPile; //0 is vertically higher, but considered the most below card
    public bool isFoundation = false; //for the 4 piles of foundation

	// Use this for initialization
	public Pile() {
        cardsInPile = new List<Card>(); //just to be safe
	}
	
    public Card flipTopCard() {
        Card c = cardsInPile[cardsInPile.Count-1];
        c.flipped = true;
        cardsInPile[cardsInPile.Count-1] = c;
        Debug.Log("Flipped " + c.ToString() + " from pile " + pileColumn);
        return c;
    }
}
