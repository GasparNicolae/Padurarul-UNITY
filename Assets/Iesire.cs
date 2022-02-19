using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Iesire : MonoBehaviour
{


    private bool tapping;
    private float LastTap;

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!tapping)
            {
                tapping = true;
                SingleTap();
            }
            if ((Time.time - LastTap) < 2)
            {
                Application.Quit();
                //Debug.Log("DoubleTap");
                tapping = false;
            }
            LastTap = Time.time;
        }

    }

    void SingleTap()
    {
        Asteapta();
        if (tapping)
        {
            SendMessage("Test");
            //Debug.Log("SingleTap");
            tapping = false;
        }
    }

    IEnumerator Asteapta()
    {
        yield return new WaitForSeconds(2);
    }
}