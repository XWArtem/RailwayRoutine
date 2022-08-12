using UnityEngine;

public class LongWagonFactory : WagonFactoryBase
{
    private string _longWagonPath = "Wagons/LongWagon";
    //private string _longWagonWoodPath = "Wagons/LongWagonWood";
    private Vector3 _spawnPoint;

    public override GameObject SpawnWagon(Vector3 spawnPoint)
    {
        _spawnPoint = spawnPoint;
        var _longWagonPrefab = Resources.Load<GameObject>(_longWagonPath);
        var _longWagonPrefabInstance = Instantiate(_longWagonPrefab, _spawnPoint, Quaternion.identity);
        return _longWagonPrefabInstance;
    }
}
