using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomScript : MonoBehaviour
{
    [Header("Possible Exits")] //do these needs to be public? probably. either that or have used vars
    [SerializeField] bool isNorthOpen = false;
    [SerializeField] bool isEastOpen = false;
    [SerializeField] bool isSouthOpen = false;
    [SerializeField] bool isWestOpen = false;
    [Header("Is Exit In Use")] //maybe make a set method then protect these.
    public bool isNorthUsed = false;
    public bool isEastUsed = false;
    public bool isSouthUsed = false;
    public bool isWestUsed = false;
    //possibly each room needs coordinates

    // Start is called before the first frame update
    void Start()
    {
        //This makes it so the code thinks that any exits that dont exist are used, IE ignores them. May be best to change this in the future
        if (!isNorthOpen) isNorthUsed = true;
        if (!isEastOpen) isEastUsed = true;
        if (!isSouthOpen) isSouthUsed = true;
        if (!isWestOpen) isWestUsed = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
