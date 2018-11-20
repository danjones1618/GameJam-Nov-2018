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

    public void Coffee()
    {

    }
}
