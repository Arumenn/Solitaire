using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card {

    public int value;
    public CardColors color;
    public bool flipped; //switch to true if visible

    public Card(int v, CardColors c) {
        value = v;
        color = c;
        flipped = false;
    }

    override public string ToString() {
        string n;
        n = value + " of ";
        switch (color) {
            case CardColors.SPADE:
                n = n + "Spades";
                break;
            case CardColors.DIAMOND:
                n = n + "Diamonds";
                break;
            case CardColors.HEART:
                n = n + "Hearts";
                break;
            case CardColors.CLUB:
                n = n + "Clubs";
                break;
        }
        return n;
    }
}

public enum CardColors { SPADE, DIAMOND, HEART, CLUB }
