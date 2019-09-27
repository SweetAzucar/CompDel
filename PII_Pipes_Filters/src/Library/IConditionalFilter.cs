using System;

namespace CompAndDel
{
    /// <summary>
    /// Una interfaz para filtros que sean condicionales
    /// Servirá para hacer cualquier tipo de chequeo sobre una imagen el cual necesite almacenar en un booleano
    /// La interfaz se utiliza en filtros que procesen la imagen para entender si la misma cumple o no una condición
    /// </summary>
    /// <remarks>
    /// Un filtro procesa una imagen, creando opcionalmente una nueva imagen.
    /// </remarks>
    
    public interface IConditionalFilter
    {
        /// <summary>
        /// Procesa la imagen pasada por parametro y retorna la misma imagen o una nueva. Se brinda accesibilidad a un booleano
        /// </summary>
        /// <param name="image">La imagen a procesar</param>
        /// <returns>La misma imagen o una nueva imagen creada por el filtro</returns>
        bool Condition {get; set;}  //bool especial para los tipos de filtros condicionales

    }
}
