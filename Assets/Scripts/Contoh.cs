using UnityEngine;

public class Contoh : MonoBehaviour
{
    
    
    void Start()
    {
        Car car1 = new Car("Avanza", "Black");
        Car car2 = new Car("Sigra", "Orange");

        Debug.Log("Car 1");
        Debug.Log("Merk: " + car1.merk);
        Debug.Log("Warna: " + car1.warna);
        Debug.Log("Kecepatan: " + car1.speed);
        car1.start();
        car1.accelerate(40);
        car1.brake();

        Debug.Log("Car 2");
        Debug.Log("Merk: " + car2.merk);
        Debug.Log("Warna: " + car2.warna);
        Debug.Log("Kecepatan: " + car2.speed);
        car2.start();
        car2.accelerate(30);
        car2.brake();

    }

    
    void Update()
    {
        
    }
}
