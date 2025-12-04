using System;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class anaCember : MonoBehaviour
{
    public GameObject kucukCember;
    public GameObject donenCember;
    public GameObject oyunuYoneticisi;
    public int atisSayisi = 8;
    void Start()
    {
        oyunuYoneticisi = GameObject.FindGameObjectWithTag("oyunYoneticisi");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(kucukCember, transform.position, transform.rotation);

            for (int i = 0; i < transform.childCount; i++)
            {
                var tmp = transform.GetChild(i).GetComponentInChildren<TextMeshProUGUI>();
                int sayi = int.Parse(tmp.text);
                sayi--;

                if (sayi > 0)
                    tmp.text = sayi.ToString();
                else
                    Destroy(transform.GetChild(i).gameObject);
            }
            
            atisSayisi--;
            
            if (atisSayisi == 0)
            {
                //Debug.Log("Oyun kazandýn");
                oyunuYoneticisi.GetComponent<oyunYoneticisi>().oyunKazandi();
            }
        }
    }
}
