using System;
class Program
{
    static bool DigitoVer(int[] num )
    {
        int soma = 0;
        int  j =10;
        int ver1;
        for (int i = 0; i<9; i++)
        {
            soma += num[i] * j;
            j -= 1;
          
        }
        int resto = soma % 11;

        if (resto < 2)
        {
            ver1 = 0;
        }
        else { 
            ver1 = 11 - resto;
             }
        return (num[9] == ver1);
       
    }
    static bool DigitoVer2(int[] num )
    {
      int  soma = 0;
      int j = 11;
      int ver2;
        for (int i = 0; i < 10; i++)
        {
            soma += num[i] * j;
            j -= 1;

        }
       int  resto = soma % 11;

        if (resto < 2)
        {
            ver2 = 0;
        }
        else
        { 
            ver2 = 11 - resto;
        }
        return (num[10] == ver2);
    }
    

    static void Main(string[] args)
    {
        string cpf;
        bool valido;
        Console.WriteLine("digite o cpf");
        cpf = Console.ReadLine();
        int[] Dig = new int[cpf.Length]; 
        for (int i = 0; i < cpf.Length; i++)
        {
            Dig[i] = cpf[i] - '0';
        }
        valido = valido = DigitoVer(Dig) && DigitoVer2(Dig);
        if (valido == true)
        {
            Console.WriteLine("cpf valido");
        }
        else
        {
            Console.WriteLine("cpf invalido");
        }

    }

}
