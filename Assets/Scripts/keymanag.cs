using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keymanag : MonoBehaviour
{
    private bool canPickup;
    public bool hasKey = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canPickup && Input.GetKeyDown(KeyCode.Space))
            PickUp();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            canPickup = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            canPickup = false;
        }
    }

    public void PickUp()
    {

        hasKey = true;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }
}
