using UnityEngine;

public class AnimalScript : MonoBehaviour
{

    public float hungerNeeds;
    public float score;
    public AudioSource src;
    public AudioClip eatClip;
    public AudioClip deadClip;

    void Start()
    {
        
    }

    void Update()
    {
        if (hungerNeeds <= 0)
        {
            src.PlayOneShot(deadClip, 0.3f);
            Destroy(gameObject, 0.3f);
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
