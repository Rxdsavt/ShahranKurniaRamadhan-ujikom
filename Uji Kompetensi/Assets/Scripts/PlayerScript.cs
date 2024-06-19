using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Player Movement Purposes
    public float movementSpeed;

    // Spawn Food Purposes
    public Transform spawnPoint;
    public GameObject foodObject;
    
    void Start()
    {
        
    }

    void Update()
    {
        // Movement
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }

        // Food Spawning
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodObject, spawnPoint.position, Quaternion.identity);
        }
    }
}
