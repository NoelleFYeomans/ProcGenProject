using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ProcGenerator : MonoBehaviour //TODO List: How do i decided to deal with "is opening used or not?" and "is there an opening", perhaps start with randomly placing in grid
{
    [Header("# of Rooms")]
    [Range(0, 50)] //keep to 25 for now //0,0 should always be a 4 way //how do i decided the amount of each room there is?
    public int roomCount;

    //int[,] map;

    //Below is the room prefabs //yes I'm aware I only needed 1 three way, 1 two way, 1 dead end, and 1 corner, I just did it this way to make it easier to read/work with
    [Header("Four Way Room")]
    public GameObject fourWay;
    [Header("Three Way Rooms")]
    public GameObject threeWayNES;
    public GameObject threeWayESW;
    public GameObject threeWaySWN;
    public GameObject threeWayWNE;
    [Header("Two Way Rooms")]
    public GameObject twoWayNS;
    public GameObject twoWayEW;
    [Header("Dead Ends")]
    public GameObject oneWayN;
    public GameObject oneWayE;
    public GameObject oneWayS;
    public GameObject oneWayW;
    [Header("Corners")]
    public GameObject cornerNE;
    public GameObject cornerSE;
    public GameObject cornerSW;
    public GameObject cornerNW;

    private List<Room> roomList = new List<Room>(); //foreach gameobject type?

    // Start is called before the first frame update
    void Start()
    {
        GenerateMap();
        DrawMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DrawMap()
    {

    }
    //the map cannot have gaps, there cannot be more exits than entrances
    public void GenerateMap()
    {
        for (int i = 0; i < roomCount; i++)
        {
            //Instantiate(); //object, position(vec3) // instantiate object, attach room script, add to room list
        }
    }
}

public class Room //will be used for handling each prefab cube, like attach this script to a cube on instantiation?
{
    //bools, per rooom, that indicate if a side is opened or not
    bool northOpen;
    bool eastOpen;
    bool southOpen;
    bool westOpen;
}
