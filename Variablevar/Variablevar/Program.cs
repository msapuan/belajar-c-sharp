using System;

class DemoVariabel3
{
	static void Main()
	{
		// variabel dengan tipe var
		var a = -1;
		var b = 1.11;

		// manmpilkan nilai awal
		Console.WriteLine("Nilai awal :");
		Console.WriteLine("a = " + a);
		Console.WriteLine("b = " + b);
		Console.WriteLine(); // membuat baris baru

		// menampilkan tipe data dari a dan b
		Console.WriteLine("Tipe data :");
		Console.WriteLine("Tipe a = " + a.GetType());
		Console.WriteLine("Tipe b = " + b.GetType());
		Console.WriteLine(); // membuat baris baru

		// mengubah nilai a dan b
		a = 13;
		b = 4.44;

		// menampilkan nilai akhir
		Console.WriteLine("Nilai setelah diubah :");
		Console.WriteLine("a = " + a);
		Console.WriteLine("b = " + b);
		Console.ReadLine();
	}
}