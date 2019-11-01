using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
public class UILogic : MonoBehaviour
{
    public Text grades;
    public Text perGrags;
    public string grades10;
    public string[] grades11;
    public double grades12;
    public List <double> grades13;
    public double gradePer;
    public double grade1;
    public InputField input;

    public Text grades2;
    public Text perGrags2;
    public string grades20;
    public string[] grades21;
    public double grades22;
    public List<double> grades23;
    public double gradePer2;
    public double grade2;

    public Text grades3;
    public Text perGrags3;
    public string grades30;
    public string[] grades31;
    public double grades32;
    public List<double> grades33;
    public double gradePer3;
    public double grade3;

    public void getInput()
    
    {
        processText(input.textComponent.text);
        

    }
    public void Update()
    {
        gradePer= Convert.ToDouble(perGrags);
        gradePer2 = Convert.ToDouble(perGrags2);
        grades20 = grades2.text;
        gradePer3 = Convert.ToDouble(perGrags3);
        grades30 = grades3.text;
    }
    public void displayOutput()
    {

        grades11 = grades10.Split(' ');

        //Debug.Log(processedText);

        foreach (string i in grades11)
        {
            grades12 = Convert.ToDouble(i);
            grades13.Add(grades12);
        }
        foreach (double i in grades13)
        {
            grade1 = grade1 + i;

        }
        grade1= (gradePer*(grade1 / grades13.Count));

        grades21 = grades20.Split(' ');

        //Debug.Log(processedText);

        foreach (string i in grades21)
        {
            grades22 = Convert.ToDouble(i);
            grades23.Add(grades22);
        }
        foreach (double i in grades23)
        {
            grade2 = grade2 + i;

        }
        grade2 = (gradePer2 * (grade2 / grades23.Count));

        grades31 = grades30.Split(' ');

        //Debug.Log(processedText);

        foreach (string i in grades31)
        {
            grades32 = Convert.ToDouble(i);
            grades33.Add(grades32);
        }
        foreach (double i in grades33)
        {
            grade3 = grade3 + i;

        }
        grade3 = (gradePer3 * (grade3 / grades33.Count));

        grade1 = ((grade1 + grade2 + grade3)/ (grades13.Count + grades23.Count + grades33.Count));
        grades.text = Convert.ToString(grade1);
        //text.text = InputHandler.getAverageChars(processedText).ToString();
    }
    public void processText(string inS)
    {
        Debug.Log("Before input handler: " + inS);
        //this.processedText = inS;
        this.grades10 = InputHandler.processText(inS);
        
        displayOutput();
        
    }


}
