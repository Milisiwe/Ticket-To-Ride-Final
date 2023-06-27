using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class DestinationCardManager
{
    public string destinationTicket;
    public int destinationPoints;

    public void DestinationCard()
    {

    }


    public void DestinationCard(string DestinationTicket, int DestinationPoints)
    {
        destinationTicket = DestinationTicket;
        destinationPoints = DestinationPoints;
    }
}