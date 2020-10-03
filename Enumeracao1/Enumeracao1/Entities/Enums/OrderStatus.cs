


namespace Enumeracao1.Entities.Enums
{   //OrderStatus e derivado de um tipo base INT - > heranca
    enum OrderStatus : int // change the type of your project to enum and associate it to INT type
    {
        PendingPayment = 8,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
        //declarar o tipo int associado a cada Enum 
    }


    //Neste caso as enums sao essencias pra mostrarem um tipo String para o usuario passando um valor int para o programa 
    
}
