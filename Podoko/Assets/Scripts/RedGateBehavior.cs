using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGateBehavior : MonoBehaviour {
    
    StageManager stage;
    SimpleAnimation2D anim;
    bool isOpen = false;
    int redCoinsLeftBuffer =5;

   
    void Start()
    {
        stage = StageManager.Instance;
        anim = gameObject.GetComponent<SimpleAnimation2D>();        
    }
    void ChangeRedGateState()
    {
        if(stage.RedGateState())
        {
            anim.toggleAnimSet();
            anim.toggleBucle();            
        }
        else
        {
            anim.swapAnimFrames(1, Mathf.Clamp(6 - stage.RedCoinsLeft, 1, 5));
        }

    }

    private void Update()
    {
        if (anim.AnimEnded)
            this.gameObject.SetActive(false);

        if (redCoinsLeftBuffer > stage.RedCoinsLeft)
        {
            ChangeRedGateState();
            redCoinsLeftBuffer = stage.RedCoinsLeft;
        }
    }



}
