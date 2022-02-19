using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class VerificaCopac : MonoBehaviour {

    public GameObject copacul;
    public TextMeshProUGUI scor;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void FixedUpdate () {
            if (PlayerPrefs.GetInt("butonApasat") == 1 && (PlayerPrefs.GetInt("copac") == 0 || PlayerPrefs.GetInt("copac") == 2))
            {

                Destroy(copacul);
                PlayerPrefs.SetInt("butonApasat", 0);
                if (PlayerPrefs.GetFloat("valBara") < 10) PlayerPrefs.SetFloat("valBara", PlayerPrefs.GetFloat("valBara") + 1f);

                PlayerPrefs.SetInt("scor", PlayerPrefs.GetInt("scor") + 1);
                scor.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("scor").ToString();

                if (PlayerPrefs.GetInt("scor") > PlayerPrefs.GetInt("maxim")) PlayerPrefs.SetInt("maxim", PlayerPrefs.GetInt("scor"));
            }
            else if (PlayerPrefs.GetInt("butonApasat") == 0 && (PlayerPrefs.GetInt("copac") == 1 || PlayerPrefs.GetInt("copac") == 2))
            {

                Destroy(copacul);
                PlayerPrefs.SetInt("butonApasat", 1);
                if (PlayerPrefs.GetFloat("valBara") < 10) PlayerPrefs.SetFloat("valBara", PlayerPrefs.GetFloat("valBara") + 1f);

                PlayerPrefs.SetInt("scor", PlayerPrefs.GetInt("scor") + 1);
                scor.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("scor").ToString();

                if (PlayerPrefs.GetInt("scor") > PlayerPrefs.GetInt("maxim")) PlayerPrefs.SetInt("maxim", PlayerPrefs.GetInt("scor"));
            }

            PlayerPrefs.SetInt("butonApasat", 2);

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "copDr")
        {
            PlayerPrefs.SetInt("copac", 1);
            //Debug.Log("COPACDR");
        }

        if (col.tag == "copSt")
        {
            PlayerPrefs.SetInt("copac", 0);
            //Debug.Log("COPACST");
        }

        if (col.tag == "copMj")
        {
            PlayerPrefs.SetInt("copac", 2);
            //Debug.Log("COPACMJ");
        }
        copacul = col.gameObject;
    }
}
