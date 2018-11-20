using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction2 : MonoBehaviour {

    public Camera fpsCam;
    public float range = 3f;
    public GameObject fnoti;
    Target target;
    public GameObject bomb;
    public GameObject bombEffect;
    public GameObject pill;
    public GameObject leverup;
    public GameObject leverdown;

    // Use this for initialization
    void Start () {
        fnoti.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range) && hit.transform.tag == "interactive")
        {
            fnoti.SetActive(true);
            if (Input.GetKeyDown("f"))
            {
                Debug.Log(hit.transform.name);
                if (hit.transform.name == "bomb_working")
                {
                    Target target = hit.transform.GetComponent<Target>();
                    if (target != null)
                    {
                        target.Explode(bomb, bombEffect);
                        target.Destroyitem(bomb);
                    }
                }
                if (hit.transform.name == "sleeping_pill")
                {
                    Target target = hit.transform.GetComponent<Target>();
                    if (target != null)
                    {
                        target.Destroyitem(pill);
                    }
                    
                }
                if (hit.transform.name == "leverup")
                {
                    Target target = hit.transform.GetComponent<Target>();
                    if (target != null)
                    {
                        target.Destroyitem(leverup);
                        leverdown.SetActive(true);
                    }
                }
                if (hit.transform.name == "leverdown")
                {
                    Target target = hit.transform.GetComponent<Target>();
                    if (target != null)
                    {
                        target.Destroyitem(leverdown);
                        leverup.SetActive(true);
                    }
                }
            }
        }
        else fnoti.SetActive(false);

    }
}
