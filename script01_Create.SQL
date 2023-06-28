IF OBJECT_ID(N'[__EFMigrationsHistory02]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory02] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory02] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Integrantes] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NULL,
    CONSTRAINT [PK_Integrantes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Projetos] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NULL,
    [Materia] int NOT NULL,
    [Prazo] datetime2 NOT NULL,
    [Inicio] datetime2 NOT NULL,
    CONSTRAINT [PK_Projetos] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Temas] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NULL,
    [ProjetoId] int NOT NULL,
    [IntegranteId] int NOT NULL,
    CONSTRAINT [PK_Temas] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Temas_Integrantes_IntegranteId] FOREIGN KEY ([IntegranteId]) REFERENCES [Integrantes] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Temas_Projetos_ProjetoId] FOREIGN KEY ([ProjetoId]) REFERENCES [Projetos] ([Id]) ON DELETE CASCADE
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Nome') AND [object_id] = OBJECT_ID(N'[Integrantes]'))
    SET IDENTITY_INSERT [Integrantes] ON;
INSERT INTO [Integrantes] ([Id], [Nome])
VALUES (1, N'Alex Vitor'),
(2, N'Antonio Mauricio'),
(3, N'Breno Lisboa'),
(4, N'Gustavo Leite'),
(5, N'Rafael Thomas'),
(6, N'Vitor Silva');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Nome') AND [object_id] = OBJECT_ID(N'[Integrantes]'))
    SET IDENTITY_INSERT [Integrantes] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Inicio', N'Materia', N'Nome', N'Prazo') AND [object_id] = OBJECT_ID(N'[Projetos]'))
    SET IDENTITY_INSERT [Projetos] ON;
INSERT INTO [Projetos] ([Id], [Inicio], [Materia], [Nome], [Prazo])
VALUES (1, '2023-06-09T00:00:00.0000000', 2, N'RotaLimpa', '2023-06-23T00:00:00.0000000'),
(2, '2023-06-08T00:00:00.0000000', 4, N'Finalização do frontend', '2023-06-22T00:00:00.0000000'),
(3, '2023-06-13T00:00:00.0000000', 6, N'OrganizEtec', '2023-06-20T00:00:00.0000000'),
(4, '2023-06-14T00:00:00.0000000', 3, N'React Native', '2023-06-21T00:00:00.0000000'),
(5, '2023-06-12T00:00:00.0000000', 1, N'Atividade BD', '2023-06-19T00:00:00.0000000');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Inicio', N'Materia', N'Nome', N'Prazo') AND [object_id] = OBJECT_ID(N'[Projetos]'))
    SET IDENTITY_INSERT [Projetos] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'IntegranteId', N'Nome', N'ProjetoId') AND [object_id] = OBJECT_ID(N'[Temas]'))
    SET IDENTITY_INSERT [Temas] ON;
INSERT INTO [Temas] ([Id], [IntegranteId], [Nome], [ProjetoId])
VALUES (1, 1, N'Criar uma pagina a sua ecolha', 2),
(2, 1, N'Finalizar atividade do dia 12/06', 5),
(3, 1, N'Finalizar projeto do da API', 3),
(4, 1, N'Narrativa Caso de Uso 1/2', 1),
(5, 4, N'Narrativa Caso de Uso 2/2', 1),
(6, 2, N'Sprint 03 - Apresentação Diagramas UML 1 1/2', 1),
(7, 6, N'Sprint 03 - Apresentação Diagramas UML 1 2/2', 1),
(8, 1, N'Diagrama de Classe 1/2', 1),
(9, 4, N'Diagrama de Classe 2/2', 1),
(10, 4, N'Modelo Lógico BD 1/2', 1),
(11, 5, N'Modelo Lógico BD 2/2', 1),
(12, 1, N'Scripts BD 1/2', 1),
(13, 2, N'Scripts BD 2/2', 1),
(14, 2, N'Sprint 04 - Apresentação Diagramas UML 1 1/2', 1),
(15, 6, N'Sprint 04 - Apresentação Diagramas UML 1 2/2', 1),
(16, 3, N'Logo da Empresa 1/2', 1),
(17, 5, N'Logo da Empresa 2/2', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'IntegranteId', N'Nome', N'ProjetoId') AND [object_id] = OBJECT_ID(N'[Temas]'))
    SET IDENTITY_INSERT [Temas] OFF;
GO

CREATE INDEX [IX_Temas_IntegranteId] ON [Temas] ([IntegranteId]);
GO

CREATE INDEX [IX_Temas_ProjetoId] ON [Temas] ([ProjetoId]);
GO

INSERT INTO [__EFMigrationsHistory02] ([MigrationId], [ProductVersion])
VALUES (N'20230616221617_Create', N'7.0.7');
GO

COMMIT;
GO

