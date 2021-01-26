using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Rechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_BMI_berechnen_Click(object sender, EventArgs e)
        {
            //Überprüfung aktuelle Eingaben
            if (!EingabewertUeberpruefung(Single.Parse(tb_Eingabe_Größe.Text)))
            {
                tb_Rückmeldung_Anwender.Text = "\aFalsche Eingabe der Größe. Bitte versuchen Sie es erneut.";
            }
            else if (!EingabewertUeberpruefung(Single.Parse(tb_Eingabe_Gewicht.Text)))
            {
                tb_Rückmeldung_Anwender.Text = "\aFalsche Eingabe des Gewichts. Bitte versuchen Sie es erneut.";
            }
            else
            {
                //BMI berechnen
                float aktuellerBMI;

                aktuellerBMI = BMIBerechnen(Single.Parse(tb_Eingabe_Größe.Text), Single.Parse(tb_Eingabe_Gewicht.Text));

                string bewertung = BMIAuswerten(aktuellerBMI);

                if (bewertung == "Kein BMI")
                {
                    tb_Rückmeldung_Anwender.Text = "\aWir können keinen BMI berechnen. Ihr BMI liegt entweder unter" +
                        "10 oder über 50. Bitte versuchen Sie es erneut.";
                }
                else
                {
                    //Aktuellen BMI übergeben

                    tb_Rückmeldung_Anwender.Text = "Ihr aktueller BMI liegt bei: " + aktuellerBMI.ToString() +
                        "\nSie haben: " + bewertung +
                        "\n\n" +
                        "\n•	10 <= bmi < 15  => Magersucht" +
                        "\n•	15 <= bmi < 20  => Untergewicht" +
                        "\n•	20 <= bmi < 25  => Normalgewicht" +
                        "\n•	25 <= bmi < 30  => Übergewicht" +
                        "\n•	30 <= bmi < 40  => Fettsucht" +
                        "\n•	40 <= bmi < 50  => morbide Fettsucht ";

                }

            }

        }
        // Methode, um die Eingaben des Anwenders zu überprüfen. 
        public static bool EingabewertUeberpruefung(float wert)
        {
            //Eingabewert darf nicht negativ sein oder größer als das Maximum von float.
            if (wert < 0)
            {
                return false;
            }
            else if (wert > float.MaxValue)
            {
                return false;
            }
            else return true;
        }

        // Methode zur Berechnung des BMI-Werts.
        public static float BMIBerechnen(float groeße, float gewicht)
        {
            float ergebnis = gewicht / (groeße * groeße);
            return ergebnis;
        }

        // Methode zur Auswertung des BMI. Dabei wird dem BMI-Wert eine Diagnose zugeordnet.
        public static String BMIAuswerten(float aktuellerBMI)
        {
            string ergebnis = "Kein BMI";

            if (aktuellerBMI >= 10 && aktuellerBMI < 15)
            {
                ergebnis = "Magersucht";
            }
            if (aktuellerBMI >= 15 && aktuellerBMI < 20)
            {
                ergebnis = "Untergewicht";
            }
            if (aktuellerBMI >= 20 && aktuellerBMI < 25)
            {
                ergebnis = "Normalgewicht";
            }
            if (aktuellerBMI >= 25 && aktuellerBMI < 30)
            {
                ergebnis = "Übergewicht";
            }
            if (aktuellerBMI >= 30 && aktuellerBMI < 40)
            {
                ergebnis = "Fettsucht";
            }
            if (aktuellerBMI >= 40 && aktuellerBMI < 50)
            {
                ergebnis = "morbide Fettsucht";
            }
            return ergebnis;
        }
    }
}
