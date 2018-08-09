using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockFallBehavior : MonoBehaviour {

    [SerializeField] float destroyTime = 5;
    SimpleAnimation2D anim;
    private void Start()
    {
        anim = gameObject.GetComponent<SimpleAnimation2D>();
        anim.PauseAnim();
        anim.timeBetwen = destroyTime / 5;        
    }
    private void Update()
    {
        if (anim.AnimEnded)
            this.gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            anim.PlayAnim();
        }
    }
}
