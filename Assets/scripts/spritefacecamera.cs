using UnityEngine;

public class spritefacecamera : MonoBehaviour
{
    //from henry thank you henry 
    // makes the sprites look at camera to avoid clipping issues 
    public bool update = false; 
    void Start()
    {
        transform.LookAt(new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if (update == true)
        {
            transform.LookAt(new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z));
        }
    }
}
