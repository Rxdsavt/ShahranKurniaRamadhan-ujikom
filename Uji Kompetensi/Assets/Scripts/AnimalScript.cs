using UnityEngine;

public class AnimalScript : MonoBehaviour
{

    public float hungerNeeds;
    public float score;
    public AudioSource src;
    public AudioClip eatClip;

    void Start()
    {
        
    }

    void Update()
    {
        if (hungerNeeds <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            src.PlayOneShot(eatClip, 0.5f);
            hungerNeeds -= 25;
        }
    }
}
