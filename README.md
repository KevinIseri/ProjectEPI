# ProjectEPI

Este aplicativo foi desenvolvido em .NET Windows Forms, integrado ao banco de dados PostgreSQL, com o objetivo de atender às necessidades do departamento de segurança do trabalho nas empresas. Ele facilita o gerenciamento e monitoramento da validade dos Equipamentos de Proteção Individual (EPIs), garantindo o acompanhamento contínuo do status e vencimento, além de emitir notificações automáticas para equipamentos próximos ao vencimento, assegurando a conformidade e segurança dos colaboradores.

# Funcionalidades do projeto

- `Cadastro de Equipamentos`: Permite adicionar, editar e visualizar equipamentos, incluindo informações como identificador "CA", nome, status, data de vencimento e setores associados;
- `Cadastro de Setores`: Permite cadastrar setores para associá-los a algum equipamento, facilitando a gestão de forma mais organizada e segmentada;
- `Notificações Automáticas`: Gera notificações para equipamentos próximos ao vencimento, de acordo com a configuração de tempo definida;
- `Monitoramento`:  Oferece uma visão geral do status dos equipamentos, facilitando o acompanhamento em tempo real e a tomada de decisões..

# Tecnologias utilizadas

- .NET 8.0 / Windows Forms;
- PostgreSQL;
- Biblioteca Npgsql (para interação com o banco de dados).

# Configuração do Banco de dados

CREATE TABLE Users (
Id BIGSERIAL PRIMARY KEY,
UserName VARCHAR(100) null,
Password VARCHAR(100) null,
Created_Date TIMESTAMP NULL,
Updated_Date TIMESTAMP NULL
);

CREATE TABLE Equipments (
Id BIGSERIAL PRIMARY KEY,
Ca VARCHAR(100) NOT NULL,
Description text NULL,
IsActive BOOLEAN NOT NULL,
Name VARCHAR(100) NOT NULL,
Status VARCHAR(50) NOT NULL,
Handling_Status VARCHAR(50) NULL
Maturity_Date TIMESTAMP NOT NULL,
Created_Date TIMESTAMP NULL,
Updated_Date TIMESTAMP NULL
);

CREATE TABLE Sectors (
Id BIGSERIAL PRIMARY KEY,
Name VARCHAR(100) NOT null,
Created_Date TIMESTAMP NULL,
Updated_Date TIMESTAMP NULL
);

CREATE TABLE EquipmentSector (
EquipmentId BIGINT NOT NULL,
SectorId BIGINT NOT NULL,
PRIMARY KEY (EquipmentId, SectorId),
FOREIGN KEY (EquipmentId) REFERENCES Equipments(Id) ON DELETE CASCADE,
FOREIGN KEY (SectorId) REFERENCES Sectors(Id) ON DELETE CASCADE
);

CREATE TABLE Notifications (
Id BIGSERIAL PRIMARY KEY,
EquipmentId BIGINT NOT NULL,
Created_Date TIMESTAMP NULL,
Updated_Date TIMESTAMP null,
FOREIGN KEY (EquipmentId) REFERENCES Equipments(Id) ON DELETE CASCADE
);

CREATE TABLE Settings (
Id BIGSERIAL PRIMARY KEY,
Key VARCHAR(100) NOT NULL,
Value VARCHAR(100) NOT null,
Created_Date TIMESTAMP NULL,
Updated_Date TIMESTAMP null
);
