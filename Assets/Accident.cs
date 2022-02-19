using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Accident : MonoBehaviour {

    public Animator animatorSt, animatorDr;
    public GameObject butonRr, butonSt, butonDr, butonRs;
    public int ok;

    // Use this for initialization
    void Start()
    {
        butonRr.SetActive(false);
        butonSt.SetActive(false);
        butonDr.SetActive(false);
        butonRs.SetActive(true);
        ok = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("seJoaca") == 1 && ok == 1)
        {
            butonSt.SetActive(true);
            butonDr.SetActive(true);
            butonRs.SetActive(false);
            ok = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "lovire")
        {

            Murit();
        }

    }

    public void Murit()
    {
        Handheld.Vibrate();
        PlayerPrefs.SetInt("seJoaca", 0);
        animatorSt.SetTrigger("padStLov");
        animatorDr.SetTrigger("padDrLov");
        butonSt.SetActive(false);
        butonDr.SetActive(false);
        PlayerPrefs.SetInt("scor", 0);
    }

    public void DupaAnimSt()
    {
        animatorSt.ResetTrigger("padStTrigger");
    }

    public void DupaAnimDr()
    {
        animatorDr.ResetTrigger("padDrTrigger");
    }

    public void DupaAnimLov()
    {
        animatorSt.ResetTrigger("padStLov");
        animatorDr.ResetTrigger("padDrLov");
        butonRr.SetActive(true);
    }
}
