using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

    public GameObject bomb;
    public GameObject pill;
    public GameObject pillInventory;
    public GameObject gameoverScreen;
    public float onesec = 1f;
    float countdown;

	// Use this for initialization
	void Start () {
        gameoverScreen.SetActive(false);
        pillInventory.SetActive(false);
        countdown = onesec;

	}
	
	// Update is called once per frame
	void Update () {
		if(bomb.activeInHierarchy == false)
        {
            Debug.Log("Lose");
            countdown -= Time.deltaTime;
            if (countdown <= 0)
            {
                gameoverScreen.SetActive(true);
            }
        }
        if(pill.activeInHierarchy == false)
        {
            pillInventory.SetActive(true);
        }
	}
}
