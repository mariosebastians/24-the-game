using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NumericInputField : MonoBehaviour
{
    private InputField inputField;
    private int maxCharacters = 1;

    private void Start()
    {
        inputField = GetComponent<InputField>();

        inputField.onValidateInput = ValidateInput;
    }

    private char ValidateInput(string text, int charIndex, char addedChar)
    {
        if (text.Length >= maxCharacters)
        {
            return '\0';
        }

        if (char.IsDigit(addedChar))
        {
            return addedChar;
        }

        return '\0';
    }
}
