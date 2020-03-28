using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float totalTime;
    private float timer;
    private bool paused;
    private bool inited;
    public delegate void TimerEvent();
    public TimerEvent OnFinish;
    public TimerEvent OnInit;
    public TimerEvent OnRunning;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inited)
        {
            if(!paused)
            {
                timer += Time.deltaTime;
                if(timer >= totalTime)
                {
                    Finish();
                }
                else
                {
                    OnRunning.Invoke();
                }
            }
        }
    }

    public void Init()
    {
        OnInit.Invoke();
        inited = true;
    }

    public void Finish()
    {
        inited = false;
        OnFinish.Invoke();
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
