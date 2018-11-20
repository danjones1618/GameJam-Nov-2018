using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

    public GameObject bomb;
    public GameObject bombEffect;
    public GameObject pill;
    public GameObject pillInventory;
    public GameObject gameoverScreen;
    float onesec = 1f;
    float countdown;
    public GameObject leverup;
    public GameObject leverdown;
    public GameObject coffeeMachine;
    public GameObject coffee;
    public GameObject coffeeInventory;

    // Use this for initialization
    void Start () {
        gameoverScreen.SetActive(false);
        pillInventory.SetActive(false);
        coffeeInventory.SetActive(false);
        coffee.SetActive(false);
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

        if (pill.activeInHierarchy == false)
        {
            pillInventory.SetActive(true);
        }
        
        if (coffeeInventory.activeInHierarchy == true && pillInventory.activeInHierarchy == true)
        {
            Debug.Log("can mix");
        }
	}
}
