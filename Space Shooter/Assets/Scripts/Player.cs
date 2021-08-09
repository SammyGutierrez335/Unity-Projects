using System.Collections; //
using System.Collections.Generic; // part of the .net framework that allow us to write c# code
using UnityEngine; // MonoBehaviour comes from this namespace

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //take the current position and assign a new position (0, 0, 0)
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame (60fps - aka game loop)
    void Update()
    {
        //Vector3.right is syntatic sugar for new Vector3(1, 0, 0)) move 1 meter to the right per frame
        // transform.Translate(Vector3.right);
        
        //The distributed property newVector3(1, 0, 0) x 5 = newVector3(5, 0, 0) * real time
        transform.Translate(Vector3.right * 5 * Time.deltaTime);
    }
}
