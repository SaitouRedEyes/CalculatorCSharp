using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Calculadora
{
    //Class partial para as regras do negócio do form.
    public partial class Form1 : Form  
    {
        private const string PATH = "Save.txt";

        private Calculation c;
        private Http http;
        private float result, currNumber;
        private Dictionary<string, string> parameters;
        private string stringNumber, stringOperation;        
        private bool couldCalculate;

        public Form1()
        {
            currNumber = 0;
            c = new Calculation();
            http = Http.GetInstance();
            parameters = new Dictionary<string, string>();
            couldCalculate = false;
            stringNumber = stringOperation = "";
            
            InitializeComponent();
        }

        //Entro aqui apenas quando clico em um botão numérico.
        private void NumericButtonClick(object sender, EventArgs eventArgs)
        {
            Button b = (Button)sender;

            //Se houver apenas a string 0 na label, substitui o 0 pelo próximo número que será concatenado na instrução abaixo.
            if (lblFeedback.Text.Equals("0")) lblFeedback.Text = "";

            lblFeedback.Text += b.Text;
            stringNumber += b.Text;
            couldCalculate = true;
        }

        //Entro aqui quando clico em uma operação simples matemática.
        private void SimpleMathOpButtonClick(object sender, EventArgs eventArgs)
        {
            Button b = (Button) sender;

            if (!stringNumber.Equals(""))
            {
                currNumber = float.Parse(stringNumber);
                stringNumber = "";
            }

            //Só permito o cálculo se houver números para serem calculados.
            if (couldCalculate)
            {
                //Operações feitas no cliente
                /*if (stringOperation.Equals("+")) result = c.Sum(result, currNumber);
                else if (stringOperation.Equals("-")) result = c.Subtraction(result, currNumber);
                else if (stringOperation.Equals("*")) result = c.Multiplication(result, currNumber);
                else if (stringOperation.Equals("/")) result = c.Division(result, currNumber);
                else result = currNumber;*/

                //Operações feitas no servidor.
                parameters.Add("n1", result.ToString());
                parameters.Add("n2", currNumber.ToString());

                if (stringOperation.Equals("+"))
                {
                    parameters.Add("sID", ((int)Http.Services.SUM).ToString());
                    result = float.Parse(http.SendToServer(parameters));
                }
                else if (stringOperation.Equals("-"))
                {
                    parameters.Add("sID", ((int)Http.Services.SUB).ToString());
                    result = float.Parse(http.SendToServer(parameters));
                }
                else if (stringOperation.Equals("*"))
                {
                    parameters.Add("sID", ((int)Http.Services.MULT).ToString());
                    result = float.Parse(http.SendToServer(parameters));
                }
                else if (stringOperation.Equals("/"))
                {
                    parameters.Add("sID", ((int)Http.Services.DIV).ToString());                    
                    result = float.Parse(http.SendToServer(parameters));
                }
                else result = currNumber;

                parameters.Clear();
                couldCalculate = false;
            }

            stringOperation = b.Text;
            lblFeedback.Text = result.ToString() + " " + b.Text + " ";
        }

        //Entro aqui para calcular fibonacci.
        private void FiboButtonClick(object sender, EventArgs eventArgs)
        {
            //2 casos em que posso calcular fibo: 
            //lblfeedback terminando com vazio significa que possuo apenas um número e um sinal de operação nele;
            //stringOperation vazio e stringNumber não-vazio significa fazer fibo sem ter feito operação alguma antes ou
            //ter feita operação de fibo antes.
            if (lblFeedback.Text.EndsWith(" ") || (stringOperation.Equals("") && !stringNumber.Equals("")))
            {
                result = stringOperation.Equals("") ? c.Fibonacci(int.Parse(stringNumber)) : c.Fibonacci((int)result);
                lblFeedback.Text = stringNumber = result.ToString();
                stringOperation = "";  
            }
        }

        //Entro aqui para leitura e escrita em arquivo txt.
        private void IOButtonClick(object sender, EventArgs eventArgs)
        {
            Button b = (Button)sender;

            //using automaticamente fecha a stream e chama IDisposable.Dispose no objeto stream.
            //isso evita problema de vazamento de dados em instruções de IO. 
            if (b.Text.Equals("Save") && !lblFeedback.Text.Equals(""))
            {
                using (StreamWriter file = new StreamWriter(PATH, true, Encoding.UTF8))
                {
                    file.WriteLine(DateTime.Now + ": " + lblFeedback.Text);
                }
            }
            else
            {
                try
                {
                    using (StreamReader sr = new StreamReader(PATH))
                    {
                        while (sr.Peek() >= 0) Console.WriteLine(sr.ReadLine());
                    }
                }
                catch (Exception e) { Console.WriteLine("Arquivo não pode ser lido. Motivo: " + e.Message); }
            }
        }
    }
}