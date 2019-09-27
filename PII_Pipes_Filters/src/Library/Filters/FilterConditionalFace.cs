using CognitiveCoreUCU;
using System;

namespace CompAndDel.Filters
{
    public class FilterConditionalFace : IConditionalFilter, IFilter
    {
        public bool Condition {get; set;}
        
            
        /// <summary>
        /// Recibe una imagen y la retorna con un filtro de escala de grises aplicado.
        /// </summary>
        /// <param name="image">Imagen a la que se le va a aplicar el filtro.</param>
        /// <returns>Imagen con el filtro aplicado.</returns>
        public IPicture Filter(IPicture image)
        {

            CognitiveFace cog = new CognitiveFace("a36648d3c5134ab692acd35605d491f7", false);
            cog.Recognize(@"savedPic.jpg");


            if (cog.FaceFound)
            {
                this.Condition = true;
            }
            else
            {
                this.Condition = false;
            }

            return image;
        }
    }
}
