using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dream2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] words = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
        int attempt = 0;
        string sentence = "";
        while (attempt < words.Length)
        {
            sentence += $"{words[Random.Range(0,words.Length)]} ";
            attempt++;   
        }
        Debug.Log(sentence);
    }
}
