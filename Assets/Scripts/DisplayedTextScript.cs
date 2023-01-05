using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayedTextScript : MonoBehaviour
{
    // public 
    public GameObject letter;
    
    // private
    private string _textString;
    private float _characterLength = 0.6f;

    private int _currentTypingIndex = 0;
    
    void Start()
    {
        SpawnNewText();
    }
    
    void Update()
    {
        KeyHandler();
        
        
    }

    void SpawnNewText()
    {
        _textString = GetComponent<TextsScript>().GetRandomString();
        float stringLength = _characterLength * _textString.Length;
            
        // get text on screen
        for (int i = 0; i < _textString.Length; i++)
        {
            string currentCharacter = _textString[i].ToString();
            if (currentCharacter == " ")
            {
                currentCharacter = "_";
            }
            letter.GetComponent<TextMesh>().text = currentCharacter;
            GameObject newLetter = Instantiate(letter, 
                new Vector3(_characterLength * i - stringLength / 2, 0, 0), 
                Quaternion.identity);
            newLetter.transform.parent = gameObject.transform;
        }
    }

    void RemoveCurrentText()
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            Destroy(gameObject.transform.GetChild(i).gameObject);
        }
    }

    void KeyHandler()
    {
        if (Input.anyKeyDown)
        {
            string playerInput;
            playerInput = Input.inputString;

            if (playerInput == _textString[_currentTypingIndex].ToString().ToLower())
            {
                Next();
            }
        }
    }

    void Next()
    {
        transform.GetChild(_currentTypingIndex).gameObject.transform.GetComponent<TextMesh>().color = Color.green;
        _currentTypingIndex += 1;

        if (_currentTypingIndex >= _textString.Length)
        {
            _currentTypingIndex = 0;
            RemoveCurrentText();
            SpawnNewText();
        }
    }

    void Wrong()
    {
        
    }
}
