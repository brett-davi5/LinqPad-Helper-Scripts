<Query Kind="Statements" />

List<int> originalList = new List<int>();
List<int> dedupList = new List<int>();
HashSet<int> box = new HashSet<int>();
HashSet<int> dedupBox = new HashSet<int>();
HashSet<int> separates = new HashSet<int>();
foreach (string line in File.ReadLines("C:/Users/brett.davis/Documents/ALM Investigations/temp1.txt"))
{
	originalList.Add(Convert.ToInt32(line));
	box.Add(Convert.ToInt32(line));
}

foreach (string line in File.ReadLines("C:/Users/brett.davis/Documents/ALM Investigations/temp.txt"))
{
	if(box.Contains(Convert.ToInt32(line))){
		dedupBox.Add(Convert.ToInt32(line));
	}else
	{
		separates.Add(Convert.ToInt32(line));
	}
}

separates.Dump();