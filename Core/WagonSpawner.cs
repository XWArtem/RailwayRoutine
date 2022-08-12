using UnityEngine;
using Random = UnityEngine.Random;

public class WagonSpawner : MonoBehaviour
{
    [SerializeField] Vector3[] _spawnPoint;
    [SerializeField] private LongWagonFactory _longWagonFactory;
    [SerializeField] private WoodFactory _woodFactory;

    public void SpawnLongWagon()
    {
        var _tempSpawnPointIndex = Random.Range(0, 3);
        var _tempWagonInstance = _longWagonFactory.SpawnWagon(_spawnPoint[_tempSpawnPointIndex]);
        _woodFactory.SpawnResource(_spawnPoint[_tempSpawnPointIndex], _tempWagonInstance);
    }
}
