using System;

class Variabel4
{
	static void CetakNilai()
	{
		// mendeklarasikan variabel dalam blok CetakNilai()
		int a = 10;
		Console.WriteLine("Dalam metode CetakNilai() :");
		Console.WriteLine("a = " + a);
		Console.WriteLine("i dan n tidak dikenal");
		// Console.WriteLine("n = " + n); // salah
		// Console.WriteLine("i = " + i); // salah
	}

	static void Main()
	{
		// mendeklarasikan variabel dalam blok Main()
		int n = 5;

		if (n > 0)
		{
			// mendeklrasikan variabel dalam blok if
			int i = 1;
			Console.WriteLine("Dalam blok if :");
			Console.WriteLine("n = " + n);
			Console.WriteLine("i = " + i);
			Console.WriteLine("a tidak dikenal");
			// Console.WriteLine("a = " + a);  // salah
		}

		Console.WriteLine();
		// memanggil metode CetakNilai()
		CetakNilai();

		Console.WriteLine();
		Console.WriteLine("Dalam metode Main() :");
		Console.WriteLine("n = " + n);
		Console.WriteLine("a dan i tidak dikenal");
		// Console.WriteLine("a = " + a); // salah
		// Console.WriteLine("a = " + a); // salah
		Console.ReadLine();
	}
}
