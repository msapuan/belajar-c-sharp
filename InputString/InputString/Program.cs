using System;

class InputString
{
	static void Main()
	{
		string nama;

		Console.Write("Masukkan nama Anda : ");
		nama = Console.ReadLine();

		Console.WriteLine("Halo " + nama + ", Selamat datang di dunia pemrograman C#");
		Console.ReadLine();
	}
}