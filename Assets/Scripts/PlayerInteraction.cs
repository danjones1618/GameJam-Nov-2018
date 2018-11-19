using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour {

    public Camera fpsCam;
    public float range = 2f;
    public GameObject fnoti;
    public GameObject explosion;
    public GameObject bomb;
    public float explosionradius = 10f;
    public float explosionforce = 700f;



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
        Debug.Log("BOOM!");
        Instantiate(explosion, bomb.transform.position, bomb.transform.rotation);
        
        


        /*
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionradius);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if(rb != null)
            {
                rb.AddExplosionForce(explosionforce, bomb.transform.position, explosionradius);
            }
        }
        */

        Destroy(bomb);
        
    }

}
