using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerSkills : MonoBehaviour
{
    [SerializeField] private GameObject Projectile;

    [SerializeField] private GameObject Player;
    
    [SerializeField] private float ProjectileSpeed;

    private Transform MouthTransform;

    void Awake()
    {
        MouthTransform = GameObject.FindGameObjectWithTag("Mouth").transform;
    }

    public void OnDissolve(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            Instantiate(Projectile.GetComponent<Rigidbody>(), MouthTransform.position, Player.transform.rotation);
            //Projectile.GetComponent<Rigidbody>().AddForce(MouthTransform.right * ProjectileSpeed, ForceMode.Impulse);
        }
    }
    
    
    
}
