using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Gamez");
    }
}
