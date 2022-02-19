using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Bara : MonoBehaviour {

    public Slider oBara;
    public float timer, x;
    public TextMeshProUGUI txt;
    private float z;

	// Use this for initialization
	void Start () {
        oBara.value = 5f;
        x = 5f;
        PlayerPrefs.SetFloat("valBara", 5f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        x = (PlayerPrefs.GetFloat("valBara")) / 10;

        oBara.value = x;
        int y = (int)(x * 10);
        txt.GetComponent<TextMeshProUGUI>().text = y.ToString();

        if (x < 0.01 && PlayerPrefs.GetInt("seJoaca") == 1) FindObjectOfType<Accident>().Murit();
        y = PlayerPrefs.GetInt("scor");
        //Debug.Log(1 - (((float)y / 100) / 2));

        if (y < 161) z = 1 - ((float)y / 100) / 2;
        timer += Time.deltaTime;
        if (timer > z)
        {
            timer = 0f;
            if(x > 0 && PlayerPrefs.GetInt("seJoaca") == 1) PlayerPrefs.SetFloat("valBara", PlayerPrefs.GetFloat("valBara") - 1f);
            
        }
    }

}
