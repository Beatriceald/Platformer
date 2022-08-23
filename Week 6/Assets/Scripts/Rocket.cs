using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{

    public float Speed;
    public float RotationSpeed;

    private Transform _playerTransform;

    //public ParticleSystem SmokeEffect;

    // Start is called before the first frame update
    void Start()
    {
        _playerTransform = FindObjectOfType<PlayerMove>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * Speed;
        Vector3 ToPlayer = _playerTransform.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(ToPlayer, upwards: Vector3.forward);

        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * RotationSpeed);

        //SmokeEffect.Play();
    }
}
