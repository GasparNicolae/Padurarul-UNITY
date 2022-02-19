using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMj : MonoBehaviour {

    public GameObject copacMj, verfNR;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InstantaMj()
    {
        var clona = Instantiate(copacMj, transform.position, transform.rotation);
        clona.transform.SetParent(verfNR.transform);
    }
}
