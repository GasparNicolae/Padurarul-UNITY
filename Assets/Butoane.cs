using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Butoane : MonoBehaviour {

    public GameObject omSt, omDr, butonRrr, butonRs, verfCop, verfNR;
    private float timer; //ok = 0;
    public Animator animatorSt, animatorDr;
    public AudioClip Melodie, SunetRr;
    public AudioSource SursaMelodie, SursaRr;

    // Use this for initialization
    void Start () {
        PlayerPrefs.SetInt("copac", 2);
        PlayerPrefs.SetInt("numar", 0);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && PlayerPrefs.GetInt("seJoaca") == 1) ButonDr();
        if (Input.GetKeyDown(KeyCode.LeftArrow) && PlayerPrefs.GetInt("seJoaca") == 1) ButonSt();
        if (Input.GetKeyDown(KeyCode.Return) && butonRrr.activeSelf == true) ButonRr();
        timer += Time.deltaTime;
        if (timer > 0.3)
        {
            timer = 0f;
            //ok = 1;
        }
        //Debug.Log(verfNR.transform.childCount);
    }

    public void ButonRss()
    {
        PlayerPrefs.SetInt("seJoaca", 1);
        butonRs.SetActive(false);
        SursaMelodie.clip = Melodie;
        SursaMelodie.Play();
        SursaRr.clip = SunetRr;
        SursaRr.Play();
    }

    public void ButonDr()
    {
        //if (ok == 1)
        {
            omDr.SetActive(true);
            omSt.SetActive(false);
            animatorDr.SetTrigger("padDrTrigger");
            PlayerPrefs.SetInt("butonApasat", 1);

            //ok = 0;
        }
    }

    public void ButonSt()
    {
        //if(ok==1)
        {
            omSt.SetActive(true);
            omDr.SetActive(false);
            animatorSt.SetTrigger("padStTrigger");
            PlayerPrefs.SetInt("butonApasat", 0);

            //ok = 0;
        }
    }

    public void ButonRr()
    {
        SceneManager.LoadScene(0);
        butonRrr.SetActive(false);
        
    }
}
