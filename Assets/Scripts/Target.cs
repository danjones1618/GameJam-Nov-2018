using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Destroyitem (GameObject item)
    {
        item.SetActive(false);
    }

    public void Explode (GameObject item, GameObject effect)
    {
        Instantiate(effect, item.transform.position, item.transform.rotation);
    }

    public void CoffeeAppear(GameObject item)
    {
        item.SetActive(true);
        //Instantiate(item, machine.transform.position + 0.4f * Vector3.left, machine.transform.rotation);
    }
}
