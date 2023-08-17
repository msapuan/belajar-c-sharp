using System;

class DemoVariabel1
{
	static void Main()
	{
		// mendeklrasikan variabel
		int panjang;
		int lebar;
		int luas;

		// mengisi nilai ke dalam variabel
		panjang = 8;
		lebar = 6;

		// melakukan perhitungan dan menampung hasilnya
		// ke dalam variabel luas
		luas = panjang * lebar;

		// menampilkan informasi program
		Console.WriteLine("PERSEGI PANJANG");

		// menampilkan nilai variabel
		Console.WriteLine("panjang = " + panjang);
		Console.WriteLine("lebar = " + lebar);

		// menampilkan hasil perhitungan
		Console.WriteLine("Luas persegi panjang = " + luas);

		Console.ReadLine();
	}
}