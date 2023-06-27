using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class TrainCarCardManager : MonoBehaviour
{
    public bool IsLocomotive { get; set; }

    private string cardRoute;

    private int[] points;

    public string trainCarName { get; private set; }
    public int trainCarColor { get; private set; }


    public TrainCarCardManager(string CardRoute, int[] Points)
    {
        CardRoute = cardRoute;
        Points = points;

    }



    public void TrainCarCard(string TrainCarName, int TrainCarColor)
    {
        trainCarName = TrainCarName;
        trainCarColor = TrainCarColor;
    }
}