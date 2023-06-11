using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankGun : MonoBehaviour
{
    const int FIRE_DELAY = 500;
    const int FIRE_POWER = 9000;

    public GameObject bulletPrefab;
    public GameObject target;
    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (target.CompareTag("Player2") && Input.GetKeyDown(KeyCode.Space) == true) {
            if (counter == 0) {
                print("space pressed, tank position" + target.transform.position);
                Fire();
                counter = FIRE_DELAY;

            }
        }

        if (target.CompareTag("Player1") && Input.GetKeyDown(KeyCode.Return) == true)
        {
            if (counter == 0)
            {
                print("space pressed, tank position" + target.transform.position);
                Fire();
                counter = FIRE_DELAY;

            }
        }

        if (counter > 0) {
            counter--;
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
        bulletFired.GetComponent<Rigidbody2D>().AddRelativeForce(target.transform.up * FIRE_POWER, ForceMode2D.Force);
    }

}
