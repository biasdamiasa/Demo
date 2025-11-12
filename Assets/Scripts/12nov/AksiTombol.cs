using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AksiTombol : MonoBehaviour
{
    // aset gambar yang ingin dimasukkan ke object image
    public Sprite assetGambar;

    //komponen dari object image yang ada di scene
    public Image image;

    //komponen text dari object text yang ada di scene
    public TMP_Text objectText;
    public void Aksi()
    {
        image.sprite = assetGambar;
        objectText.text = "It's Me";
        
        Debug.Log("Button Click Me ditekan");
    }
}
