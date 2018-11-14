<Query Kind="Statements" />

//Another example of duplicate comparison and/or removal if necessary of two different files

List<int> originalList = new List<int>();
List<int> dedupList = new List<int>();
HashSet<int> box = new HashSet<int>();
HashSet<int> dedupBox = new HashSet<int>();
HashSet<int> separates = new HashSet<int>();
foreach (string line in File.ReadLines("C:/Users/me/Documents/temp1.txt"))
{
	originalList.Add(Convert.ToInt32(line));
	box.Add(Convert.ToInt32(line));
}

foreach (string line in File.ReadLines("C:/Users/me/Documents/temp.txt"))
{
	if(box.Contains(Convert.ToInt32(line))){
		dedupBox.Add(Convert.ToInt32(line));
	}else
	{
		separates.Add(Convert.ToInt32(line));
	}
}

separates.Dump();
