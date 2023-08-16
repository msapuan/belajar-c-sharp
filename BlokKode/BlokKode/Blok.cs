using System;

// Blok kode yang berupa namespace
namespace Blok
{
	// Blok kode yang berupa kelas
	class DemoExit
	{
		// Blok kode yang berupa metode
		static void Main(string[] args)
		{
			int n;
			Console.Write("Masukkan nilai n : ");
			string s = Console.ReadLine();

			// Blok kode untuk proses pemilihan statemen
			if (!int.TryParse(s, out n))
			{
				Console.WriteLine("ERROR: n harus berupa " + "bilangan bulat");
				Environment.Exit(1);
			} // Akhir blok pemilihan

			// Blok kode untuk proses pemilihan statemen
			if (n < 0)
			{
				Console.WriteLine("ERROR: n tidak boleh negatif");
				Environment.Exit(1);
			} // Akhir blok pemilihan

			// Blok kode untuk proses pengulangan statemen
			for (int i=0; i<n; i++) {
				Console.WriteLine(i);
			} // Akhir blok pengulangan

		} // Akhir metode
	} // Akhir kelas
} // Akhir namespace