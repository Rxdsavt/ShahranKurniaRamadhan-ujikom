using UnityEngine;

public class SpawnedObjectScript : MonoBehaviour
{

    public Rigidbody rb;
    public float force;
    public float decayTime;
    public objectType objType;
    public Collider col;


    private void Awake()
    {
        if(objType == objectType.Animal)
        {
            force = force * -1;
        }

        col = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();

        rb.AddForce(0, 0, force, ForceMode.Impulse);

        Destroy(gameObject, decayTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish") || other.CompareTag("Animal"))
        {
            Destroy(gameObject);
        }
    }

    public enum objectType
    {
        Food,
        Animal
    }
}
