using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HUD: MonoBehaviour
{
    public delegate void HUDTrigger();
    public static HUDTrigger OnFinish;
    public static HUDTrigger OnStart;
    public static HUDTrigger OnInit;
    public static HUDTrigger OnRunning;
    public static HUDTrigger OnActualize;
    
}
