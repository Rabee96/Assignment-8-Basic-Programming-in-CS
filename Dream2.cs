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
        while (attempt < words.Length)
        {
            string firstWord = words[Random.Range(0,words.Length)];
            string secWord = words[Random.Range(0,words.Length)];
            while (firstWord == secWord)
                {
                    secWord = words[Random.Range(0,words.Length)];
                }
            Debug.Log(firstWord+" "+secWord);
            attempt++;   
        }
    }
}
