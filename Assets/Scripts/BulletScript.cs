using UnityEngine;

public class BulletScript : MonoBehaviour
{
    float bulletSpeed;
    Vector3 bulletDirection;

    public void Init(Vector3 direction, float speed)
    {
        bulletSpeed = speed;
        Destroy(gameObject, 0.4f);
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * (bulletSpeed * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Bullet"))
        { 
            Destroy(gameObject); 
        }
    }
}
