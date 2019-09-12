using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenu()); //Cambio de Arranque de Formulario de Login a Menu
        }

        public static byte[] imagetoByteArray(Image imageIn) //Convertir una Imagen a un arreglo de tipo Byte
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, imageIn.RawFormat);

            return ms.ToArray();
        }
    }
}
