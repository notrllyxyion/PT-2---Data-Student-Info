using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class StudentDataManager : MonoBehaviour
{
    public InputField nameInput;
    public InputField ageInput;
    public InputField studentnumberinput;
    public InputField studentSection;
    public Text resultText;
    public InputField searchInput;

    //Save student Data
    public void SaveStudentData()
    {
        string studentName = nameInput.text;
        int age;
        int studentNumber;  
        string Section = studentSection.text;
        //Check uf fuekds are not empty and parse values
        if (!string.IsNullOrEmpty(studentName) && int.TryParse(ageInput.text, out age) && int.TryParse(studentnumberinput.text, out studentNumber) && !string.IsNullOrEmpty(Section))
        {
            PlayerPrefs.SetInt (studentName + "Age", age);
            PlayerPrefs.SetInt (studentName + "Student Number", studentNumber);
            PlayerPrefs.SetString (studentName + "Student Section", Section);
            PlayerPrefs.Save ();
            Debug.Log("Student Data Saved!!" + studentNumber);
        }
        else
        {
            Debug.Log("Invalid Student");
        }
    }
    //Loading for student Data
    public void LoadStudentData()
    {
        string studentName = searchInput.text;
        if (PlayerPrefs.HasKey(studentName + "Age"))
        {
            int age = PlayerPrefs.GetInt(studentName + "Age");
            int studentNumber = PlayerPrefs.GetInt(studentName + "Student Number");
            string Section = PlayerPrefs.GetString(studentName + "Student Section");
           resultText.text = $"Name {studentName} \n Age: {age} \n SN: {studentNumber} \n Section: {Section}";
        
        }
        else
        {
            resultText.text = "Student Not Found!";
        }
    }
}
