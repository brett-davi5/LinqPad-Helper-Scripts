<Query Kind="Statements" />

//parses out a json string object and separates them by commas into a string array
//then for each item in the array, it splits them further into a mini array by the colon (:)
//from here it cleans up each item in this mini array (trim, lowercase, remove...whatever you want)
//then it rebuilds it into a new string to be returned

string response = "{\"phone\":\"4789163485\",\"first_name\":\"Billy\",\"last_name\":\"Bob\",\"email\":\"billyBob@gmail.com\",\"zip\":\"47715\",\"city\":\"Wherever\",\"state\":\"IN\",\"external_id\":\"1111111\"}";
string[] temp1 = response.Split(',');
string result = "";
foreach(var stuff in temp1){
	string[] newStuff = stuff.Split(':');
	string tempResult = "";
	foreach (var element in newStuff)
	{
		tempResult += element.Trim() + ":";
		element.Dump();
	}
	
	result += tempResult.TrimEnd(':') + ',';
	result.Dump();
}

result.TrimEnd(',').Dump();
