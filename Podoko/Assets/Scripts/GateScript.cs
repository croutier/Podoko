using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour {

    StageManager stage;
    bool isOpen = false;

	// Use this for initialization
	void Start () {
        stage = StageManager.Instance;
	}
	
	// Update is called once per frame
	void Update () {
        if (stage.GateState()&&!isOpen)
        {           
            gameObject.GetComponent<SimpleAnimation2D>().togleAnimSet();
            isOpen = true;
        }

	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (isOpen)
            {
                stage.NextLevel();
            }
        }
    }
}
