using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour {

    public Camera fpsCam;
    public float range = 2f;
    public GameObject fnoti;

     void Start()
    {
        fnoti.SetActive(false);
    }
    // Update is called once per frame
    void Update () {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range) && hit.transform.tag == "interactive")
        {
            fnoti.SetActive(true);
            if (Input.GetKey("f"))
            {
                Debug.Log(hit.transform.name);
            }
        }
        else fnoti.SetActive(false);
        
	}

}
