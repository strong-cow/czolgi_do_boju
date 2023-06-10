using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankGun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true) {
            print("space pressed, tank position"+target.transform.position);
            Fire();
        }
    }

    private void Fire()
    {
        GameObject bulletFired = Instantiate(bulletPrefab, target.transform.position, Quaternion.identity);

        //ustaw pocisk aby był obrócony tak samo jak czołg
        bulletFired.transform.rotation = target.transform.rotation;

        //ignoruj zderzenie wystrzelonego pocisku z czołgiem, który go wystrzelił
        Physics2D.IgnoreCollision(bulletFired.GetComponent<Collider2D>(), target.GetComponent<Collider2D>());

        //nadaj pociskowi pęd  
        bulletFired.GetComponent<Rigidbody2D>().AddRelativeForce(target.transform.up * 6000, ForceMode2D.Force);
    }

}
