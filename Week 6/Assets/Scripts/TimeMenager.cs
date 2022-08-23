using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMenager : MonoBehaviour
{
    public float TimeScale = 0.2f;
    private float _startFixedDeltaTime;

    // Start is called before the first frame update
    void Start()
    {
        _startFixedDeltaTime = Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Time.timeScale = TimeScale;
        }
        else
        {
            Time.timeScale = 1f;
        }
        Time.fixedDeltaTime = _startFixedDeltaTime * Time.timeScale;
    }

    private void OnDestroy()
    {
        Time.fixedDeltaTime = _startFixedDeltaTime;
    }
}
