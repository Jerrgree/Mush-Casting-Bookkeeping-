function AnalyzeCasting()
{
	var users = document.getElementsByClassName('nameUnit');
	var ListOfReadiedUsers = [];
	var ListOfIdleUsers = [];
	var ListOfPlayingUsers = [];

	for (var i = 0; i < users.length; i++)
	{
		var userData = users[i].children[0].children[0];
		var userImage = users[i].children[1];
		if (userImage.src == 'http://mush.twinoid.com/img/icons/ui/ready.png')
		{
			ListOfReadiedUsers.push({
				'id' : userData.href,
				'name' : userData.text.trim()})
		}
	}

	return(ListOfReadiedUsers);
}

AnalyzeCasting();