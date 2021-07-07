using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_5
{
    public partial class Zadanie_5 : Form
    {
        public Zadanie_5()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public struct User
        {
            public string login;
            public string haslo;

        }

        List<User> users_list = new List<User>();



        private void buttonZarejestruj_Click(object sender, EventArgs e)
        {


            /*    ------Żeby utworzyć konto, Login nie może być pusty, hasła muszą się zgadzać a Checkbox musi być zaznaczony. -----   */


            // Tablica booleanow potrzebna do walidacji

            bool[] goodToGo = new bool[3];

            // login 

            if (textBoxLogin.TextLength == 0)
            {
                labelLogin.Visible = true;

            }
            else
            {
                goodToGo[0] = true;
                labelLogin.Visible = false;
            }

            // hasla

            if ((textBoxHasloRejestracja1.TextLength == 0) || (textBoxHasloRejestracja2.TextLength == 0) || (textBoxHasloRejestracja1.Text != textBoxHasloRejestracja2.Text))
            {
                labelHaslo1.Visible = true;

            }
            else
            {
                goodToGo[1] = true;
                labelHaslo1.Visible = false;
            }

            // checkbox

            if (checkBoxRODO.Checked == false)
            {
                labelRODO.Visible = true;

            }
            else
            {
                goodToGo[2] = true;
                labelRODO.Visible = false;
            }

            // kiedy cała tablica jest ustawiona na 1 wtedy dodaje nowego usera

            if (goodToGo.Contains(false) == false)
            {
                label1.Text = "Dziala";

                // Po zarejestrowaniu wyświetl MessageBox z informacją o poprawnym zarejestrowaniu.

                MessageBox.Show("Dodano Klienta", "Sukces");


                // tutaj jakies dodawanie do kolekcji, potem przy logowaniu uzyje się danych z rejestracji
                users_list.Add(new User() { login = textBoxLogin.Text, haslo = textBoxHasloRejestracja1.Text });

            }

        }


        /*
            W sekcji logowania dodaj tylko Textboxy "Login", "Hasło" i Button "Zaloguj". 
            Pole z hasłem musi ukrywać znaki. Dane muszą należeć do istniejącego konta. 
            Wyświetl MessageBox z powiadomieniem
        */


        private void buttonZaloguj_Click(object sender, EventArgs e)
        {
            bool znaleziono = false; // tego boola potrzebuje do sprawdzenia czy znaleziono usera w foreach-u

            // sprawdzam czy lista jest pusta

            if (users_list.Count == 0 )
            {
                MessageBox.Show("Lista userow jest pusta", "Blad");
            }

            // jesli nie to sprawdzam czy jest taki user

            else
            {
                foreach (var x in users_list)
                {
                    if ((textBoxHasloLogowanie.Text == x.haslo) && (textLogowanie.Text == x.login))
                    {
                        MessageBox.Show("Zalogowano sie na usera ktory zostal zarejestrowany ", "Sukces");
                        znaleziono = true;
                        break;
                    }

                }
                if (znaleziono == false) MessageBox.Show("Brak takeigo usera albo niepoprawne dane", "Blad");
            }


           

        }



    }
}
