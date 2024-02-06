using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public InputField[] inputFields;
    public Button nextBtn;
    public Text outputHasil;
    public Image img;

    private void Start()
    {
        Button btn = GetComponent<Button>();
        img.gameObject.SetActive(false);
        nextBtn.gameObject.SetActive(false);
        for (int i = 0; i < inputFields.Length; i++)
        {
            int index = i;
            inputFields[i].onEndEdit.AddListener(text => OnInputEndEdit(index, text));
        }
    }

    private void OnInputEndEdit(int index, string text)
    {
        Debug.Log($"Input Field {index + 1}: {text}");
    }

    private void Calculate()
    {
        nextBtn.gameObject.SetActive(false);
        img.gameObject.SetActive(false);
        int[] temp2 = new int[10];
        int calcu = 0;
        for (int i = 0; i < inputFields.Length; i++)
        {
            string temp = inputFields[i].text;
            temp2[i] = int.Parse(temp);
            calcu += temp2[i];
        }
        nextBtn.gameObject.SetActive(calcu == 24);
        img.gameObject.SetActive(calcu == 24);
        outputHasil.text = calcu.ToString();
    }

    private void Update()
    {
        Calculate();
    }
}
