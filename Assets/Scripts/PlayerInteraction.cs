using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour {

    public Camera fpsCam;
    public float range = 2f;
    public GameObject fnoti;
    public GameObject explosion;
    public GameObject bomb;



    void Start()
    {
        fnoti.SetActive(false);
        explosion.SetActive(false);
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
                if (hit.transform.name == "bomb_working")
                {
                    BombExplode();
                }
            }
        }
        else fnoti.SetActive(false);
        
	}

    void BombExplode()
    {
        Destroy(bomb);
        ExplosionEffect();
    }
    void ExplosionEffect()
    {

    }

}
