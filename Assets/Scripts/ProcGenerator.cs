using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcGenerator : MonoBehaviour //TODO List: make Algorithm lmao
{
    //Below is the room prefabs
    [Header("Types of Rooms")]
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
