using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Deck mainDeck;
    public List<Pile> piles;
    public List<Pile> foundations;

	// Use this for initialization
	void Start () {
        InitializeGameBoard();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InitializeGameBoard() {
        Debug.Log("Initializing Game Board...");
        mainDeck = new Deck();
        piles = new List<Pile>();
        foundations = new List<Pile>();
        Pile p;
        for (int i = 1; i < 8; i++) {
            Debug.Log("Building pile..." + i);
            p = new Pile();
            p.pileColumn = i;
            p.isFoundation = false;
            //adds as much cards in pile as is the pile's column
            p.cardsInPile = mainDeck.getNext(i);
            p.flipTopCard();
            piles.Add(p);
        }
        Debug.Log("Initialization complete.");
    }
}
