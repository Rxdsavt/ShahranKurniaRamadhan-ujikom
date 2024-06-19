using UnityEngine;

public class GameplayManager : MonoBehaviour
{

    public float timer = 10f;
    public Camera gameplayCamera;
    public Camera gameOverCamera;
    public GameObject spawner;
    public GameObject BGM;
    public AudioSource src;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            Destroy(BGM);
            Destroy(spawner);
            src.PlayOneShot(clip, 0.3f);
            gameplayCamera.gameObject.SetActive(false);
            gameOverCamera.gameObject.SetActive(true);
        }
    }
}
