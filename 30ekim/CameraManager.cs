using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform player; // oyuncu karakterinin ekrandaki konumu
    public Vector3 offset = new Vector3(0, 45, -45);  // oyuncu ve kamera arasýnda olacak mesafe

    private void LateUpdate()
    {
        transform.position = player.position + offset; // bu scriptin baðlý olduðu nesnenin konumunu, oyuncuya ve mesafeye göre  güncelle
        
    }

}
