using UnityEngine;

public class PlayerEat : MonoBehaviour
{
    private GameObject PlayerRb;

    private Rigidbody FoodRb;

    [SerializeField] private float fat;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerRb = GameObject.FindGameObjectWithTag("Player");
        FoodRb = GameObject.FindGameObjectWithTag("Food").GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            Debug.Log("FOOD YAY");
            PlayerRb.transform.localScale += new Vector3(fat, fat, fat);
        }

        if (collision.gameObject.tag == "Poison")
        {
            Debug.Log("POISON NOO");
            PlayerRb.transform.localScale -= new Vector3(fat, fat, fat);
        }
        Destroy(collision.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
