using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject[] menuObjects;
    private int index = 0;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
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
            if (index < menuObjects.Length)
            {
                index++;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene(menuObjects[index].GetComponent<MenuItem>().sceneTo);
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
