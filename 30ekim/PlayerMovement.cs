using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float moveSpeed = 50f; // hareket h�z�
    Rigidbody rb; // fizik componenti

    ScoreManager scoreManager;

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // scriptin ba�l� oldu�u nesne �zerindeki componenti bul
        scoreManager = FindFirstObjectByType<ScoreManager>();
    }

    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal"); // yatay hareket girdisi
        float moveZ = Input.GetAxis("Vertical"); // Dikey hareket girdisi

        Vector3 movement = new Vector3(moveX, 0f, moveZ); // oyuncunun gitmek istedi�i y�n� belirle
        rb.AddForce(movement * moveSpeed); //rigibodye gidilmek istenne y�nde kuvvet uygula� b�ylece hareketi sa�lam�� oluruz.
    }

    private void OnTriggerEnter(Collider other)
    {
        //e�er oyuncu 'Pickup' tag�na sahip bir nesneye �arparsa o nesneyi yoket
        if (other.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);
            scoreManager.CollectPickup();
        }
    }
}
