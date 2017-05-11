create database Conferinta;

create table Bilet(
id_bilet int primary key identity(1,1),
pret float,
tip_participant varchar(20),
id_cont int foreign key references Cont(id_cont),
id_conferinta int foreign key references Conferinta(id_conferinta)
)