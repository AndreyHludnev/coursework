using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private Manager MainManager;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Создание менеджера
            MainManager = new Manager(FactCar_TB, Stat_TB);
            //Установка начальных параметров менеджера
            MainManager.Chance = Convert.ToInt32(Input_NUD.Value);
            MainManager.CountCars = Convert.ToInt32(Count_NUD.Value);
            //Создание очередей автомобилей
            MainManager.AddQueue(new CarsQueue(true, 0, VipWash_LB));
            MainManager.AddQueue(new CarsQueue(true, 1, VipZam_LB));
            MainManager.AddQueue(new CarsQueue(true, 2, VipBal_LB));
            MainManager.AddQueue(new CarsQueue(true, 3, VipProv_LB));
            MainManager.AddQueue(new CarsQueue(false, 0, CommonWash_LB));
            MainManager.AddQueue(new CarsQueue(false, 1, CommonZam_LB));
            MainManager.AddQueue(new CarsQueue(false, 2, CommonBal_LB));
            MainManager.AddQueue(new CarsQueue(false, 3, CommonProv_LB));
            //Создание топливных колонок
            MainManager.AddOperation(new Operation(0, WashCar_TB));
            MainManager.AddOperation(new Operation(1, ZamCar_TB));
            MainManager.AddOperation(new Operation(2, BalCar_TB));
            MainManager.AddOperation(new Operation(3, ProvCar_TB));
        }

        private void Timer_T_Tick_1(object sender, EventArgs e)
        {
            MainManager.OnTimer();
        }



        private void Manual_B_Click_1(object sender, EventArgs e)
        {
            Timer_T_Tick_1(this, e);
        }

         private void SetMod(object sender, EventArgs e)
         {
             Manual_B.Enabled = Manual_RB.Checked;
             Timer_T.Enabled = Auto_RB.Checked;
             Stat_B.Enabled = Manual_RB.Checked;
         }

        private void Input_NUD_ValueChanged_1(object sender, EventArgs e)
        {
            MainManager.Chance = Convert.ToInt32(Input_NUD.Value);
        }

        private void Count_NUD_ValueChanged_1(object sender, EventArgs e)
        {
            MainManager.CountCars = Convert.ToInt32(Count_NUD.Value);
        }

        private void Manual_RB_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Stat_B_Click(object sender, EventArgs e)
        {
            MainManager.SetStatOperation();
        }







    }
}
