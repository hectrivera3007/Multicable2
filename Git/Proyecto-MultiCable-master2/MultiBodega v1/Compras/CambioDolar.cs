using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Crmf;
using RestSharp;
using RestSharp.Authenticators;
using System.Net.Http;


namespace MultiBodega_v1.Compras
{
    public partial class CambioDolar : Form
    {
        public CambioDolar()
        {
            InitializeComponent();
        }

        /*private void BtnFactorCambiario_Click(object sender, EventArgs e)
        {
            // Crear una instancia de RestClient con la URL base de la API
            var client = new RestClient("https://openexchangerates.org/api");

            // Crear una solicitud GET para obtener los datos del tipo de cambio
            var request = new RestRequest("latest.json");
            request.AddParameter("app_id", "ba4a707784237af193283ddd"); // Reemplazar con tu propia APP ID

            // Realizar la solicitud y obtener la respuesta
            var response = client.Get<ExchangeRatesResponse>(request);

            // Verificar si la respuesta fue exitosa
            //if (response.IsSuccessful)/
            if (response.IsSuccessful)
                {
                // Obtener el tipo de cambio del dólar para Honduras (HNL)
                var exchangeRates = response.Data.Rates;
                if (exchangeRates.ContainsKey("HNL"))
                {
                    var usdToHnlRate = exchangeRates["HNL"];
                    LblFC.Text = $"Tipo de cambio USD a HNL: {usdToHnlRate}";
                }
                else
                {
                    LblFC.Text = "No se encontró el tipo de cambio para HNL";
                }
            }
            else
            {
                LblFC.Text = "Error al obtener los datos del tipo de cambio";
            }
        }

        // Clase para deserializar la respuesta JSON de la API
        public class ExchangeRatesResponse
        {
            public Dictionary<string, decimal> Rates { get; set; }
            public bool IsSuccessful { get; internal set; }
        }*/
    }
}
