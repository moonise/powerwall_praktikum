using UnityEngine;

public class RandomTargetSpawn : MonoBehaviour
{
    [SerializeField] private GameObject targetPrefab;

    void Start()
    {
        spawnTarget();
    }

    // public, because ColorChange will call it from another script
    public void spawnTarget()
    {
        Vector3 position = new Vector3(
            Random.Range(-2.5f, 2.5f),
            0f,
            Random.Range(-2.5f, 2.5f));

        // Spawns the prefab as a child of the object carrying this script
        Instantiate(targetPrefab, position, Quaternion.identity, transform);
    }
}