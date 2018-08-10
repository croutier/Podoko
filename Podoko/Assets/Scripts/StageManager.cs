using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour {

    [SerializeField] string nextSceneName;
    [SerializeField] int coinsNedded;
    [SerializeField] int redCoinsNedded;

    
    bool gateOpen = false;
    bool redGateOpen = false;
    int coinsLeft;
    int redCoinsLeft;
    public int RedCoinsLeft { get { return redCoinsLeft; } }

    

    static private StageManager instance = null;
    static public StageManager Instance { get { return instance; } }

    
    private void Awake()
    {
        instance = this;        
    }
    private void Start()
    {
        coinsLeft = coinsNedded;
        redCoinsLeft = redCoinsNedded;
    }

    public void addCoin()
    {
        coinsLeft--;
        if(coinsLeft <= 0)
        {
            gateOpen = true;
        }
    }

    public void addRedCoin()
    {
        redCoinsLeft--;
        if (redCoinsLeft <= 0)
        {
            redGateOpen = true;
        }
    }

    public bool GateState()
    {
        return gateOpen;
    }
    public bool RedGateState()
    {
        return redGateOpen;
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(nextSceneName);
    }

}
