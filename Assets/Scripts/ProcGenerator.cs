using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ProcGenerator : MonoBehaviour //TODO List: How do i decided to deal with "is opening used or not?" and "is there an opening", perhaps start with randomly placing in grid
{
    [Header("# of Rooms")]
    [Range(0, 50)] //square values? remove alltogether?
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

    private List<GameObject> prefabRooms = new List<GameObject>(); //list of the prefab objects
    private List<RoomScript> roomList = new List<RoomScript>(); //list of the scripts ON the prefab objects, this is used for logic
    //how do I do coordinates for these?

    // Start is called before the first frame update
    void Start()
    {
        GenerateMap();
    }

    // Update is called once per frame
    void Update() //check all 4 adjacent tiles, if there is something there, don't place something new, if there isn't AND there is access, Do, once done, move onto the next tile, repeat until done.
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateMap();
        }
    }

    //the map cannot have gaps, there cannot be more exits than entrances, IE # of exits must be be a multiple of 2
    public void GenerateMap() //HOW do I make logic to decide how many of each room is used?
    {
        prefabRooms.Add(Instantiate(fourWay)); //this is ground zero, roomList's first item is ALWAYS the starting point/0,0,0
        
        //foreach (GameObject room in prefabRooms) //this gives me access to a list of every single rooms script (IE, what is/isn't used)
        //{
        //    roomList.Add(room.GetComponent<RoomScript>());
        //}

        //the 4 sides around 0,0,0 will always be open, but make the algorithm here anyway

        while (prefabRooms.Count < roomCount) //adds rooms upto room limit
        {
            prefabRooms.Add(Instantiate(fourWay));
        }

        foreach (GameObject room in prefabRooms) //this gives me access to a list of every single rooms script (IE, what is/isn't used)
        {
            roomList.Add(room.GetComponent<RoomScript>());
        }

        Debug.Log(roomList.Count); //works
    }
}
