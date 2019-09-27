using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;


namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureProvider p = new PictureProvider();
            IPicture pic = p.GetPicture("TestImg.jpg"); //consumo imagen

            //Parte 1
            PipeSerial firstSerial = new PipeSerial(new FilterGreyscale(), new PipeSerial(new FilterNegative(), new PipeNull())); //Genero mi series de Pipes
            
            //firstSerial.Send(pic); //envío la pic por la serie de pipes del ejercicio



            //Parte 2
            PipeSerial secondSerial = new PipeSerial(new FilterGreyscale(), 
            new PipeSerial(new FilterSave(), //en este caso entre filtro y filtro guardo la imagen
            new PipeSerial(new FilterNegative(),
            new PipeSerial(new FilterSave(),
            new PipeNull())))); //Genero mi series de Pipes

            //secondSerial.Send(pic); //envio la pic por la serie de pipes de la segunda parte del ejercicio

            //Parte 3

            PipeSerial thirdSerial = new PipeSerial(new FilterGreyscale(), 
            new PipeSerial(new FilterSave(), //en este caso entre filtro y filtro guardo la imagen
            new PipeSerial(new FilterNegative(),
            new PipeSerial(new FilterSave(),
            new PipeSerial(new FilterTwitter(), //publico la imagen con todos los filtros en ucuTW
            new PipeNull()))))); //Genero mi series de Pipes

            //thirdSerial.Send(pic); //envio la pic por la serie de pipes de la tercera parte del ejercicio


            //Parte 4
            PipeSerial fourthSerial = new PipeSerial(new FilterGreyscale(),
            new PipeSerial(new FilterSave(), //guardo 
            new PipeFork(   //ingreso a la bifurcación, fue modificada para primero tener que aplicar el filtro condicional
                new FilterConditionalFace(),    //paso filtro de condición
                new PipeSerial(new FilterTwitter(),     //si es true envío a twitter
                new PipeNull()),
                new PipeSerial(new FilterNegative(),    //serie si es false, primero aplico negativo
                new PipeSerial(new FilterSave(),    //luego de aplicar negativo, guardo
                new PipeNull())))

            ));

            //fourthSerial.Send(pic); //envio la pic por la serie de pipes de la cuarta parte del ejercicio

            //Parte 5 (bonus)
            PipeSerial fifthSerial = new PipeSerial(new FilterBlurConvolution(), //Aplico filtro de convolución
            new PipeSerial(new FilterSave(),    //Guardo la imagen con el filtro aplicada
            new PipeSerial(new FilterTwitter(), //subo la misma a twitter
            new PipeNull())));

            fifthSerial.Send(pic); //envío la pic por la serie de pipes de la quinta parte del ejercicio
        }
    }
}
