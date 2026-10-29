using UnityEngine;

public class ColorChange : MonoBehaviour
{
    // The object with RandomTargetSpawn (the Plane), linked in the Inspector in step 4.4
    [SerializeField] private RandomTargetSpawn targetSpawner;

    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.blue;
    }

    void OnTriggerEnter(Collider other)
    {
        rend.material.color = Color.green;
        // The Target's parent is the Plane, so this is the same object as other.transform.parent
        targetSpawner.spawnTarget();
    }

    void OnTriggerExit(Collider other)
    {
        rend.material.color = Color.blue;
        Destroy(other.gameObject);
    }
}