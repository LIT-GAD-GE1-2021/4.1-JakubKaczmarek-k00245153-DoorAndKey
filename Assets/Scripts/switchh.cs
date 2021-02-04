using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class switchh: MonoBehaviour
{ 
    private bool switchOff = true;
    private bool switchEnabled = false;
    public LevelManager LevelManager;

    void Awake()
    {
        turnOff();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && switchEnabled)
        {
            turnOn();
        }
    }

    public void turnOn()
    {
        switchOff = false;
        LevelManager.OpenDoor();
    }

    public void turnOff()
    {
        switchOff = true;
    }

    public void enableSwitch()
    {
        switchEnabled = true;
    }

    public void disableSwitch()
    {
        switchEnabled = false;
    }

    public void toggleSwitch()
    {
        if (switchEnabled == true)
        {
            switchOff = !switchOff;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        this.enableSwitch();
    }

    void OnTriggerExit2D(Collider2D other)
    {
        this.disableSwitch();
    }

}
