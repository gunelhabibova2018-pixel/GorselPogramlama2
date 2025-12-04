using UnityEngine;

public class oyunYoneticisi : MonoBehaviour
{
    GameObject anaCember;
    GameObject donenCember;
    public Animator animator;
    void Start()
    {
        anaCember = GameObject.FindGameObjectWithTag("anaCember");
        donenCember = GameObject.FindGameObjectWithTag("donenCember");
    }


    void Update()
    {
        
    }

    public void OyunBitti()
    {
        Debug.Log("oyun bitti");
        animator.SetTrigger("oyunbitti");
        if (donenCember != null)
        {
            var dk = donenCember.GetComponent<donenCemberKod>();
            if (dk != null) dk.enabled = false;
        }

        if (anaCember != null)
        {
            var ak = anaCember.GetComponent<anaCember>();
            if (ak != null) ak.enabled = false;
        }


    }

    public void oyunKazandi()
    {
        //Debug.Log("oyun kazandi...");
        Time.timeScale = 0;
    }
}
