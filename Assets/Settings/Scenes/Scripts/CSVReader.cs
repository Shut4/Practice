using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CSVReader : MonoBehaviour
{
    public QuestionData[] questionData;
    // Start is called before the first frame update
    void Start()
    {
        TextAsset textasset = new TextAsset();
        textasset = Resources.Load("CSVQuestionData", typeof(TextAsset)) as textasset;
        questionData = CSVSerializer.Deserialize<QuestionData>(textasset.text);

    }
}
