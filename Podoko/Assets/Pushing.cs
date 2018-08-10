using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pushing : MonoBehaviour {

    [SerializeField] float pushPower = 2;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag== "Player")
        {
            collision.GetComponent<characterController2D>().fly(pushPower);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<characterController2D>().stopFlying();
        }
    }
}
