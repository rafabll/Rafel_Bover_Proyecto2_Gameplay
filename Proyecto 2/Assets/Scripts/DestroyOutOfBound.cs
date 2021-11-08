using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float upperLim = 30f;
    private float lowerLim = -5f;
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Bala supera limite superior de pantlla
        if (transform.position.z > upperLim)
        {
            Destroy(gameObject);
        }

        //Animal supera limite inferior de pantalla
        if (transform.position.z < lowerLim)
        {
            Player = GameObject.Find("Player");
            Destroy(Player);
            Destroy(gameObject);
            Debug.Log("GAME OVER");
            Time.timeScale = 0; 
        }

    }
}
