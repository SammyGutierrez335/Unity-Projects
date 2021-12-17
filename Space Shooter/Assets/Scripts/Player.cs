using System.Collections; //
using System.Collections.Generic; // part of the .net framework that allow us to write c# code
using UnityEngine; // MonoBehaviour comes from this namespace

public class Player : MonoBehaviour
    // data type (int, float, bool, string)
{
    //public or private reference (public all other scripts can reference this variable...private, only Player can reference)
    //public variables are also visible and adjustable in unity editor. 
    //private methods will not be visible/adjustable unless they have [SerializeField] above.
    public float speed = 3.5f;

    //private variables by convention is named with a proceeding underscore _speed.
    //private float _speed = 3.5

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
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
