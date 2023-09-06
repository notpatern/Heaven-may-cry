using UnityEngine.InputSystem;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public PlayerInputs playerActions;
    private InputAction shoot;
    private InputAction secShoot;
    public Animator animator;
    public Transform spawPoint;
    public GameObject bulletPrefab;
    public float speed;

    void Awake()
    {
        playerActions = new PlayerInputs();
    }

    private void OnEnable()
    {
        shoot = playerActions.Shoot.Primary;
        shoot.Enable();
        shoot.performed += Shoots;

        secShoot = playerActions.Shoot.Secondary;
        secShoot.Enable();
        secShoot.performed += SecShoots;
    }

    private void OnDisable()
    {
        shoot.Disable();
        secShoot.Disable();
    }

    private void Shoots(InputAction.CallbackContext context)
    {
        Vector3 inacVect = spawPoint.rotation.eulerAngles;
        float bulletAccuracyX;
        float bulletAccuracyY;

        animator.SetTrigger("Fired");
        for (int i = 0; i < 10; i++)
        {
            bulletAccuracyX = Random.Range(-0.5f, 0.5f);
            bulletAccuracyY = Random.Range(-0.5f, 0.5f);
            inacVect = new Vector3(inacVect.x + bulletAccuracyX * i, inacVect.y + bulletAccuracyY * i, inacVect.z);
            GameObject shotB = Instantiate(bulletPrefab, spawPoint.position, Quaternion.Euler(inacVect));
            shotB.GetComponent<BulletScript>().Init(spawPoint.forward, speed);
        }
    }

    private void SecShoots(InputAction.CallbackContext context)
    {
        Debug.Log("Sec");
    }


    void Update()
    {
        
    }
}
