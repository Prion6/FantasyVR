using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset_LVL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Resetlvl()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Quitlvl()
    {
        Application.Quit();
    }
}
