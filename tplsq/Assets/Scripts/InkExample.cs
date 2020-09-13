using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using System;
using UnityEngine.UIElements;

public class InkExample : MonoBehaviour
{
    public GameObject 
        displayText,
        panelText,panelChoice2,panelChoice3,
        choiceButton20, choiceButton21,
        choiceButton30, choiceButton31, choiceButton32,
        imageActor;
    public TextAsset inkJSONAsset;
    private Story story;
    public string text;
    public List<string> tags;
    public List<Choice> listChoice;
    public int listChoiceSize;
    public GameObject ButtonPrefab;
    // Start is called before the first frame update
    void Start()
    {
        story = new Story(inkJSONAsset.text);
        Continue();
    }
    // To continue the ink dialogue
    public void Continue()
    {
        ParseTag();
        listChoice = story.currentChoices;
        listChoiceSize = listChoice.Count;
        if (story.canContinue || listChoiceSize != 0)
        {
            if (listChoiceSize != 0)
            {
                CreateChoiceButton();
            }
            else
            {
                text = story.Continue();
                DisplayText();
            }
        }
        else
        {
            Debug.Log("End Ink");
            return;
        }
    }

    private void CreateChoiceButton()
    {
        if (listChoiceSize == 2)
        {
            ChooseChoice2();

            listChoice = story.currentChoices;

            Choice c0 = listChoice[0];
            Choice c1 = listChoice[1];

            choiceButton20.GetComponent<UnityEngine.UI.Text>().text = c0.text;
            choiceButton21.GetComponent<UnityEngine.UI.Text>().text = c1.text;
        }
        if (listChoiceSize == 3)
        {
            ChooseChoice3();

            listChoice = story.currentChoices;

            Choice c0 = listChoice[0];
            Choice c1 = listChoice[1];
            Choice c2 = listChoice[2];

            choiceButton30.GetComponent<UnityEngine.UI.Text>().text = c0.text;
            choiceButton31.GetComponent<UnityEngine.UI.Text>().text = c1.text;
            choiceButton32.GetComponent<UnityEngine.UI.Text>().text = c2.text;
        }
    }
    public void Choose(int i)
    {
        story.ChooseChoiceIndex(i);
        DisplayText();
    }
    private void ChooseChoice3()
    {
        panelText.gameObject.SetActive(false);
        panelChoice2.gameObject.SetActive(false);
        panelChoice3.gameObject.SetActive(true);
    }
    private void ChooseChoice2()
    {
        panelText.gameObject.SetActive(false);
        panelChoice2.gameObject.SetActive(true);
        panelChoice3.gameObject.SetActive(false);
    }
    private void ChooseText()
    {
        panelText.gameObject.SetActive(true);
        panelChoice2.gameObject.SetActive(false);
        panelChoice3.gameObject.SetActive(false);
    }

    private void ParseTag()
    {
        tags = story.currentTags;
        foreach (string tag in tags)
        {
            string prefix = tag.Split(' ')[0];
            switch (prefix.ToLower())
            {
                case "scene":
                    string scene = tag.Split(' ')[0];
                    Debug.Log("TAG: "+scene);
                    break;
            }
        }
        if(tags.Count != 0)
            if (story.canContinue)
                story.Continue();
        tags = null;
    }

    // DisplayText is called for displaying the current dialogue text
    public void DisplayText()
    {
        if (text.CompareTo("") == 0)
        {
            Continue();
            return;
        }
        ChooseText();
        displayText.GetComponent<UnityEngine.UI.Text>().text = text;
        Debug.Log(text);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
