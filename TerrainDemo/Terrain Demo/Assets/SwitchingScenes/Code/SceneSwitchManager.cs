using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitchManager : MonoBehaviour
{
    public static SceneSwitchManager Instance;
    public List<Transform> spawnPoints;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void MoveToSpawnPoint(Transform transform, int spawnPointIndex)
    {
        transform.position = spawnPoints[spawnPointIndex].position;
    }
}
