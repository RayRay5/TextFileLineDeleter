using System;
using System.Text;
using System.IO;
using System.Threading;
using System.Linq;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;

public class DeleteLines
{
	// <author>
	// https://github.com/RayRay5
	// </author>
	
	//File f = null;
	
	static void Main(string[] args)
	{
		if(args.Length < 3 || args.Length > 3)
		{
			Thread t = new Thread(() => MessageBox.Show("Ungültige Parameterzahl"));
			t.Start();
			return;
		}
		Int32 lower = Int32.Parse(args[1]);
		Int32 upper = Int32.Parse(args[2]);
		lower--;
		upper--;
		string[] lines = File.ReadAllLines(args[0]);
		
		Console.WriteLine("lower: " + lower + " | upper: " + upper);
		StreamWriter file = new StreamWriter("edited" + args[0]);
		//f = new File(args[0]);
		
		string text = "";
		
		for(int i = 0; i < lines.Length; ++i)
		{
			Console.WriteLine("i: " + i);
			if(i >= lower && i <= upper)
			{
				
			}
			else
			{
				//Console.WriteLine("innen mit i = " + i);
				Console.WriteLine(lines[i]);
				
				text += lines[i];
				text += Environment.NewLine;
				
				

				//File.WriteLine(args[0], lines[i] + "\r\n");
			}
		}
		
		File.WriteAllText(args[0], text);
		
	}
}