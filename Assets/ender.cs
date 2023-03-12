using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ender : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("EndThis", 8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void EndThis()
    {
        SceneManager.LoadScene("MainScene");
    }

}
