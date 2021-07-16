using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireballScript : MonoBehaviour
{
    public GameObject prefab;
    private int posX;
    private int posZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // z = -4, 4
        // x = -5, 5
        for (int i = 0; i <= 9; i++)
        {
            posX = Random.Range(-5f, 5f);
            posZ = Random.Range(-4f, 4f);
            Instantiate(prefab)
        }
    }
}
