using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinBehavior : MonoBehaviour {

    [SerializeField] bool isRed;

    StageManager stage;

    private void Start()
    {
        stage = StageManager.Instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (isRed)
            {
                stage.addRedCoin();                
            }
            else
            {
                stage.addCoin();
            }
            this.gameObject.SetActive(false);
        }
    }
}
