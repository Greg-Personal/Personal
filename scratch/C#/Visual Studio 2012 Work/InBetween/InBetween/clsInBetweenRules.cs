using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cards;

class clsInBetweenRules
{
    // Symbolic Constants
    const int TIE = 0;
    const int PLAYERWINS = 1;
    const int DEALERWINS = 2;

    // Static Members

    // Instance Members
    private int balance;
    private int wager;
    private int lowCard;
    private int lowCardIndex;
    private int hiCard;
    private int hicardIndex;
    private int dealtCard;
    private int dealtCardIndex;

    private Deck myDeck;

    // Constructors
    public clsInBetweenRules()
    {
        balance = 100;
        wager = 10;
        myDeck = new Deck();
    }

    // Property Methods
    public int Balance
    {
        get
        {
            return balance;
        }
        set
        {
            if (value >= 0)
            {
                balance = value;
            }
        }
    }

    public int Wager
    {
        get
        {
            return wager;
        }
        set
        {
            if (value > 0)
            {
                wager = value;
            }
        }
    }

    // Helper Values
    private void SetCards(string[] hand)
    {
        int temp;

        hand[0] = myDeck.getCardPip(lowCardIndex);
        hand[1] = myDeck.getCardPip(hicardIndex);
        hand[2] = myDeck.getCardPip(dealtCardIndex);

        if (lowCard == hiCard || lowCard < hiCard)
        {
            hand[0] = myDeck.getCardPip(lowCardIndex);
            hand[1] = myDeck.getCardPip(hicardIndex);
        }
        else
        {
            temp = hiCard;
            hiCard = lowCard;
            lowCard = temp;

            temp = hicardIndex;
            hicardIndex = lowCardIndex;
            lowCardIndex = temp;
            hand[0] = myDeck.getCardPip(lowCardIndex);
            hand[1] = myDeck.getCardPip(hicardIndex);
        }
    }

    private void SetWinnerAndPosition(ref int outCome, ref int position)
    {
        if (dealtCard == lowCard)
        {
            outCome = DEALERWINS;
            position = 2;
            return;
        }
        if (dealtCard < lowCard)
        {
            outCome = DEALERWINS;
            position = 1;
            return;
        }
        if (dealtCard > lowCard && dealtCard < hiCard)
        {
            outCome = PLAYERWINS;
            position = 3;
            return;
        }
        if (dealtCard == hiCard)
        {
            outCome = DEALERWINS;
            position = 4;
            return;
        }
        if (dealtCard > hiCard)
        {
            outCome = DEALERWINS;
            position = 5;
            return;
        }
    }

    // General Methods
    public void getFirstCard()
    {
        lowCardIndex = myDeck.getOneCard();
        lowCard = lowCardIndex % 13;
        if (lowCard == 0)
        {
            lowCard = 13;
        }
    }

    public void getSecondCard()
    {
        hicardIndex = myDeck.getOneCard();
        hiCard = hicardIndex % 13;
        if (hiCard == 0)
        {
            hiCard = 13;
        }
    }

    public void getDealtCard()
    {
        dealtCardIndex = myDeck.getOneCard();
        dealtCard = dealtCardIndex % 13;
        if (hiCard == 0)
        {
            hiCard = 13;
        }
    }

    public void Shuffle()
    {
        myDeck.ShuffleDeck();
    }

    public int getCardsLeft()
    {
        return myDeck.getCardsLeftInDeck();
    }

    public void DealHand(string[] hand, ref int outCome, ref int position)
    {
        getFirstCard();
        getSecondCard();
        getDealtCard();
        SetCards(hand);
        SetWinnerAndPosition(ref outCome, ref position);
    }
}
