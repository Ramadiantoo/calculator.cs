class Calculator
{
	static void Main(string[] args);
	{
		int a = 10;
		int b = 6;
			
		console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b. Penambahan(a, b));
		console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b. Pengurangan(a, b));
		
		console.WriteLine("\nTekan sembarang key untuk keluar");
		console.Readkey();
	}
	static int penambahan(int a, int b)
	{
	   return a+b;
	}
	
	static int pengurangan(int a, int b)
	{
	   return a-b;
	}
}
