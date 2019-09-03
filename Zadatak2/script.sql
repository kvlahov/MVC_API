
create table DataOtvoreni (
	Id serial primary key,
	WwmsTicketId int,
	OrderStatus varchar(100),
	MiniProjekt varchar(2) check(MiniProjekt in ('da', 'ne')),
	Sektor varchar(10),
	E2eKpi int,
	E2eTrajanje real,
	E2ePreostalo real,
	ServiceOrderProcessId int,
	VrstaUsluge varchar(15),
	VrstaNaloga varchar(30),
	UslugaGrupa varchar(15),
	Identifikator int,
	ElementMreze varchar(100),
	CustomerName varchar(255),
	Segmentacija varchar(100),
	Tehnologija varchar(50),
	InstalationAddress varchar,
	InstalationAddressCounty varchar,
	Regija varchar(10),
	GeografskoPodrucije varchar(20),
	LocationFg varchar(10),
	Lokacija varchar(30),
	Izvod varchar(30),
	VrPodnosenjaZahtjeva date,
	VrOtvaranjaKartice date,
	VrZavrsIspitTehMog date,
	VrPocetkaReal date,
	ServiceTaskName varchar,
	ServiceTaskSubmitDate date,
	TaskDispatchDate date,
	DispatcherName varchar(30),
	ExecutorName varchar(30),
	Odgovoran varchar(20),
	Trajanje real,
	RjKpi int,
	PreostaloVrRj real,
	ServiceTaskStatusDesc varchar(50),
	RazlogParkiranje text,
	PocetakZadnjegParkiranje date,
	BrojPromjenaZeljenogDatuma int,
	ZeljeniDatum date,
	TekstZabiljeske text,
	DatumZabiljeske date,
	IpsKordinator varchar(30),
	Osvjezeno date,
	TaskStatus varchar(10)
);

--ako postoji csv file na disku servera
/*
COPY DataOtvoreni(WwmsTicketId,OrderStatus,MiniProjekt,Sektor,E2eKpi,E2eTrajanje,E2ePreostalo,ServiceOrderProcessId,VrstaUsluge,VrstaNaloga,UslugaGrupa,Identifikator,ElementMreze,CustomerName,Segmentacija,Tehnologija,InstalationAddress,InstalationAddressCounty,Regija,GeografskoPodrucije,LocationFg,Lokacija,Izvod,VrPodnosenjaZahtjeva,VrOtvaranjaKartice,VrZavrsIspitTehMog,VrPocetkaReal,ServiceTaskName,ServiceTaskSubmitDate,TaskDispatchDate,DispatcherName,ExecutorName,Odgovoran,Trajanje,RjKpi,PreostaloVrRj,ServiceTaskStatusDesc,RazlogParkiranje,PocetakZadnjegParkiranje,BrojPromjenaZeljenogDatuma,ZeljeniDatum,TekstZabiljeske,DatumZabiljeske,IpsKordinator,Osvjezeno,TaskStatus) FROM STDIN DELIMITER ',' CSV HEADER NULL '-';
*/
