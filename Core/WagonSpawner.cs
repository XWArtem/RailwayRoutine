using UnityEngine;

public class WagonSpawner : MonoBehaviour
{
    [SerializeField] Vector3 _spawnPoint;
    [SerializeField] private LongWagonFactory _longWagonFactory;

    public void SpawnLongWagon()
    {
        _longWagonFactory.SpawnWagon(_spawnPoint);
    }

}
