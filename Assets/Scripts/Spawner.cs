using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform _spawn;

    private Transform[] _spawns;

    private void Start()
    {
        _spawns = new Transform[_spawn.childCount];

        for (int i = 0; i < _spawn.childCount; i++)
        {
            _spawns[i] = _spawn.GetChild(i);
        }

        StartCoroutine(CreateEnemy());
    }

    private IEnumerator CreateEnemy()
    {
        var waitForTwoSeconds = new WaitForSeconds(2f);
        while (true)
        {
            for (int i = 0; i < _spawns.Length; i++)
            {
                Instantiate(_enemy, _spawns[i].position, Quaternion.identity);
                yield return waitForTwoSeconds;
            }
        }
    }
}
