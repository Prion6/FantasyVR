using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float totalTime;
    private float timer;
    private bool paused;
    private bool inited;
    

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame

    void Update()
    {
        if (inited)
        {
            if (!paused)
            {
                timer += Time.deltaTime;
                if (timer >= totalTime)
                {
                    Finish();
                }
                else
                {
                    TimerHUD.OnRunning.Invoke();
                }
            }
        }
    }

    public void Init()
    {
        inited = true;
        TimerHUD.OnInit.Invoke();
    }

    public void Finish()
    {
        TimerHUD.OnFinish.Invoke();
        inited = false;
    }

    public int ElapsedMin()
    {
        return (int)timer / 60;
    }

    public int ElapsedSec()
    {
        return (int)timer % 60;
    }

    public int ElapsedMillis()
    {
        return (int)(100*(timer - (int)timer));
    }

    public int ContdownMin()
    {
        float cd = totalTime - timer;
        return (int)cd / 60;
    }

    public int ContdownSec()
    {
        float cd = totalTime - timer;
        return (int)cd % 60;
    }

    public int ContodownMillis()
    {
        float cd = totalTime - timer;
        return (int)(100 * (cd - (int)cd));
    }
}
