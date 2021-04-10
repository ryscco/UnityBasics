using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    private float speed = 7f;
    private Rigidbody2D rb2d;
    public Transform firePoint;
    public GameObject bulletPrefab;
    private float bulletSpeed = 15f;
    private float cooldown = 0.2f;
    private float nextFire = 0f;

    void Start () {
      rb2d = GetComponent<Rigidbody2D> ();
    }
	
    void Update () {
      UpdateMotion();
      ProcessBulletSpwan();
    }

    private void UpdateMotion() {
        Vector3 pos = transform.position;

        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }

        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
    }
    
    private void ProcessBulletSpwan() {
      if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse0)) && Time.time > nextFire) {
        Vector3 mousePos = Input.mousePosition;
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D re = bullet.GetComponent<Rigidbody2D>();
        re.velocity = firePoint.up * bulletSpeed;
        nextFire = Time.time + cooldown;
      }
    }
}
