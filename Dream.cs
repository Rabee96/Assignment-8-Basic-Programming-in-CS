using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dream : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        while (true)
        {
            int randomNumber = Random.Range(1, 21);
            Debug.Log("And the winner is : " + randomNumber); 
            if (randomNumber == 5)
                continue;
            else if (randomNumber == 15)
                break;
        }
        
    }
}
