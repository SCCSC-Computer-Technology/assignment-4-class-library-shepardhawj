using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Net.Http.Headers;



namespace Shepard_Hawj_CPT_206_A01S_Lab_4_Class_Library
{
    public class StateInfoClass
    {
        //private OleDbConnection myconnection;

        public string[] GetStateInfo(string statenam)
        {
            //textBox1.Text = statenam;
            // stateLabel.Text = statenam;
            string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sheph\\source\\repos\\Shepard-Hawj-CPT-206-A01S-Lab-4-Class-Library\\StateInfoDB.mdf;Integrated Security=True;Connect Timeout=30";
            //Connection
            StateInfoDataDataContext db = new StateInfoDataDataContext(con);
            string[] array = new string[8];

            var results1 = from item in db.StateInformations
                           where item.State_Name.Contains(statenam)
                           select item.State_Flag_Des;
            foreach (string item in results1)
            {
                array[0] = item;
            }

            var results2 = from item in db.StateInformations
                           where item.State_Name.Contains(statenam)
                           select item.State_Capital;
            foreach (string item in results2)
            {
                array[1] = item;
            }

            var results3 = from item in db.StateInformations
                           where item.State_Name.Contains(statenam)
                           select item.State_Larg_Cities;
            foreach (string item in results3)
            {
                array[2] = item;
            }

            var results4 = from item in db.StateInformations
                           where item.State_Name.Contains(statenam)
                           select item.State_Flower;
            foreach (string item in results4)
            {
                array[3] = item;
            }

            var results5 = from item in db.StateInformations
                           where item.State_Name.Contains(statenam)
                           select item.State_Bird;
            foreach (string item in results5)
            {
                array[4] = item;
            }

            var results6 = from item in db.StateInformations
                           where item.State_Name.Contains(statenam)
                           select item.State_Colors;
            foreach (string item in results6)
            {
                array[5] = item;
            }

            var results7 = from item in db.StateInformations
                           where item.State_Name.Contains(statenam)
                           select item.State_Pop;
            foreach (int item in results7)
            {
                array[6] = item.ToString();
            }

            var results8 = from item in db.StateInformations
                           where item.State_Name.Contains(statenam)
                           select item.State_Med_Income;
            foreach (int item in results8)
            {
                array[7] = item.ToString();
            }

            var results9 = from item in db.StateInformations
                           where item.State_Name.Contains(statenam)
                           select item.State_Perc_CompJob;
            foreach (float item in results9)
            {
                array[8] = item.ToString();
            }

            return array;
        }
    }
}
