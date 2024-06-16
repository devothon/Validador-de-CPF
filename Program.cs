/*
 * Created by SharpDevelop.
 * User: othon
 * Date: 05/06/2024
 * Time: 15:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite seu CPF:");
        string cpf = Console.ReadLine();

        if (ValidarCPF(cpf))
            Console.WriteLine("CPF válido.");
        else
            Console.WriteLine("CPF inválido.");

        Console.Write("Pressione qualquer tecla para continuar . . . ");
        Console.ReadKey(true);
    }

    static bool ValidarCPF(string cpf)
    {
        cpf = cpf.Replace(".", "").Replace("-", "");

        if (cpf.Length != 11 || !long.TryParse(cpf, out _))
            return false;

        int[] multiplicadores = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        // Calcula o primeiro dígito verificador
        int soma = 0;
        for (int i = 0; i < 9; i++)
            soma += int.Parse(cpf[i].ToString()) * multiplicadores[i];
        int digito1 = 11 - (soma % 11);
        if (digito1 >= 10)
            digito1 = 0;

        // Calcula o segundo dígito verificador
        soma = 0;
        for (int i = 0; i < 10; i++)
            soma += int.Parse(cpf[i].ToString()) * multiplicadores[i];
        int digito2 = 11 - (soma % 11);
        if (digito2 >= 10)
            digito2 = 0;

        return cpf.EndsWith(digito1.ToString() + digito2.ToString());
    }
}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}