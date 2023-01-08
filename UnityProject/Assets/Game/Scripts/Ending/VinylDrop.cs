using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class VinylDrop : MonoBehaviour
{
    [SerializeField] private float interval;

    [SerializeField] private GameObject vinylTemplate;

    [SerializeField] private Transform spawnTopRight;
    [SerializeField] private Transform spawnBottomLeft;
    
    private WaitForSeconds _interval;
    private Coroutine _spawnVinyl;

    private Vector3 _topRight;
    private Vector3 _bottomLeft;

    private float _spawnHeight;

    private void Start()
    {
        _interval = new WaitForSeconds(interval);
        _spawnVinyl = StartCoroutine(SpawnVinyl());

        _topRight = spawnTopRight.position;
        _bottomLeft = spawnBottomLeft.position;
        _spawnHeight = spawnBottomLeft.position.y;
    }

    private IEnumerator SpawnVinyl()
    {
        while (true)
        {
            yield return _interval;
            Instantiate(vinylTemplate, GetSpawnTransform(), GetRandomQuaternion());
        }
    }

    private Vector3 GetSpawnTransform()
    {
        return new Vector3(Random.Range(_topRight.x, _bottomLeft.x), _spawnHeight,
            Random.Range(_topRight.z, _bottomLeft.z));
    }

    private Quaternion GetRandomQuaternion()
    {
        Vector3 rotation = new Vector3(Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f));
        return Quaternion.Euler(rotation);
    }
}
