using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
public class PlayerScript : MonoBehaviour

{

    [SerializeField] private string walkInputName;
    [SerializeField] private float walkSpeed;
    [SerializeField] private InputActionReference walkInput;
    private Rigidbody rb;

    private Transform cameraTransform;

    void Start()
    {
        //get inputs
        //walkInput = InputSystem.actions.FindAction(walkInputName);

        rb = GetComponent<Rigidbody>();

        cameraTransform = Camera.main.transform;
    }

    void FixedUpdate()
    {
        //store rigidbody y velocity
        float yVelocity = rb.linearVelocity.y;

        //get direction of input
        Vector3 walkDir = new Vector3(walkInput.action.ReadValue<Vector2>().x, 0f, walkInput.action.ReadValue<Vector2>().y);
        walkDir = cameraTransform.rotation * walkDir;
        walkDir.y = 0;
        walkDir = walkDir.normalized * walkSpeed;


        //make rigidbody move in direction of input
        rb.linearVelocity = new Vector3(walkDir.x, yVelocity, walkDir.z);
        Debug.Log("Walking in direction: " + walkDir);
    }

    void Attack(InputAction.CallbackContext context)
    {
        
    }
}

