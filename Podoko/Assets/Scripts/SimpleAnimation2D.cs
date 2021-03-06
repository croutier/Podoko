﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAnimation2D : MonoBehaviour {

    public float timeBetwen = 2.0f;
    [SerializeField] Sprite[] animSprite;
    [SerializeField] Sprite[] animSprite2;
    [SerializeField] bool bucle = false;
    [SerializeField] bool pause = false;

    
    float timer = 0;
    int currentSprite = 0;
    SpriteRenderer render;

    bool animationEnded = false;
    bool usingSecondSet;

    public bool AnimEnded{get{return animationEnded;} }

// Use this for initialization
private void Start()
    {
        render = gameObject.GetComponent<SpriteRenderer>();
        render.sprite = animSprite[0];
    }
    // Update is called once per frame
    void Update () {
        if (!pause)
        {
            if (timer >= timeBetwen)
            {
                NextSprite();
                timer = 0;
            }
                

            timer += Time.deltaTime;
        }
	}

    public void PlayAnim()
    {
        pause = false;
    }
    public void PauseAnim()
    {
        pause = true;
    }

    public void NextSprite()
    {
        currentSprite++;
        if (currentSprite < animSprite.Length)
        {
            render.sprite = animSprite[currentSprite];
        }
        else
        {            
            if (bucle)
            {
                currentSprite = 0;
                render.sprite = animSprite[currentSprite];
            }
            else
            {
                animationEnded = true;
                pause = true;
            }
        }
    }

    public void toggleBucle()
    {
        if (bucle)
            bucle = false;
        else
            bucle = true;
    }

    public void swapAnimFrames(int indexSet1,int indexSet2)
    {
        if (indexSet1 < animSprite.Length && indexSet2 < animSprite2.Length)
        {
            animSprite[indexSet1] = animSprite2[indexSet2];
        }
        else
            Debug.LogError("SimpleAnimation Error:" + gameObject.name + " cant swap frames");
            
    }



    public void toggleAnimSet()
    {
        Sprite[] temp = animSprite;
        animSprite = animSprite2;
        animSprite2 = temp;
    }
}
