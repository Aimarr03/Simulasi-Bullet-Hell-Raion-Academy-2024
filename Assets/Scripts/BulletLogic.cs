using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    private float movementSpeed = 8f;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 directionBullet = new Vector3(-1, 0, 0);
        transform.position += directionBullet * movementSpeed * Time.deltaTime;
    }
}
