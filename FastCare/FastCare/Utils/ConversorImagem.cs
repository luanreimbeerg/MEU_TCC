using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.Utils
{
    class ConversorImagem
    {
        public byte[] ConverterParaByte(Image imagem)
        {
            if (imagem == null)
                return null;

            using(System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                imagem.Save(ms, imagem.RawFormat);
                return ms.ToArray();
            }
        }

        public Image ConverterParaImagem(byte[] imagem)
        {
            if (imagem == null)
                return null;

            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imagem))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
