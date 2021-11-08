using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Vector3 initialPos = Vector3.zero;
    public float speed = 10f;
    private float horizontalInput;
    private float xRange = 20f;
    
    public GameObject projectilePrefab;
   

    // Start is called before the first frame update
    void Start()
    {
        //posici�n inicial del player
        transform.position = initialPos;
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento del player
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z); 
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        //Mecanica de disparo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }
}
