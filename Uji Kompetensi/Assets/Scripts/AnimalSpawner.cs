using System.Collections;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public GameObject[] animalObject;
    public int randNum;
    public Vector3 targetPos;
    private Vector3 startPos;
    private Vector3 targetVectorData;

    private void Awake()
    {
        startPos = transform.position;
        targetVectorData = targetPos;
    }

    void Start()
    {
        StartCoroutine(SpawnAnimal());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, 20 * Time.deltaTime);
        if (transform.position == targetPos)
        {
            targetPos = startPos;
        }
        if (transform.position == startPos)
        {
            targetPos = targetVectorData;
        }
    }

    IEnumerator SpawnAnimal()
    {
        while (true)
        {
            randNum = Random.Range(0, animalObject.Length);
            Instantiate(animalObject[randNum], transform.position, Quaternion.Euler(new Vector3(0,180,0)));
            yield return new WaitForSeconds(2);
        }
    }
}
