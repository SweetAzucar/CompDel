using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompAndDel;


namespace CompAndDel.Pipes
{
    public class PipeFork : IPipe
    {
        IPipe next2Pipe;
        IPipe nextPipe;

        IConditionalFilter conditionalFilter;
        /// <summary>
        /// La cañería recibe una imagen, la pasa por un filtro de tipo condicional, si es verdadera la envía a una cañiería, si es falsa, a la segunda
        /// </summary>
        /// <param name="tipoFiltro">Tipo de filtro que se debe aplicar sobre la imagen. Se crea un nuevo filtro con los parametros por defecto</param>
        /// <param name="nextPipe">Siguiente cañeria con filtro</param>
        /// <param name="next2Pipe">Siguiente cañeria sin filtro</param>
        public PipeFork(IConditionalFilter conditionalFilter, IPipe nextPipe, IPipe next2Pipe) 
        {
            this.next2Pipe = next2Pipe;
            this.nextPipe = nextPipe;
            this.conditionalFilter = conditionalFilter;
        }

        /// <summary>
        /// La cañería recibe una imagen, construye un duplicado de la misma, 
        /// y envía la original por una cañería y el duplicado por otra.
        /// </summary>
        /// <param name="picture">imagen a filtrar y enviar a las siguientes cañerías</param>
        public IPicture Send(IPicture picture)
        {
            if (this.conditionalFilter.Condition)
            {
                return this.nextPipe.Send(picture);
            }
            else
            {
                return this.next2Pipe.Send(picture);
            }
        }
    }
}
