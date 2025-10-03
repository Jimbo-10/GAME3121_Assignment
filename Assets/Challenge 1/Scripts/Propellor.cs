using UnityEngine;

public class Propellor : MonoBehaviour
{
    public float rotationSpeed = 1000f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, rotationSpeed * rotationSpeed * Time.deltaTime);
    }
}
