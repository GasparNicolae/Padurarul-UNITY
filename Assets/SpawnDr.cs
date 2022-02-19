using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDr : MonoBehaviour {

    public GameObject copacDr, verfNR;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InstantaDr()
    {
        var clona = Instantiate(copacDr, transform.position, transform.rotation);
        clona.transform.SetParent(verfNR.transform);

    }
}

