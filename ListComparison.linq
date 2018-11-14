<Query Kind="Statements" />

//Simple list comparison to go through two files and find/remove duplicates as you see fit


List<int> alm = new List<int>();
List<int> awl = new List<int>();
List<int> similar = new List<int>();
List<int> diff = new List<int>();

foreach (string line in File.ReadLines("C:/Users/me/Documents/value1.txt"))
{
	alm.Add(Convert.ToInt32(line));
}

foreach(string line in File.ReadLines("C:/Users/me/Documents/value2.txt"))
{
	awl.Add(Convert.ToInt32(line));
}

foreach(int num in alm)
{
	if(!awl.Contains(num)){
		diff.Add(num); 
	}
	
}

string alpha = ("Size of diff = " + diff.Count);
alpha.Dump();

//foreach(var item in diff)
//{
//	item.Dump();
//}
