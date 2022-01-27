int x = 100;
double y = x; //conversão implicita: 100.00

double z = 100.38;
int zy = (int)z;//conversão explicita: 100



new ImplicitOperator().ImplicitOperatorTipoComplexoParaString();
new ImplicitOperator().ImplicitOperatorStringParaTipoComplexo();


public class Phone
{
    public string CountryCode { get; set; }
    public string Number { get; set; }
    public string Area { get; set; }

    public override string ToString()
    {
        return $"+{CountryCode} ({Area}) {Number}";
    }

    public static implicit operator string(Phone phone)=> $"+{phone.CountryCode} ({phone.Area}) {phone.Number}";

    public static implicit operator Phone(string phone) 
    { 
        var data = phone.Split(" ");

        return new Phone
        {
            CountryCode = data[0],
            Area = data[1],
            Number = data[2]
        };
    }
}

public class ImplicitOperator
{
    public  void ImplicitOperatorTipoComplexoParaString()
    {
        var phone = new Phone
        {
            CountryCode = "55",
            Area = "13",
            Number = "99139138"
        };

        var telefone = "123";
        telefone = phone;

        Console.WriteLine(telefone);
    }

    public void ImplicitOperatorStringParaTipoComplexo()
    {
        var phone = new Phone();      
                
        phone = "55 11 991580228";

        Console.WriteLine(phone);
    }
}