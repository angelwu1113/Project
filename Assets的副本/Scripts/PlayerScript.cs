using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    public TextMeshProUGUI moveText;
    public TextMeshProUGUI jumpText;
    // Start is called before the first frame update
    void Start()
    {
        moveText.enabled = true;
        jumpText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Check"){
            moveText.enabled = false;
            jumpText.enabled = true;
        }
        else if(other.tag == "Check2"){
            jumpText.enabled = false;
        }
    }
}
