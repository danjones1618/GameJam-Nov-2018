using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour {

    public Camera fpsCam;
    public float range = 2f;


	// Update is called once per frame
	void Update () {
		if(Input.GetKey("f"))
        {
            Interact();
        }
	}

    void Interact()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range) && hit.transform.tag == "interactive")
        {
            Debug.Log(hit.transform.name);

        }
    }
}
