using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

   private void OnTriggerEnter(Collider otherTrigger)
    {
        //GameObject del animal
        Destroy(otherTrigger.gameObject);
        //Gameobject de la bala
        Destroy(gameObject);
    }
}
