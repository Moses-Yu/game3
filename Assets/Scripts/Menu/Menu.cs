using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject[] menuObjects;
    private int index = 0;
    private bool usingMouse = false;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        usingMouse = false;
        for (int i = 0; i < menuObjects.Length; i++)
        {
            if (menuObjects[i].GetComponent<MenuItem>().mouseOver)
            {
                usingMouse = true;
                index = i;
                break;
            }
        }

        if (usingMouse && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(menuObjects[index].GetComponent<MenuItem>().sceneTo);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (index > 0)
                {
                    index--;
                }
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (index < menuObjects.Length - 1)
                {
                    index++;
                }
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(menuObjects[index].GetComponent<MenuItem>().sceneTo);
            }
        }

        for (int i = 0; i < menuObjects.Length; i++)
        {
            if (index == i)
            {
                menuObjects[i].GetComponent<MenuItem>().selected = true;
            }
            else
            {
                menuObjects[i].GetComponent<MenuItem>().selected = false;
            }
        }
    }
}
