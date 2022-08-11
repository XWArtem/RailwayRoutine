using UnityEngine;

public abstract class WagonFactoryBase : MonoBehaviour
{
    public abstract GameObject SpawnWagon(Vector3 startPosition);
}
