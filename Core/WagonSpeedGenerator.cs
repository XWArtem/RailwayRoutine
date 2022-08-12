using UnityEngine;
using System.Collections;

public class WagonSpeedGenerator : MonoBehaviour
{
    [SerializeField] private SceneConfig _sceneConfig;
    private bool _gameIsActive;

    private void Awake()
    {
        _gameIsActive = true;
    }
    private void Start()
    {
        StartCoroutine(WagonSpeedUp());
    }
    IEnumerator WagonSpeedUp()
    {
        while (_gameIsActive)
        {
            yield return new WaitForSeconds(2f);
            _sceneConfig.WagonSpeed += 0.3f;
        }
    }
}
