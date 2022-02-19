using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Spawn : MonoBehaviour {

    private int x, ok, ok2;
    public float timer;
    public TextMeshProUGUI scor, maxim;
    public Button butonStart;
    public AudioClip SunetBut;
    public AudioSource SursaBut;
    public GameObject verfCop, verfNR;

    // Use this for initialization
    void Start () {
        SursaBut.clip = SunetBut;
        ok = 1; ok2 = 1;
        PlayerPrefs.SetInt("seJoaca", 0);
        scor.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("maxim").ToString();
        maxim.enabled = true;
        PlayerPrefs.SetInt("scor", 0);
        butonStart.interactable = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (ok < 4)
        {

            if (ok == 1)
            { 
            timer += Time.deltaTime;
            if (timer > 1)
            {
                timer = 0f;
                x = Random.Range(0, 2);
                    if (x == 0) { FindObjectOfType<SpawnDr>().InstantaDr(); FindObjectOfType<SpawnMj>().InstantaMj(); GetComponent<Butoane>().omDr.SetActive(false); GetComponent<Butoane>().omSt.SetActive(true); }
                    else { FindObjectOfType<SpawnSt>().InstantaSt(); FindObjectOfType<SpawnMj>().InstantaMj(); GetComponent<Butoane>().omDr.SetActive(true); GetComponent<Butoane>().omSt.SetActive(false); }
                ok++;
                    SursaBut.Play();
                }
            }

            if (ok == 2)
            {
                timer += Time.deltaTime;
                if (timer > 1)
                {
                    timer = 0f;
                    x = Random.Range(0, 2);
                    if (x == 0) { FindObjectOfType<SpawnDr>().InstantaDr(); FindObjectOfType<SpawnMj>().InstantaMj(); }
                    else { FindObjectOfType<SpawnSt>().InstantaSt(); FindObjectOfType<SpawnMj>().InstantaMj(); }
                    ok++;
                    SursaBut.Play();
                }
            }

            if (ok == 3)
            {
                timer += Time.deltaTime;
                if (timer > 1)
                {
                    timer = 0f;
                    x = Random.Range(0, 2);
                    if (x == 0) { FindObjectOfType<SpawnDr>().InstantaDr(); FindObjectOfType<SpawnMj>().InstantaMj(); }
                    else { FindObjectOfType<SpawnSt>().InstantaSt(); FindObjectOfType<SpawnMj>().InstantaMj(); }
                    ok++;
                    //maxim.enabled = false;
                    //scor.GetComponent<TextMeshProUGUI>().text = "0";
                    butonStart.interactable = true;
                    SursaBut.Play();
                }
            }
            
        }

        if(ok2 == 1 && PlayerPrefs.GetInt("seJoaca") == 1)
        {
            maxim.enabled = false;
            scor.GetComponent<TextMeshProUGUI>().text = "0";
            ok2 = 0;
        }

        if (ok == 4)
        {
            timer += Time.deltaTime;
            if (timer > 0.1)
            {
                timer = 0f;
                if (verfNR.transform.childCount == 5)
                {
                    x = Random.Range(0, 2);
                    if (x == 0) { FindObjectOfType<SpawnSt>().InstantaSt(); FindObjectOfType<SpawnMj>().InstantaMj(); }
                    else { FindObjectOfType<SpawnDr>().InstantaDr(); FindObjectOfType<SpawnMj>().InstantaMj(); }
                    SursaBut.Play();
                    //Debug.Log(PlayerPrefs.GetInt("numar"));
                }
            }
        }


       
    }
}
