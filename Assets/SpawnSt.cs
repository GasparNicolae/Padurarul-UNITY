using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSt : MonoBehaviour {

    public GameObject copacSt, verfNR;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void InstantaSt()
    {
        var clona = Instantiate(copacSt, transform.position, transform.rotation);
        clona.transform.SetParent(verfNR.transform);
    }
}
