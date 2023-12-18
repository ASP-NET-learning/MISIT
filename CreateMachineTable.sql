/*CREATE TABLE Machine(
	ID INT PRIMARY KEY IDENTITY(1,1),
	CreateID varchar(255) NOT NULL,
	CreatDate date,
	ModifyDate date,
	ModifyEmployeeID varchar(10),
	MachineID varchar(10) NOT NULL,
	MachineClass char(10),
	MachineName varchar(255),
	SupervisorID varchar(10),
	EmployeeName  varchar(10),
	DepartmentName varchar(10),
	AddTime date,
);

CREATE TABLE NetWork(
    ID INT PRIMARY KEY IDENTITY(1,1),
	CreateID varchar(255) NOT NULL,
	CreatDate date,
	ModifyDate date,
	ModifyEmployeeID varchar(10),
	WifiSSID varchar(255),
	WifiPassword char(20),
	IpAddress char(15),
	SubnetMask char(15),
	Gateway char(15),
	Dns char(15),
);

CREATE TABLE Operations(
    ID INT PRIMARY KEY IDENTITY(1,1),
	CreateID varchar(255) NOT NULL,
	CreatDate date,
	ModifyDate date,
	ModifyEmployeeID varchar(10),
	Open_ char(2),
	Speed char(5),
	Optimization varchar(10)
);

CREATE TABLE Ai(
	ID INT PRIMARY KEY IDENTITY(1,1),
	CreateID varchar(255) NOT NULL,
	CreatDate date,
	ModifyDate date,
	ModifyEmployeeID varchar(10),
	MachineID varchar(10) NOT NULL,
	AlgorithmName  varchar(20),
	HyperparameterName varchar(5),
	CrossName char(1)
);*/

CREATE TABLE AiBom(
	ID INT PRIMARY KEY IDENTITY(1,1),
	CreateID varchar(255),
	CreatDate date,
	ModifyDate date,
	ModifyEmployeeID varchar(10),
	MachineID varchar(10),
	MachineClass char(10),
	MachineName varchar(255),
	SupervisorID varchar(10),
	EmployeeName  varchar(10),
	DepartmentName varchar(10),
	AddTime date,
	WifiSSID varchar(255),
	WifiPassword char(20),
	IpAddress char(15),
	SubnetMask char(15),
	Gateway char(15),
	Dns char(15),
	Open_ char(2),
	Speed char(5),
	Optimization varchar(10),
	AlgorithmName  varchar(20),
	HyperparameterName varchar(5),
	CrossName char(1)
)


-- �b Machine ���s�W�@�����
INSERT INTO Machines (CreateID, CreatDate, ModifyDate, ModifyEmployeeID, MachineID, MachineClass, MachineName, SupervisorID, EmployeeName, DepartmentName, AddTime)
VALUES ('A001', '2023-12-14', NULL, NULL, 'Mach001', '�]�˾�', 'MachineA', 'A001', 'John Doe', 'IT', '2023-12-14');

-- �b NetWork ���s�W�@�����
INSERT INTO NetWork (CreateID, CreatDate, ModifyDate, ModifyEmployeeID, WifiSSID, WifiPassword, IpAddress, SubnetMask, Gateway, Dns)
VALUES ('A001', '2023-12-14', NULL, NULL, 'MyWifi', 'SecretPass', '192.168.1.100', '255.255.255.0', '192.168.1.1', '8.8.8.8');

-- �b Operations ���s�W�@�����
INSERT INTO Operations (CreateID, CreatDate, ModifyDate, ModifyEmployeeID, Open_, Speed, Optimization)
VALUES ('A001', '2023-12-14', NULL, NULL, 'ON', '���t', 'Efficiency');

-- �b Ai ���s�W�@�����
INSERT INTO Ai (CreateID, CreatDate, MachineID, ModifyDate, ModifyEmployeeID, AlgorithmName, HyperparameterName, CrossName)
VALUES ('A001', '2023-12-14', 'Mach001', NULL, NULL, 'Machine Learning', 'LR', 'Y');


SELECT * FROM Machines;
SELECT * FROM NetWork;
SELECT * FROM Operations;
SELECT * FROM Ai;
SELECT * FROM AiBom;

INSERT INTO AiBom (CreateID, CreatDate, ModifyDate, ModifyEmployeeID,
				MachineID, MachineClass, MachineName, SupervisorID, EmployeeName, DepartmentName, AddTime,
				WifiSSID, WifiPassword, IpAddress, SubnetMask, Gateway, Dns,
				Open_, Speed, Optimization,
				AlgorithmName, HyperparameterName, CrossName)
VALUES('A001', '2023-12-14', NULL, NULL,
		'Mach001', '�]�˾�', 'MachineA', 'A001', 'John Doe', 'IT', '2023-12-14',
		'MyWifi', 'SecretPass', '192.168.1.100', '255.255.255.0', '192.168.1.1', '8.8.8.8',
		'ON', '���t', 'Efficiency',
		'Machine Learning', 'LR', 'Y')