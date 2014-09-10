using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LearnWebService
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Calculadora : System.Web.Services.WebService
    {
        [WebMethod]
        public string Hello()
        {
            return "Olá mundo WebService!";
        }

        [WebMethod]
        public string Chamar()
        {
            return "Chamando WebService.";
        }

        [WebMethod]
        public string RealizaCalculo(string Operacao, string ValorUm, string ValorDois)
        {
            string RetornoCalculo = "";

            switch(Operacao)
            {
                case "Soma":
                    Int32 Soma = Convert.ToInt32(ValorUm) + Convert.ToInt32(ValorDois);
                    RetornoCalculo = Convert.ToString(Soma);
                    break;

                case "Subtracao":
                    Int32 Subtracao = Convert.ToInt32(ValorUm) - Convert.ToInt32(ValorDois);
                    RetornoCalculo = Convert.ToString(Subtracao);
                    break;

                case "Multiplicacao":
                    Int32 Multiplicacao = Convert.ToInt32(ValorUm) * Convert.ToInt32(ValorDois);
                    RetornoCalculo = Convert.ToString(Multiplicacao);
                    break;

                case "Divisao":
                    Int32 Divisao = Convert.ToInt32(ValorUm) / Convert.ToInt32(ValorDois);
                    RetornoCalculo = Convert.ToString(Divisao);
                    break;
            }

            return RetornoCalculo;
        }
    }
}
