using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawSystem : MonoBehaviour
{
    public GameObject TrainCarCard;
    public GameObject DestinationCard;

    public GameObject Player1Area;
    public GameObject Player2Area;

    private GameObject FaceUpCardsGrid;
    private List<GameObject> faceUpCards = new List<GameObject>();


    private void Start()
    {
        InitialCardsDraw();
        DrawNewFaceUpCards();
    }

    public void InitialCardsDraw()
    {
        for (var i = 0; i < 4; i++)
        {
            GameObject player1Card = Instantiate(TrainCarCard, new Vector3(0, 0, 0), Quaternion.identity);
            player1Card.transform.SetParent(Player1Area.transform, false);

            GameObject player2Card = Instantiate(TrainCarCard, new Vector3(0, 0, 0), Quaternion.identity);
            player2Card.transform.SetParent(Player2Area.transform, false);

        }
    }

    public void DrawCardOnClick()
    {



        GameObject player1Card = Instantiate(TrainCarCard, new Vector3(0, 0, 0), Quaternion.identity);
        player1Card.transform.SetParent(Player1Area.transform, false);

        GameObject player2Card = Instantiate(TrainCarCard, new Vector3(0, 0, 0), Quaternion.identity);
        player2Card.transform.SetParent(Player2Area.transform, false);


    }

    public void DrawNewFaceUpCards()
    {
        ClearFaceUpCardsGrid();

        for (int i = 0; i < 5; i++)
        {
            GameObject newCard = Instantiate(TrainCarCard, new Vector3(0, 0, 0), Quaternion.identity);
            newCard.transform.SetParent(FaceUpCardsGrid.transform, false);
            faceUpCards.Add(newCard);
        }
    }

    private void ClearFaceUpCardsGrid()
    {
        foreach (Transform child in FaceUpCardsGrid.transform)
        {
            Destroy(child.gameObject);
        }
        faceUpCards.Clear();
    }

    private void DiscardAllFaceUpCards()
    {
        ClearFaceUpCardsGrid();

    }

    public void OnClick()
    {
        InitialCardsDraw();
        DrawNewFaceUpCards();
    }


}