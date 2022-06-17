using UnityEngine;

public class Move : MonoBehaviour
{
    private float _speed = 2;
    void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}