using TwitterUCU;

namespace CompAndDel.Filters
{
    public class FilterTwitter : IFilter
    {
        /// <summary>
        /// Recibe una imagen y la retorna con un filtro de escala de grises aplicado.
        /// </summary>
        /// <param name="image">Imagen a la que se le va a aplicar el filtro.</param>
        /// <returns>Imagen con el filtro aplicado.</returns>
        public IPicture Filter(IPicture image)
        {
            string consumerKey = "g7rkPB5uI2xOqELAhlNrorSU4";
            string consumerKeySecret = "8hOTyS71GrTH9Ool3rXykAJRY5AmgSPiy78b1wYUPcvfIzXeEc";
            string accessTokenSecret = "eAut3eKlWwBB0o1BfTRLaRBfOgXF6WriMKwpkevgf7C2t";
            string accessToken = "1396065818-9Q6o38qm99WQywFeqrJFTfs7DFAhI4LvjoJvFRk";
            var twitter = new TwitterImage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            twitter.PublishToTwitter("Arte UCU!!!",@"savedPic.jpg"); //juega con que tengo que si osi utilizar la solución de guardar la imagen antes de ejecutar este filtro
          
            return image;
        }
    }
}
