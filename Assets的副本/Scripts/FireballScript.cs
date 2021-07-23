using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireballScript : MonoBehaviour
{
    public GameObject prefab;
    private GameObject holder;
    public int waitTime = 3;
    private int posX;
    private int posZ;
    // Start is called before the first frame update
    void Start()
    {
        holder = GameObject.Find("FireballHolder");
        StartCoroutine(Fire());
    }

    // Update is called once per frame
    void Update()
    {
        // z = -4, 4
        // x = -5, 5
        

    }

    IEnumerator Fire(){
        for(int i = 1; i <=25; i++){
            posX = Random.Range(-40, 40);
            posZ = Random.Range(-40, 40);
            GameObject clone = Instantiate(prefab, new Vector3(posX, 50, posZ), Quaternion.identity);
            clone.transform.SetParent(holder.transform);
        }
        
        yield return new WaitForSeconds(waitTime);
    }
}
