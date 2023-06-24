using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPoint : MonoBehaviour
{
    private bool _initialized = false;

    private int _maxHitPoint;
    private int _currentHitPoint;


    /// <summary>
    /// Set up Hitpoint initialization.
    /// Activate only once in life cycle
    /// </summary>
    /// <param name="maxHitPoint">Maximum HitPoint</param>
    public HitPoint(int maxHitPoint)
    {
        // Prevent multiple initialization
        if (_initialized)
        {
            Debug.LogWarning("HitPoint :: Multiple initialization detected");
            return;
        }

        _initialized = true;

        _maxHitPoint = maxHitPoint;
        _currentHitPoint = maxHitPoint;
    }

    public int TakingDamange(int damageInput)
    {


        return _currentHitPoint;
    }

    private void Die()
    {

    }

}
