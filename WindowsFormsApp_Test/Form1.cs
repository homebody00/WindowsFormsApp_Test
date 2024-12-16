using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // textBox_print.Text = "아아아";

            byte teachersInClass = 5;
            short studentsInClass = 15;
            int populationInUS = 330000000;
            float distanceToBusan = 1.23f;
            double distanceToUS = 12.3245;
            decimal sumOfMoneyInWorld = 999999999;

            textBox_print.Text = teachersInClass.GetType().ToString() + "teachersInClass: "+teachersInClass+"\r\n";
            textBox_print.Text += studentsInClass.GetType().ToString() + "studentsInClass: " + studentsInClass + "\r\n";
            textBox_print.Text += populationInUS.GetType().ToString() + "populationInUS: " + populationInUS + "\r\n";
            textBox_print.Text += distanceToBusan.GetType().ToString() + "distanceToBusan: " + distanceToBusan + "\r\n";
            textBox_print.Text += distanceToUS.GetType().ToString() + "distanceToUS: " + distanceToUS + "\r\n";
            textBox_print.Text += sumOfMoneyInWorld.GetType().ToString() + "sumOfMoneyInWorld: " + sumOfMoneyInWorld + "\r\n";

        }
    }
}
