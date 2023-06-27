using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoutesDatabase : MonoBehaviour
{
    [SerializeField]
    public string routeTypes;
    public int routeLengths;
    public int routeLengthPoint;

    public static List<string> routeType = new List<string>();
    public static List<string> routes = new List<string>();
    public static List<int> routeLength = new List<int>();
    public static List<int> routeLengthPoints = new List<int>();

    private void Awake()
    {
        routeType.Add("Box");
        routeType.Add("Caboose");
        routeType.Add("Coal");
        routeType.Add("Freight");
        routeType.Add("Hopper");
        routeType.Add("Locomotive");
        routeType.Add("Passenger");
        routeType.Add("Reefer");
        routeType.Add("Tanker");
        routeType.Add("Empty");

        routes.Add("Vancouver to Calgary");
        routes.Add("Vancouver to Seattle");
        routes.Add("Vancouver to Seattle");
        routes.Add("Seattle to Portland");
        routes.Add("Seattle to Portland");
        routes.Add("Seattle Calgary");
        routes.Add("Calgary to Helena");
        routes.Add("Seattle to Helena");
        routes.Add("Calgary to Winnipeg");
        routes.Add("Winnipeg to Helena");
        routes.Add("Portland to  Salt lake City");
        routes.Add("Salt Lake City to Helena");
        routes.Add("Helena to Denver");
        routes.Add("Helena to Omaha");
        routes.Add("Helena to Duluth");
        routes.Add("Portland to San Francisco");
        routes.Add("Portland to San Francisco");
        routes.Add("San Francisco to Salt Lake City");
        routes.Add("San Francisco to Salt Lake City");
        routes.Add("Salt Lake City to Denver");
        routes.Add("Salt Lake City to Denver");
        routes.Add("Salt Lake City to Las Vegas");
        routes.Add("Las Vegas to Los Angeles");
        routes.Add("San Francisco to Los Angeles");
        routes.Add("San Francisco to Los Angeles");
        routes.Add("Los Angeles to Phoenix");
        routes.Add("Los Angeles to El Paso");
        routes.Add("Phoenix to El Paso");
        routes.Add("Phoenix to Santa Fe");
        routes.Add("Phoenix to Denver");
        routes.Add("Denver to Omaha");
        routes.Add("Denver to Kansas City");
        routes.Add("Denver to Kansas City");
        routes.Add("Denver to Oklahoma City");
        routes.Add("Denver to Santa Fe");
        routes.Add("Santa Fe to Oklahoma City");
        routes.Add("Santa Fe to El Paso");
        routes.Add("El Paso to Houston");
        routes.Add("El Paso to Dallas");
        routes.Add("El Paso to Oklahoma City");
        routes.Add("Houston to New Orleans");
        routes.Add("Houston to Dallas");
        routes.Add("Houston to Dallas");
        routes.Add("Dallas to Little Rock");
        routes.Add("Oklahoma City to Dallas");
        routes.Add("Oklahoma City to Dallas");
        routes.Add("Oklahoma City to Little Rock");
        routes.Add("Little Rock to New Orleans");
        routes.Add("New Orleans to Miami");
        routes.Add("Miami to Atlanta");
        routes.Add("New Orleans to Atlanta");
        routes.Add("New Orleans to Atlanta");
        routes.Add("Atlanta to Charleston");
        routes.Add("Miami to Charlston");
        routes.Add("Charleston to Raleigh");
        routes.Add("Atlanta to Raleigh");
        routes.Add("Atlanta to Raleigh");
        routes.Add("Atlanta to Nashville");
        routes.Add("Nashville to Raleigh");
        routes.Add("Nashville to Pittsburgh");
        routes.Add("Saint Louis to Chicago");
        routes.Add("Saint Louis to Chicago");
        routes.Add("Chicago to Pittsburgh");
        routes.Add("Chicago to Pittsburgh");
        routes.Add("Washington ton New York");
        routes.Add("Washington to New York");
        routes.Add("New York to Boston");
        routes.Add("New York to Boston");
        routes.Add("Pittsburgh to Toronto");
        routes.Add("Chicago to Toronto");
        routes.Add("Montreal to Toronto");
        routes.Add("Montreal to Boston");
        routes.Add("Montreal to Boston");
        routes.Add("Sault St. Marie to Montreal");
        routes.Add("Sault St. Marie to Toronto");
        routes.Add("Chicago to Duluth");
        routes.Add("Chicago to Omaha");
        routes.Add("Duluth to Toronto");
        routes.Add("Duluth to Sault St. Marie");
        routes.Add("Winnipeg to Sault St. Marie");
        routes.Add("Winnipeg to Duluth");
        routes.Add("Duluth to Omaha");
        routes.Add("Duluth to Omaha");
        routes.Add("Little Rock to Nashville");
        routes.Add("Saint Louis to Nashville");
        routes.Add("Little Rock to Saint Louis");
        routes.Add("Kansas City to Saint Louis");
        routes.Add("Kansas City to Saint Louis");
        routes.Add("Kansas City to Omaha");
        routes.Add("Kansas City to Omaha");
        routes.Add("Oklahoma City to Kansas City");
        routes.Add("Oklahoma City to Kansas City");
        routes.Add("Saint Louis to Pittsburgh");
        routes.Add("Pittsburgh to Washington");
        routes.Add("Pittsburgh to Raleigh");
        routes.Add("Raleigh to Washington");
        routes.Add("Raleigh to washington");
        routes.Add("Pittsburgh to New York");
        routes.Add("Pittsburgh to New York");
        routes.Add("Montreal to New York");

        routeLength.Add(1);
        routeLength.Add(2);
        routeLength.Add(3);
        routeLength.Add(4);
        routeLength.Add(5);
        routeLength.Add(6);

        routeLengthPoints.Add(1);
        routeLengthPoints.Add(2);
        routeLengthPoints.Add(4);
        routeLengthPoints.Add(7);
        routeLengthPoints.Add(10);
        routeLengthPoints.Add(15);


    }


}
