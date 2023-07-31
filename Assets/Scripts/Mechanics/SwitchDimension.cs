using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDimension : MonoBehaviour
{
    GameObject[] hell;
    GameObject[] heaven;

    bool H;

    void Start()
    {
        H = false;
        hell = GameObject.FindGameObjectsWithTag("Hell");
        heaven = GameObject.FindGameObjectsWithTag("Heaven");
    }

    // Update is called once per frame
    void Update()
    {
        if (H)
        {
            foreach (GameObject i in hell)
            {
                i.gameObject.SetActive(true);
            }

            foreach (GameObject i in heaven)
            {
                i.gameObject.SetActive(false);
            }
        }
        else
        {
            foreach (GameObject i in heaven)
            {
                i.gameObject.SetActive(true);
            }

            foreach (GameObject i in hell)
            {
                i.gameObject.SetActive(false);
            }
        }
    }

    public void Switch()
    {
        if (H) H = false;
        else H = true;
    }
}
