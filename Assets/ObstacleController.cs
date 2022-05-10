using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField]
    private Transform _obstaclePrefab;

    public float _spawnTime;
    private float _timeSum;
    
    void Start()
    {
        
    }


    void Update()
    {
        _timeSum += Time.deltaTime;

        if (_timeSum > _spawnTime)
        {
            Transform t = Instantiate(_obstaclePrefab);
            t.position = new Vector3(4, -1.351f);
            _timeSum -= _spawnTime;
            
        }
    }
}
