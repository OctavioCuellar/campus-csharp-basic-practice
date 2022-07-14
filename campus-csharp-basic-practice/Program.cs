using System;
using System.IO;

namespace Countries
{
    internal class Program
    {
        static void Main(string[] args)
        {

			Fail FailCall = new Fail();
			string CurrentDate = DateTime.Today.ToString("yyyy-MMM-dd");
			// Quise usar ruta relativa pero terminé usando ruta absoluta, cambiar a discresión
			string FilePath = @"C:\Users\a875536\OneDrive - Atos\Documents\campus-csharp-basic-practice\campus-csharp-basic-practice\docs\";
			string FileName = $"{FilePath}GreetedCountries {CurrentDate}.txt";

			GreetCountries($"{FilePath}countries.txt", FileName);

			/* Tercer punto
			try
			{
                FailCall.FailMessage();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.Read();
			*/

        }

		// Método para leer el archivo countries.txt y escribir el saludo por cada país
		static void GreetCountries(string inputFile, string outputFile)
		{
			try
			{
				using (StreamReader CountriesInput = new StreamReader(inputFile))
				using (StreamWriter CountriesOutput = new StreamWriter(outputFile))
				{
					string GreetingCountries = CountriesInput.ReadLine();
					while (GreetingCountries != null)
					{
						CountriesOutput.WriteLine($"Saludos hasta {GreetingCountries}!");
						GreetingCountries = CountriesInput.ReadLine();
						// Debug, verificar que funcione el saludo
						Console.WriteLine($"Saludos hasta {GreetingCountries}!");
					}
				}
			}
			catch
				(FileNotFoundException e)
			{
				Console.WriteLine($"Error, el archivo no pudo ser encontrado: {e.Message}");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
