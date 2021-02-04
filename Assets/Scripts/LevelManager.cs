using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public switchh switchh;
    public keymanag keymanag;
    public GameObject door;
    private void Awake()
    {
        // set the instance property/variable to this object
        instance = this;

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor()
    {
        if (keymanag.hasKey == true) 
        {
            Debug.Log("Someone entered the switch trigger");
            door.GetComponent<SpriteRenderer>().enabled = false;
            door.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
