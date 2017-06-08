Pasi in pornirea aplicatiei: 
 - se cloneaza repository-ul
 - se copiaza stringul de conectare din sql server in fisierele App.config din toate proiectele
 - se deschide Package Manager Console (View-Other Windows-Package Manager Console)
 - se tasteaza add-migration [nume] si se asteapta rezultatul (un mesaj scris cu galben si un nou fisier creat)
 - se tasteaza update-database si se asteapta pana apare mesajul "Running seed method."
 - intrucat aplicatia arunca exceptii de la server la client nu trebuie pornite ambele din visual studio!!!
Se porneste atat serverul,cat si clientul din folderul bin.
