using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using System;

public class HitLine : MonoBehaviour
{
    public Queue<GameObject> notes = new();
    private GameObject note;
    public TextMeshProUGUI moe;
    private int noteSpeed;

    void Start()
    {
        noteSpeed = GameObject.Find("game").GetComponent<GameController>().noteSpeed;
    }

    void Update()
    {
        if (notes.Count > 0 && Input.anyKeyDown)
        {
            note = notes.Peek();
            double margin = Math.Round((note.transform.localPosition.y + 10f)/noteSpeed, 3);
            Destroy(note);
            string text;
            if (margin > 0)
            {
                text = "" + margin;
                moe.color = Color.red;
            }
            else if (margin < 0)
            {
                text = "" + margin;
                moe.color = Color.blue;
            }
            else
            {
                text = "0";
                moe.color = Color.white;
            }
            moe.text = text;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("note"))
        {
            notes.Enqueue(other.gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("note"))
        {
            notes.Dequeue();
        }
    }
}
