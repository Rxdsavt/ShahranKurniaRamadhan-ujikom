using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Player Movement Purposes
    public float movementSpeed;

    // Spawn Food Purposes
    public Transform spawnPoint;
    public GameObject foodObject;

    // Audio Purposes
    public AudioSource src;
    public AudioClip throwFoodClip;

    void Start()
    {
        src = GetComponent<AudioSource>();
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
            src.PlayOneShot(throwFoodClip, 0.5f);
            Instantiate(foodObject, spawnPoint.position, Quaternion.identity);
        }
    }
}
