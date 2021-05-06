using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public TextMeshProUGUI FinishText;
    public GameObject Mainmenu;
    // Start is called before the first frame update
    void Start()
    {
        FinishText.enabled = false;
        Mainmenu.SetActive(false);
    }

    void OnTriggerEnter()
    {
        FinishText.enabled = true;
        Mainmenu.SetActive(true);
    }

    public void Back(){
        SceneManager.LoadScene("Demo Night");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
