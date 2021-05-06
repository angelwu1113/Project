using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible : MonoBehaviour
{
    //int On = 8;
    //int Off = 20;
    float timer = 0f;
    MeshRenderer block;
    void Start()
    {
        block = GetComponent<MeshRenderer>();
        //block.enabled = false;
    }

    void Update()
    {
        //block.enabled = true;
        Debug.Log(timer);
        if(timer <= 5.0f){
            timer += Time.deltaTime;
            block.enabled = true; 
        }
        else if(timer >= 5f && timer <= 10f){
            timer += Time.deltaTime;
            block.enabled = false;
        }
        else{
            timer = 0;
        }
    }
}
