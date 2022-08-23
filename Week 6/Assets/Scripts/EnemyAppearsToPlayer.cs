using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAppearsToPlayer : MonoBehaviour
{

    public List<GameObject> EnemyList = new List<GameObject>();

    private Transform _playerTransform;

    private float Dif;

    private void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        _playerTransform = FindObjectOfType<PlayerHealth>().transform;

        for (int i = 0; i < EnemyList.Count; i++)
        {
            Dif = EnemyList[i].transform.position.x - _playerTransform.position.x;


            if (Dif > 10f)
            {
                EnemyList[i].SetActive(false);
            }
            else
            {
                EnemyList[i].SetActive(true);
            }
        }
        
    }
}
