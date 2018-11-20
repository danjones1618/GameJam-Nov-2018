using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombLogic : MonoBehaviour {

    public float timer = 600f;
    float countdown;
    public bool hasExplode = false;
    public GameObject bombEffect;

	// Use this for initialization
	void Start () {
        countdown = timer;
	}
	
	// Update is called once per frame
	void Update () {
        countdown -= Time.deltaTime;
        if (countdown <= 0 && hasExplode == false)
        {
            Target target = this.gameObject.GetComponent<Target>();
            target.Explode(this.gameObject, bombEffect);
            hasExplode = true;
            target.Destroyitem(this.gameObject);
        }
        
	}
}
