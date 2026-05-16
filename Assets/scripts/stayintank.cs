using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class stayintank : MonoBehaviour
{
    public float topOfZone;
    public float bottomOfZone;
    private float leftMost = -19;
    private float rightMost = 19;
    private float top = 219; 
    private float bottom = -194;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x > rightMost)
        {
            this.transform.position -= new Vector3 (30, 0, 0);
        }
        if (this.transform.position.x < leftMost)
        {
            this.transform.position += new Vector3(30, 0, 0);
        }
        if (this.transform.position.y > top || this.transform.position.y > topOfZone)
        {
            this.transform.position -= new Vector3(0, 30, 0);
        }
        if (this.transform.position.y < bottom || this.transform.position.y < bottomOfZone)
        {
            this.transform.position += new Vector3(0, 30, 0);
        }

    }
}
