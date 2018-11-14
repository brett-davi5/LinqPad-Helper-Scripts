<Query Kind="Statements" />

string response = "{\"lead_campaign_name\":\"api_allwebleads\",\"phone\":\"4789163485\",\"first_name\":\"Dwight\",\"last_name\":\"Allen\",\"email\":\"Dwight.Allen286003@test.net\",\"zip\":\"47715\",\"city\":\"EVANSVILLE\",\"state\":\"IN\",\"external_lead_id\":\"141822377\"}";
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