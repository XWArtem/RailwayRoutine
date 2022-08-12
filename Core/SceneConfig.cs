using UnityEngine;
using System;
public class SceneConfig : MonoBehaviour
{
    public static Action WagonSpeedUp;

    private float _wagonSpeed;

    public float WagonSpeed
    {
        get 
        { 
            return _wagonSpeed; 
        }
        set 
        {
            _wagonSpeed = value;
            WagonSpeedUp?.Invoke();
        }
    }
}
