using Spire.Barcode;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.APIs
{
    class ApiBarCode
    {
        // Esse plugin usa o NuGET Spire.Barcode

        public Image SalvarCodigoBarras(string mensagem, string arquivo = null)
        {
            // Configura Codigo de Barras
            BarcodeSettings config = new BarcodeSettings();
            config.ShowText = false;
            config.ShowTopText = false;
            config.ShowCheckSumChar = false;
            config.ShowTextOnBottom = false;
            config.ShowStartCharAndStopChar = false;

            // Atribui valor ao Codigo de Barras
            config.Data = mensagem;

            // Gera o Codigo de Barras
            BarCodeGenerator barcode = new BarCodeGenerator(config);
            Image code = barcode.GenerateImage();

            // Salva Imagem
            if (!string.IsNullOrEmpty(arquivo))
                code.Save(arquivo.Replace(".png", "") + ".png", ImageFormat.Png);

            // Retorna Imagem Codigo de Barras
            return code;
        }


        public string LerCodigoBarras(string arquivo)
        {
            // Lê Código de Barras
            string[] dado = BarcodeScanner.Scan(arquivo);
            return dado[0];
        }

        public string LerCodigoBarras(Image arquivo)
        {
            // Lê Código de Barras
            string[] dado = BarcodeScanner.Scan(new Bitmap(arquivo));
            return dado[0];
        }
    }
}
