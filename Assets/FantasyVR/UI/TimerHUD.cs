using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerHUD : MonoBehaviour
{
    public Text text;
    public Timer timer;

    // Start is called before the first frame update
    void Awake()
    {
        timer.OnInit += Actualize;
        timer.OnRunning += Actualize;
    }

    void Start()
    {
        timer.Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Actualize()
    {
        Debug.Log("Timer Actualize");
        text.text = (timer.ContdownMin() + ":" + timer.ContdownSec() + ":" + timer.ContodownMillis());
    }
}
