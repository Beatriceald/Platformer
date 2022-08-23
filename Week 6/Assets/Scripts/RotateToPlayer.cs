using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToPlayer : MonoBehaviour
{

    public Vector3 LeftEuler;
    public Vector3 RightEuler;

    public float RotationSpeed = 5f;

    private Transform _playerTransform;
    private Vector3 _targetEuler;

    // Start is called before the first frame update
    void Start()
    {
        _playerTransform = FindObjectOfType<PlayerMove>().transform;   
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < _playerTransform.position.x)
        {
            //повернуться вправо
            _targetEuler = RightEuler;
        }
        else
        {
            //повернуться влево
            _targetEuler = LeftEuler;
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(_targetEuler), Time.deltaTime * RotationSpeed);
    }
}
