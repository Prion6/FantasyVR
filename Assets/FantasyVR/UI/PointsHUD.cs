using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsHUD : HUD
{
    public Text text;
    private static float points;
    public static float _points { get { return points; } }

    // Start is called before the first frame update
    void Start()
    {
        OnActualize += SetScore;
    }

    // Update is called once per frame
    void Update()
    {
        OnRunning?.Invoke();
    }

    public static void AddPoints(float points)
    {
        PointsHUD.points += points;
        OnActualize.Invoke();
    }

    private void SetScore()
    {
        text.text = _points.ToString();
    }
}
