using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextoEnAsteriscosConsola
{
    public class Graficador
    {
        public string ConvertirATexto(string texto)
        {
            texto = texto.ToLower();
            var palabras = texto.Split(' ');
            var resultado = "";

            for (int linea = 0; linea < 5; linea++)
            {
                foreach (var palabra in palabras)
                {
                    foreach (var letra in palabra)
                    {
                        var clave = letra.ToString();
                        if (!Abecedario.Letras.ContainsKey(clave))
                            continue;

                        resultado += Abecedario.Letras[clave][linea] + " ";
                    }
                    resultado += Abecedario.Letras["espacio"][linea];
                }
                resultado += "\n";
            }

            return resultado;
        }
    }
}
