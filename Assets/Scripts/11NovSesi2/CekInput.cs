using UnityEngine;

public class CekInput : MonoBehaviour
{
    public GameObject _munculHilang;
    public GameObject _untukSpawn;
    public GameObject _targetDestroy;
    public GameObject _kotakBerwarna;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Tombol spasi ditekan");
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("tombol O ditekan");
            _munculHilang.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Tombol P ditekan");
            _munculHilang.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Tombol Enter ditekan");

            // Vector3 spawnPosition = new Vector3(2, 2, 0);
            // Quaternion spawnRotation = Quaternion.Euler(0, 0, 45);
            Instantiate(_untukSpawn, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0), Quaternion.Euler(0, 0, Random.Range(0,360)));

        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            GameObject hancurkan = GameObject.FindGameObjectWithTag("sasaran");
            Debug.Log("Tombol M ditekan");
            Destroy(_targetDestroy);
            Destroy(hancurkan);
        }
        
        if(Input.GetKeyDown(KeyCode.C))
        {
            SpriteRenderer _localSpriteRenderer = _kotakBerwarna.GetComponent<SpriteRenderer>();

            _localSpriteRenderer.color = Color.black;            
        }
    }
}
