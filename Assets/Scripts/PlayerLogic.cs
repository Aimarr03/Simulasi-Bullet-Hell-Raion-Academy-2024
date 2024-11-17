using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    private float movementSpeed = 8f;
    private float maxDistance = 9;

    public GameObject bullet;
    void Start()
    {
        
    }

    
    void Update()
    {
        float inputHorizontal = Input.GetAxisRaw("Horizontal");
        //Vector3 movementDirection = new Vector3(0, 0, inputHorizontal);
        Vector3 movementDirection = new Vector3(); //movement Direction => 0,0,0
        movementDirection.z = inputHorizontal;
        //Debug.Log(movementDirection);
        
        //Bentuk Singkat
        //transform.position += movementDirection * movementSpeed * Time.deltaTime;
        //Memasukkan nilai perubahan agar memastikan tidak melebihi batas maksimal
        Vector3 directionOutput = transform.position + (movementDirection * movementSpeed * Time.deltaTime);
        directionOutput.z = Mathf.Clamp(directionOutput.z, -maxDistance, maxDistance);
        transform.position = directionOutput;

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Eksekusi Logika Nembak");
            //Pembuatan Peluru Baru dengan mereferensikan
            //1. Apa yang ingin dibuat
            //2. Posisi ketika dia dibuat
            //3. Rotasinya => Quaternion.identity mengindikasikan bahwa rotasi dia berada di nilai default
            GameObject NewBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            Destroy(NewBullet, 5.5f);
        }
    }
}
