# ProjectEPI

Este é um aplicativo desenvolvido em .NET Windows Forms, integrado com um banco de dados PostgreSQL, com foco no departamento de segurança do trabalho das empresas, criado para facilitar o acompanhamento da validade dos equipamentos de proteção individual.

# Funcionalidades do projeto

- `Cadastro de Equipamentos`: Permite adicionar, editar e visualizar equipamentos, incluindo informações como CA, nome, status, data de vencimento e setores associados;
- `Cadastro de Setores`: Permite cadastrar setores para associá-los a algum equipamento, facilitando a gestão de forma mais organizada;
- `Notificações Automáticas`: Gera notificações para equipamentos próximos ao vencimento, de acordo com a configuração de tempo definida;
- `Monitor`: Apresenta uma visualização geral para o acompanhamento dos status dos equipamentos.

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
