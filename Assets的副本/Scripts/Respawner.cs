using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{   public List<Transform> respawnPoint;
    public int current;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            Debug.Log("this is working");
            other.transform.position = respawnPoint[current].position;
        }
        
        
    }
}
