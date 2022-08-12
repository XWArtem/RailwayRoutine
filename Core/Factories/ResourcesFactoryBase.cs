using UnityEngine;

public abstract class ResourcesFactoryBase : MonoBehaviour
{
    public abstract GameObject SpawnResource(Vector3 startPosition, GameObject wagon);
}
