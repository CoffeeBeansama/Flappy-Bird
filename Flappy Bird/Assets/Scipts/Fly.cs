using UnityEngine;


public class Fly : MonoBehaviour
{
    public float velocity;
    public new Rigidbody2D rigidbody2D;
    public scGameManager GameManager;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
        rigidbody2D.velocity = Vector2.up * velocity;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Pipe")
        {
          GameManager.GameOver();
        }
      
    }
}
