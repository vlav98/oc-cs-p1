Le but est de cr�er une petite application qui affiche un message diff�rent en fonction du nom de l�utilisateur et du moment de la journ�e :
	- Bonjour XXX pour la tranche horaire 9h <-> 18h, les lundi, mardi, mercredi, jeudi et vendredi
	- Bonsoir XXX pour la tranche horaire 18h <-> 9h, les lundi, mardi, mercredi, jeudi
	- Bon week-end XXX pour la tranche horaire vendredi 18h <-> lundi 9h

Instructions :
	- DateTime.Now.Hour
	- DateTime.Now.DayOfWeek