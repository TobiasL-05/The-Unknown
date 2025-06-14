using UnityEngine;
using UnityEngine.InputSystem;

public class AttackScript : MonoBehaviour
{
    [SerializeField] private string attackInputName;

    private InputAction attackInput;


    void Start()
    {
        attackInput = InputSystem.actions.FindAction(attackInputName);

        attackInput.performed += Attack;
    }


    void Update()
    {

    }


    void Attack(InputAction.CallbackContext context)
    {
        Debug.Log("Attacking");
    }
}