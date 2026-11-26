using UnityEngine;

public class PerlinNoiseExample : MonoBehaviour
{
    [SerializeField] private float noiseSpeed;
    [SerializeField] private float seed;
    [SerializeField] private float maxTurn;
    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        seed = Random.Range(0f, 100f);
    }

    void Update()
    {
        float t = Time.time * noiseSpeed;
        float turn01 = Mathf.PerlinNoise(seed, t);
        float speed01 = Mathf.PerlinNoise(seed + 37.1f, t);
        float turnDeg = Mathf.Lerp(-maxTurn, maxTurn, turn01);
        float speed = Mathf.Lerp(minSpeed, maxSpeed, speed01);
        transform.Rotate(0f, turnDeg * Time.deltaTime, 0f);
        transform.position += transform.forward * speed * Time.deltaTime;
    }

}
