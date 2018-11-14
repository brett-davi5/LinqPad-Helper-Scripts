<Query Kind="Program" />

void Main()
{
	var result = new List<JoeBob>();
	var result2 = new List<JoeBob>();
	var list = Directory.EnumerateDirectories(@"C:\src\DPISpecifications");
	foreach (var bob in list)
	{
		var tempList = Directory.EnumerateFiles(bob).Where(x=>x.EndsWith(".xslt"));
		foreach (var val in tempList)
		{
			var temporary = File.ReadAllLines(val);
			var count = 0;
			foreach (var holder in temporary)
			{
				count++;
				if (holder.Contains("conduit"))
					result.Add(new JoeBob { FileName = val, Line = holder, LineNumber = count.ToString()});
				
			}
		}
	}
	result.Dump();

}
public class JoeBob
{
	public string FileName { get; set; }
	public string LineNumber { get; set; }
	public string Line { get; set;}
}
// Define other methods and classes here

//0uGaiConjugate

//admin$%234admin