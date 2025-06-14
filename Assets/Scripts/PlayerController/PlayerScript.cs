using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
public class PlayerScript : MonoBehaviour

{

    [SerializeField] private string walkInputName;
    private InputAction walkInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.rotation = Quaternion.identity;
        walkInput = InputSystem.actions.FindAction(walkInputName);

        walkInput.performed += Walk;
    }


    private void OnEnable()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 walkDir = walkInput.ReadValue<Vector2>();

        Debug.Log("Walking in direction: " + walkDir);
    }

    void Walk(InputAction.CallbackContext context)
    {
        Debug.Log("Walking");
    }
}

