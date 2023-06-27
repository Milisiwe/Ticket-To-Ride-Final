using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class IListExtensions
{
    public static void Shuffle<T>(this IList<T> list, System.Random rng)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }

    }
}

public class CardDatabase : MonoBehaviour
{
    [SerializeField]
    public static List<TrainCarCard> trainCarList = new List<TrainCarCard>();
    public static List<DestinationCard> destinationTicketList = new List<DestinationCard>();

    public List<TrainCarCardManager> trainCarDeck = new List<TrainCarCardManager>();
    public List<DestinationCardManager> destinationTicketDeck = new List<DestinationCardManager>();

    public List<TrainCarCardManager> facedUpTrainCards = new List<TrainCarCardManager>();
    public List<DestinationCardManager> facedUpDestinationTickets = new List<DestinationCardManager>();

    public TrainCarCardManager trainCarCardManager;
    public DestinationCardManager destinationCard;



    public object TrainCarColor { get; private set; }

    private void Awake()
    {
        //InitializeDecks();
        System.Random rng = new System.Random();
        trainCarDeck.Shuffle(rng);
        destinationTicketDeck.Shuffle(rng);
        InitialCardsDraw();

        trainCarList.Add(new TrainCarCard("Box Train Car", "Yellow"));
        trainCarList.Add(new TrainCarCard("Caboose Train Car", "Green"));
        trainCarList.Add(new TrainCarCard("Coal Train Car", "Red"));
        trainCarList.Add(new TrainCarCard("Freight Train Car", "Purple"));
        trainCarList.Add(new TrainCarCard("Hopper Train Car", "Black"));
        trainCarList.Add(new TrainCarCard("Tanker Train Car", "Orange"));
        trainCarList.Add(new TrainCarCard("Passenger Train Car", "Blue"));
        trainCarList.Add(new TrainCarCard("Reefer Train Car", "White"));
        trainCarList.Add(new TrainCarCard("Locomotive Train Car", "Multicolor"));

        destinationTicketList.Add(new DestinationCard("Boston to Miami", 12));
        destinationTicketList.Add(new DestinationCard("Calgary to Phoenix", 13));
        destinationTicketList.Add(new DestinationCard("Calgary to salt Lake City", 7));
        destinationTicketList.Add(new DestinationCard("Chicago to New Orleans", 7));
        destinationTicketList.Add(new DestinationCard("Chicago to Santa Fe", 9));
        destinationTicketList.Add(new DestinationCard("Dallas to New York", 11));
        destinationTicketList.Add(new DestinationCard("Denver to El Paso", 4));
        destinationTicketList.Add(new DestinationCard("Denver to Pittsburgh", 11));
        destinationTicketList.Add(new DestinationCard("Duluth to El Paso", 10));
        destinationTicketList.Add(new DestinationCard("Duluth to Houston", 8));
        destinationTicketList.Add(new DestinationCard("Helena to Los Angeles", 8));
        destinationTicketList.Add(new DestinationCard("Kansas City to Houston", 5));
        destinationTicketList.Add(new DestinationCard("Los Angeles to Chicago", 16));
        destinationTicketList.Add(new DestinationCard("Los Angeles to Miami", 20));
        destinationTicketList.Add(new DestinationCard("Los Angeles to New York", 21));
        destinationTicketList.Add(new DestinationCard("Montreal to Atlanta", 9));
        destinationTicketList.Add(new DestinationCard("Montreal to New Orleans", 13));
        destinationTicketList.Add(new DestinationCard("New York to Atlanta", 6));
        destinationTicketList.Add(new DestinationCard("Portland to Nashville", 17));
        destinationTicketList.Add(new DestinationCard("Portland to Phoenix", 11));
        destinationTicketList.Add(new DestinationCard("San Francisco to Atlanta", 17));
        destinationTicketList.Add(new DestinationCard("Sault St. Marie to Nashville", 8));
        destinationTicketList.Add(new DestinationCard("Sault St. Marie to Oklahoma City", 9));
        destinationTicketList.Add(new DestinationCard("Seattle to Los Angeles", 9));
        destinationTicketList.Add(new DestinationCard("Seattle to New York", 22));
        destinationTicketList.Add(new DestinationCard("Toronto to Miami", 10));
        destinationTicketList.Add(new DestinationCard("Vancouver to Montreal", 20));
        destinationTicketList.Add(new DestinationCard("Vancouver to Santa Fe", 13));
        destinationTicketList.Add(new DestinationCard("Winnipeg to Houston", 12));
        destinationTicketList.Add(new DestinationCard("Winnipeg to Little Rock", 11));
    }

    /*private void InitializeDecks()
    {
        for (int i = 0; i < CardRoutes.Length; i++)
        {
            destinationTicketDeck.Add(new DestinationCardManager(CardRoutes[i], Points));
        }


        for (int i = 0; i < CardRoutes.Length; i++)
        {
            trainCarDeck.Add(new TrainCarCardManager(CardRoutes[i], Points));
        }


    }*/

    private void InitialCardsDraw()
    {
        System.Random rng = new System.Random();
        for (int i = 0; i < 4; i++)
        {
            facedUpTrainCards.Add(trainCarDeck[0]);
            trainCarDeck.RemoveAt(0);

            facedUpDestinationTickets.Add(destinationTicketDeck[0]);
            destinationTicketDeck.RemoveAt(0);
        }
    }


    public class TrainCarCard
    {
        private string cardName;
        private string color;

        public TrainCarCard(string cardName, string color)
        {
            this.cardName = cardName;
            this.color = color;
        }
    }

    public class DestinationCard
    {
        public string cardName;
        public int points;

        public DestinationCard(string cardName, int points)
        {
            this.cardName = cardName;
            this.points = points;
        }
    }
}