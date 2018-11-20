using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction2 : MonoBehaviour {

    public Camera fpsCam;
    public float range = 3f;
    public GameObject fnoti;
    Target target;
    public GameObject gamelogic;

    GameLogic gl;

    // Use this for initialization
    void Start () {
        fnoti.SetActive(false);
        gl = gamelogic.GetComponent<GameLogic>();
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
                if (hit.transform.gameObject == gl.bomb)
                {
                    Target target = hit.transform.GetComponent<Target>();
                    if (target != null)
                    {
                        target.Explode(gl.bomb, gl.bombEffect);
                        target.Destroyitem(gl.bomb);
                    }
                }
                if (hit.transform.gameObject == gl.pill)
                {
                    Target target = hit.transform.GetComponent<Target>();
                    if (target != null)
                    {
                        target.Destroyitem(gl.pill);
                    }
                    
                }
                if (hit.transform.gameObject == gl.leverup)
                {
                    Target target = hit.transform.GetComponent<Target>();
                    if (target != null)
                    {
                        target.Destroyitem(gl.leverup);
                        gl.leverdown.SetActive(true);
                    }
                }
                if (hit.transform.gameObject == gl.leverdown)
                {
                    Target target = hit.transform.GetComponent<Target>();
                    if (target != null)
                    {
                        target.Destroyitem(gl.leverdown);
                        gl.leverup.SetActive(true);
                    }
                }
                if (hit.transform.gameObject == gl.coffeeMachine)
                {
                    Target target = hit.transform.GetComponent<Target>();
                    if (target != null)
                    {
                        target.CoffeeAppear(gl.coffee);
                    }
                }
                if (hit.transform.gameObject == gl.coffee)
                {
                    Target target = hit.transform.GetComponent<Target>();
                    if (target != null)
                    {
                        target.Destroyitem(gl.coffee);
                        gl.coffeeInventory.SetActive(true);
                    }
                }
            }
        }
        else fnoti.SetActive(false);

    }
}
