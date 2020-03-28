using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerHUD : HUD
{
    public Text text;
    public Timer timer;

    void Start()
    {
        OnRunning += Actualize;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Actualize()
    {
        text.text = (timer.ContdownMin() + ":" + timer.ContdownSec() + ":" + timer.ContodownMillis());
        OnActualize.Invoke();
    }

    void Finish()
    {
        OnFinish();
    }
}
