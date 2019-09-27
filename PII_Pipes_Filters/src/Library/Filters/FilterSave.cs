using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CompAndDel;
using System.Diagnostics;

namespace CompAndDel.Filters
{
    public class FilterSave : IFilter
    {
        /// <summary>
        /// Recibe una imagen y la retorna con un filtro de escala de grises aplicado.
        /// </summary>
        /// <param name="image">Imagen a la que se le va a aplicar el filtro.</param>
        /// <returns>Imagen con el filtro aplicado.</returns>
        public IPicture Filter(IPicture image)
        {

            PictureProvider p = new PictureProvider();
            p.SavePicture(image, "savedPic.jpg");
            return image;
        }
    }
}
