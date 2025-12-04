using UnityEngine;

public class kucukCemberKod : MonoBehaviour
{
    Rigidbody2D rigibody_;
    public int hiz;
    bool carptiMi = false;
    GameObject oyunYoneticisi;

    void Start()
    {
        rigibody_ = GetComponent<Rigidbody2D>();
        oyunYoneticisi = GameObject.FindGameObjectWithTag("oyunYoneticisi");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!carptiMi)
        {
            rigibody_.MovePosition(rigibody_.position * Vector2.up * hiz * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "donenCember")
        {
            carptiMi = true;
            //Debug.Log("buyuk cembere capti");
            transform.SetParent(other.transform);
        }

        if (other.gameObject.CompareTag("kucukCember"))
        {
            //Debug.Log("oyun bitti");
            //Time.timeScale = 0;
            oyunYoneticisi.GetComponent<oyunYoneticisi>().OyunBitti();
        }
    }
}
