using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireballScript : MonoBehaviour
{
    public GameObject prefab;
    private GameObject holder;
    public float waitTime = 10f;
    private int posX;
    private int posZ;
    private float timer;
    public float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        //holder = GameObject.Find("FireballHolder");
        StartCoroutine(Fire());
        timer = 0f;
        //spawnTime = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        posX = Random.Range(-13, 35);
        posZ = Random.Range(-15, 40);
        

        // spawnTime -= Time.deltaTime;
        // if(spawnTime <= 0)
        // {
        //     GameObject clone = Instantiate(prefab, new Vector3(posX, 50f, posZ), Quaternion.identity);
        //     Destroy(clone, 10f);
        //     spawnTime = 5f;
        // }
        

        // if(timer <= waitTime){
        //     timer += Time.deltaTime;
        //     GameObject clone = Instantiate(prefab, new Vector3(posX, 50f, posZ), Quaternion.identity);
        //     Destroy(clone, 5f);
        //     timer = 0f;
        // }
       

    

    }

    

    IEnumerator Fire(){

        yield return new WaitForSeconds(waitTime);
        posX = Random.Range(-13, 35);
        posZ = Random.Range(-15, 40);
        GameObject clone = Instantiate(prefab, new Vector3(posX, 50f, posZ), Quaternion.identity);
        Destroy(clone, 7f);

        // for(int i = 1; i <=25; i++){
            
        //     GameObject clone = Instantiate(prefab, new Vector3(posX, 50f, posZ), Quaternion.identity);
        //     Destroy(clone, 7f);
        //     //clone.transform.SetParent(holder.transform);
        // }
        
        
    }
}
