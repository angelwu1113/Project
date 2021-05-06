using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapearBlocker : MonoBehaviour
{
    public float TimerDisappear = 0.5f;
    public float TimerReappear = 1;
    public Collider Col;
    public MeshRenderer Mesh;
    void Start()
    {
        Col = GetComponent<Collider>();
        Mesh = GetComponent<MeshRenderer>();
    }

   
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(BlockDisappear());
        }
    }

    IEnumerator BlockDisappear()
    {
        yield return new WaitForSeconds(TimerDisappear);
        Col.enabled = false;
        Mesh.enabled = false;
        yield return new WaitForSeconds(TimerReappear);
        Mesh.enabled = true;
        Col.enabled = true;
    }

}

