using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI text;
    public string[] textArray = {"Hello", "How", "are", "you?"};
    public int index = 0;
    // Update is called once per frame
    public void ChangeText()
    {
        if (index < textArray.Length)
        {
            text.text = textArray[index];
            index++;
        }
        else
        {
            index = 0;
            text.text = textArray[index];
        }
    }
}
