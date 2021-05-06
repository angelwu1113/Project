using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{   public List<Transform> respawnPoint;
    public int current;
    void OnTriggerEnter(Collider Other)
    {
        Debug.Log("this is working");
        Other.transform.position = respawnPoint[current].position;
        
    }
}
