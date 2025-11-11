using UnityEngine;

public class Car
{
    public string merk;
    public string warna;
    public int speed;

    public Car(string merk, string warna)
    {
        this.merk = merk;
        this.warna = warna;
        this.speed = 0;
    }

    public void start()
    {
        this.speed = 10;
        Debug.Log("Mobil dinyalakan...Kecepatan saat ini: " + this.speed);
    }

    public void brake()
    {
        this.speed -= 10;
        Debug.Log("Mobil direm...Kecepatan saat ini: " + this.speed);
    }

    public void accelerate(int acc)
    {
        this.speed += acc;
        Debug.Log("Mobil dipercepat...Kecepatan saat ini: " + this.speed);
    }

}
