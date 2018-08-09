using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBounds : MonoBehaviour {

    [SerializeField] GameObject pairedBound;
    [SerializeField] bool isHorizontalBound;
    [SerializeField] float offset;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (isHorizontalBound)
            {
                collision.transform.position = new Vector3(collision.transform.position.x, pairedBound.transform.position.y + offset, collision.transform.position.z);
            }
            else
            {
                collision.transform.position = new Vector3(pairedBound.transform.position.x + offset, collision.transform.position.y,  collision.transform.position.z);
            }

        }
    }

}
