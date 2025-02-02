using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeasurementConverter_V3
{
    public partial class Form1 : Form
    {
        // Definição do dicionário de fatores de conversão
        private Dictionary<string, double> fatorConversao = new Dictionary<string, double>()
        {
            // Base : meters
            {"Meters", 1},
            {"Yards", 0.9144},
            {"Inches", 0.0254},

            // Base : kilos
            {"Kilos" , 1 },
            {"Pounds", 0.453592},

            // No base
            {"Degrees Celsius", 1},
            {"Degrees Fahrenheit", 1},
            {"Kelvin", 1}
        };

        public Form1()
        {
            InitializeComponent();

            // Add the measurements units in the combobox
            cbOrigem.Items.AddRange(new string[]
            {
                "Meters",
                "Yards",
                "Inches",
                "Degrees Celsius",
                "Degrees Fahrenheit",
                "Kelvin",
                "Pounds",
                "Kilos"
            });

            // Set the value of the comboBoxes
            cbOrigem.SelectedIndex = 0;
            cbDestino.Items.AddRange(new string[]
            {
                "Meters",
                "Yards",
                "Inches",
                "Degrees Celsius",
                "Degrees Fahrenheit",
                "Kelvin",
                "Pounds",
                "Kilos"
            });
            cbDestino.SelectedIndex = 1;

            txtValor.TextChanged += ConverterMedida;
            cbOrigem.SelectedIndexChanged += ConverterMedida;
            cbDestino.SelectedIndexChanged += ConverterMedida;
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConverterMedida(object sender, EventArgs e)
        {
            if (!double.TryParse(txtValor.Text, out double valor))
            {
                label5.Text = "Enter a valid number.";
                return;
            }

            else
            {
                label5.Text = "";
            }

            string unidadeOrigem = cbOrigem.SelectedItem?.ToString();
            string unidadeDestino = cbDestino.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(unidadeOrigem) && string.IsNullOrEmpty(unidadeDestino))
                return;

            double resultado = 0;

            if (unidadeOrigem.Contains("Degrees") || unidadeDestino.Contains("Degrees"))
            {
                resultado = ConverterTemperatura(valor, unidadeOrigem, unidadeDestino);
            }
            else
            {
                double valorEmBase = valor * fatorConversao[unidadeOrigem];
                resultado = valorEmBase / fatorConversao[unidadeDestino];

            }

            textBox2.Text = resultado.ToString("F2");
        }


        private double ConverterTemperatura(double valor, string origem, string destino)
        {
            if (origem == destino) return valor;

            if (origem == "Degrees Celsius" && destino == "Degrees Fahrenheit")
                return (valor * 9 / 5) + 32;

            if (origem == "Degrees Celsius" && destino == "Kelvin")
                return valor + 273.15;

            if (origem == "Degrees Fahrenheit" && destino == "Degrees Celsius")
                return (valor - 32) * 5 / 9;

            if (origem == "Degrees Fahrenheit" && destino == "Kelvin")
                return (valor - 32) * 5 / 9 + 273.15;

            if (origem == "Kelvin" && destino == "Degrees Celsius")
                return valor - 273.15;

            if (origem == "Kelvin" && destino == "Degrees Fahrenheit")
                return (valor - 273.15) * 9 / 5 + 32;

            return valor;


        }
    }
}

