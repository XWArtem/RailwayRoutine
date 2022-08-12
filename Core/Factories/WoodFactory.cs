using UnityEngine;

public class WoodFactory : ResourcesFactoryBase
{
    private string _woodPath = "GameResources/Wood";
    private Vector3 _spawnPoint;

    public override GameObject SpawnResource(Vector3 spawnPoint, GameObject wagon)
    {
        _spawnPoint = spawnPoint;
        var _woodPrefab = Resources.Load<GameObject>(_woodPath);
        var _woodPrefabInstance = Instantiate
            (_woodPrefab, 
            new Vector3 (_spawnPoint.x + 0.08f, _spawnPoint.y + 0.5f, _spawnPoint.z), 
            Quaternion.identity, 
            wagon.transform);
        return _woodPrefabInstance;
    }
}
