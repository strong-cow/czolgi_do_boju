using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Bullet2D : MonoBehaviour
{
    public GameObject explosionAnimationPrefab;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collided with " + collision.collider.GetType().ToString());

        //czy zderzyliśmy się z krawędzią planszy?
        if (collision.collider.GetType() == typeof(EdgeCollider2D))
        {
            //usuń obiekt (ten pocisk) ze sceny
            Destroy(this.gameObject);
        } else
        {
            //jeżeli zderzyliśmy się z czymś innym, pokaż animację wybuchu
            GameObject animation = Instantiate(explosionAnimationPrefab, this.gameObject.transform.position, Quaternion.identity);

            //od razu usuń pocisk
            Destroy(this.gameObject);

            //a po zadanym czasie usuń animację wybuchu
            Destroy(animation, 1);
        }
    }
}
