using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float degree = 45;
    void Update()
    {
        Transform planetTransform = GetComponent<Transform>();
        planetTransform.Rotate(new Vector3(0,degree * Time.deltaTime,0));
    }
}
