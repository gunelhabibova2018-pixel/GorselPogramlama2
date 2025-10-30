using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float moveSpeed = 50f; // hareket hýzý
    Rigidbody rb; // fizik componenti

    ScoreManager scoreManager;

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // scriptin baðlý olduðu nesne üzerindeki componenti bul
        scoreManager = FindFirstObjectByType<ScoreManager>();
    }

    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal"); // yatay hareket girdisi
        float moveZ = Input.GetAxis("Vertical"); // Dikey hareket girdisi

        Vector3 movement = new Vector3(moveX, 0f, moveZ); // oyuncunun gitmek istediði yönü belirle
        rb.AddForce(movement * moveSpeed); //rigibodye gidilmek istenne yönde kuvvet uygulaç böylece hareketi saðlamýþ oluruz.
    }

    private void OnTriggerEnter(Collider other)
    {
        //eðer oyuncu 'Pickup' tagýna sahip bir nesneye çarparsa o nesneyi yoket
        if (other.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);
            scoreManager.CollectPickup();
        }
    }
}
