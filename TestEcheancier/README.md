# Introduction 
Doit afficher un �ch�ancier suivant les param�tres fournis.
Il faut 
 - un montant annuel en euros
 - une date de d�but
Puis il faut au choix
 - une date de fin et une p�riodicit� => pour definir que tout les x mois jusqu'a la fin j'ai une �ch�ance.
 - un nombre d'�ch�ance voulu et une p�riodicit� => "je veux 3 �ch�ances de 4 mois"
 - une date de fin et un nombre d'�ch�ance => du 01/01/2023 au 31/12/2023 je veux 4 �ch�ances

Arguments
	- -d : Date d�but format iso 8601 => obligatoire
	- -f : Date fin format iso 8601
	- -p : Periodicit� en mois
	- -n : Nombre d'�ch�ance
	- -m : Montant annuel decimal =>  obligatoire
les arguments sont toujours suivis du symbol "=" suivis de leur valeurs exemple: '-d=2023-09-18'


