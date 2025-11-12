using UnityEngine;
using UnityEngine.UI;

public class AksiTombol : MonoBehaviour
{
    // aset gambar yang ingin dimasukkan ke object image
    public Sprite assetGambar;

    //komponen dari object image yang ada di scene
    public Image image;
    public void Aksi()
    {
        image.sprite = assetGambar;
        Debug.Log("Button Click Me ditekan");
    }
}
