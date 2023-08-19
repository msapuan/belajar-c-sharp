using System;

class InputChar
{
	static void Main()
	{
		// deklarasikan variabel dengan tipe datanya
		char c;
		string s;

		Console.Write("Masukkan karakter : ");
		s = Console.ReadLine();

		// konversi tipe string ke karakter
		if (char.TryParse(s, out c))
		{
			Console.WriteLine("Karakter yang dimasukkan adalah '" + c + "'");
		} 
		else
		{
			//Console.WriteLine("Data yang Anda masukkan " +
			//	"tidak dapat dikonversi " +
			//	"ke tipe karakter");
			Console.WriteLine("Karakter yang dimasukkan adalah '" + s + "'");
		}

		Console.ReadLine();
	}
} 