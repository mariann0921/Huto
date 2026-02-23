using System.IO;

namespace Huto
{
	internal class Program
	{
		static List<string> huto = new List<string>();

		static void Listazas()
		{
		
			Console.WriteLine("A hűtő tartalma:");
			foreach (var item in huto)
			{
				Console.WriteLine(item.ToLower());
			}
		}
		static void EtelHutobeRakasa()
		{
			string valasz;
			do
			{
				Console.WriteLine("Milyen ételt szeretnél berakni a hűtőbe?");
				valasz = Console.ReadLine();
				if (valasz != "")
				{
					huto.Add(valasz);
				}
			}
			while (valasz != ""); //bennmaradas feltétele. Mikor fusson ujra

		}
		static void FajlbaIras()
		{
			StreamWriter sr = new StreamWriter("huto.txt");
			foreach (var item in huto)
			{
				string s = $"{item.ToLower()}\n";
				sr.Write(s);
			}
			sr.Close();
		}

		static void FajlbeOlvasas()
		{
			StreamReader sr = new StreamReader("huto.txt");
			while (!sr.EndOfStream)
			{
				huto.Add(sr.ReadLine());
			}
			sr.Close();

		}

		static void EtelKivetel()
		{
			Console.WriteLine("Milyen ételt szeretnél kivenni a hűtőből?");
			string etel = Console.ReadLine();
			if (huto.Contains(etel.ToLower())) {
				huto.Remove(etel);
			} 
		}
		static void Main(string[] args)
		{
			char valasz;
			do
			{
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Menu: \n\t1. listázás  \n\t2. Étel berakása a hűtőbe \n\t3. Étel kivétele \n\t4.Fájlbairás\n\t5. FajlBeolvasasa\n\t6 Takarítás\n\t7 kilépés");
				valasz = Console.ReadLine()[0];
				switch (valasz)
				{
					case '1':
						Listazas(); 
						break;
					case '2':
						EtelHutobeRakasa();
						break;
					case '3':
					
						break;

					case '4':
						FajlbaIras();
						break;
					case '5':
						FajlbeOlvasas();
						break;
					case '6':
						huto.Clear();
						Console.WriteLine("A hűtő kiürítve!");
						break;


					case '7':
						Console.WriteLine("Viszlát!");
						FajlbaIras();
						break;
				}
            }
			while (valasz != '6');




		}
	}
}
