 

create database [SistemaAlumnosUPC]
go

use [SistemaAlumnosUPC]
go

CREATE TABLE [dbo].[Alumno](
	[IdAlumno] [int] NOT NULL PRIMARY KEY ,
	[Nombres] [nvarchar](3000) NULL,
	[Apellidos] [nvarchar](3000) NULL
) ON [PRIMARY]
GO

INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (1, N'Luis', N'Gonzales')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (2, N'Jose', N'Gonzales')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (3, N'Adrian', N'Gonzales')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (4, N'Leonardo', N'Gonzales')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (5, N'Adriana', N'Gonzales')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (6, N'Manuel', N'Gonzales')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (7, N'Rocio', N'Gonzales')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (8, N'Diana', N'Gonzales')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (9, N'Mayra', N'Gonzales')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (10, N'Gina', N'Gonzales')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (11, N'Maribel', N'Gonzales')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (12, N'Esperanza', N'Gonzales')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (13, N'Alejandra', N'Gonzales')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (14, N'Alejandro', N'Gonzales')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (15, N'Javier', N'Gonzales')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (16, N'Jackelyne', N'Gonzales')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (17, N'Jack', N'Gonzales')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (18, N'Walter', N'Gonzales')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (19, N'Andrei', N'Gonzales')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (20, N'Luis', N'Castillo')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (21, N'Jose', N'Castillo')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (22, N'Adrian', N'Castillo')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (23, N'Leonardo', N'Castillo')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (24, N'Adriana', N'Castillo')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (25, N'Manuel', N'Castillo')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (26, N'Rocio', N'Castillo')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (27, N'Diana', N'Castillo')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (28, N'Mayra', N'Castillo')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (29, N'Gina', N'Castillo')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (30, N'Maribel', N'Castillo')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (31, N'Esperanza', N'Castillo')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (32, N'Alejandra', N'Castillo')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (33, N'Alejandro', N'Castillo')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (34, N'Javier', N'Castillo')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (35, N'Jackelyne', N'Castillo')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (36, N'Jack', N'Castillo')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (37, N'Walter', N'Castillo')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (38, N'Andrei', N'Castillo')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (39, N'Luis', N'Vazques')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (40, N'Jose', N'Vazques')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (41, N'Adrian', N'Vazques')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (42, N'Leonardo', N'Vazques')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (43, N'Adriana', N'Vazques')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (44, N'Manuel', N'Vazques')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (45, N'Rocio', N'Vazques')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (46, N'Diana', N'Vazques')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (47, N'Mayra', N'Vazques')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (48, N'Gina', N'Vazques')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (49, N'Maribel', N'Vazques')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (50, N'Esperanza', N'Vazques')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (51, N'Alejandra', N'Vazques')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (52, N'Alejandro', N'Vazques')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (53, N'Javier', N'Vazques')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (54, N'Jackelyne', N'Vazques')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (55, N'Jack', N'Vazques')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (56, N'Walter', N'Vazques')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (57, N'Andrei', N'Vazques')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (58, N'Luis', N'Pacheco')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (59, N'Jose', N'Pacheco')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (60, N'Adrian', N'Pacheco')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (61, N'Leonardo', N'Pacheco')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (62, N'Adriana', N'Pacheco')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (63, N'Manuel', N'Pacheco')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (64, N'Rocio', N'Pacheco')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (65, N'Diana', N'Pacheco')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (66, N'Mayra', N'Pacheco')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (67, N'Gina', N'Pacheco')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (68, N'Maribel', N'Pacheco')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (69, N'Esperanza', N'Pacheco')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (70, N'Alejandra', N'Pacheco')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (71, N'Alejandro', N'Pacheco')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (72, N'Javier', N'Pacheco')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (73, N'Jackelyne', N'Pacheco')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (74, N'Jack', N'Pacheco')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (75, N'Walter', N'Pacheco')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (76, N'Andrei', N'Pacheco')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (77, N'Luis', N'Leon')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (78, N'Jose', N'Leon')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (79, N'Adrian', N'Leon')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (80, N'Leonardo', N'Leon')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (81, N'Adriana', N'Leon')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (82, N'Manuel', N'Leon')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (83, N'Rocio', N'Leon')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (84, N'Diana', N'Leon')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (85, N'Mayra', N'Leon')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (86, N'Gina', N'Leon')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (87, N'Maribel', N'Leon')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (88, N'Esperanza', N'Leon')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (89, N'Alejandra', N'Leon')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (90, N'Alejandro', N'Leon')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (91, N'Javier', N'Leon')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (92, N'Jackelyne', N'Leon')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (93, N'Jack', N'Leon')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (94, N'Walter', N'Leon')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (95, N'Andrei', N'Leon')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (96, N'Luis', N'Flores')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (97, N'Jose', N'Flores')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (98, N'Adrian', N'Flores')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (99, N'Leonardo', N'Flores')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (100, N'Adriana', N'Flores') 
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (101, N'Manuel', N'Flores')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (102, N'Rocio', N'Flores')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (103, N'Diana', N'Flores')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (104, N'Mayra', N'Flores')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (105, N'Gina', N'Flores')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (106, N'Maribel', N'Flores')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (107, N'Esperanza', N'Flores')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (108, N'Alejandra', N'Flores')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (109, N'Alejandro', N'Flores')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (110, N'Javier', N'Flores')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (111, N'Jackelyne', N'Flores')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (112, N'Jack', N'Flores')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (113, N'Walter', N'Flores')
INSERT [dbo].[Alumno] ([IdAlumno], [Nombres], [Apellidos]) VALUES (114, N'Andrei', N'Flores')
GO
  
CREATE TABLE [dbo].[Solicitud](
	[IdSolicitud] [int] NOT NULL PRIMARY KEY ,
	[IdAlumno] [int] FOREIGN KEY REFERENCES Alumno(IdAlumno) ,
	[FechaSolicitud] datetime  NULL,
	[CodRegistrante] [nvarchar](255) NULL,
	[Carrera] [nvarchar](255) NULL,
	[Periodo] [nvarchar](255) NULL
) ON [PRIMARY]
GO



INSERT [dbo].[Solicitud] ([IdSolicitud], [IdAlumno], [FechaSolicitud],[CodRegistrante],[Carrera],[Periodo]) VALUES (1,1,getdate(),N'SISTEMA','Marketing','202101')
INSERT [dbo].[Solicitud] ([IdSolicitud], [IdAlumno], [FechaSolicitud],[CodRegistrante],[Carrera],[Periodo]) VALUES (2,5,getdate(),N'SISTEMA','Filosofía','202102')
INSERT [dbo].[Solicitud] ([IdSolicitud], [IdAlumno], [FechaSolicitud],[CodRegistrante],[Carrera],[Periodo]) VALUES (3,6,getdate(),N'SISTEMA','Matemática','202001')
INSERT [dbo].[Solicitud] ([IdSolicitud], [IdAlumno], [FechaSolicitud],[CodRegistrante],[Carrera],[Periodo]) VALUES (4,14,getdate(),N'SISTEMA','Ingeniería de Sistemas','202102')
INSERT [dbo].[Solicitud] ([IdSolicitud], [IdAlumno], [FechaSolicitud],[CodRegistrante],[Carrera],[Periodo]) VALUES (5,28,getdate(),N'SISTEMA','Marketing','202101')
INSERT [dbo].[Solicitud] ([IdSolicitud], [IdAlumno], [FechaSolicitud],[CodRegistrante],[Carrera],[Periodo]) VALUES (6,26,getdate(),N'SISTEMA','Matemática','201801')
INSERT [dbo].[Solicitud] ([IdSolicitud], [IdAlumno], [FechaSolicitud],[CodRegistrante],[Carrera],[Periodo]) VALUES (7,19,getdate(),N'SISTEMA','Filosofía','202102')
INSERT [dbo].[Solicitud] ([IdSolicitud], [IdAlumno], [FechaSolicitud],[CodRegistrante],[Carrera],[Periodo]) VALUES (8,53,getdate(),N'SISTEMA','Ingeniería Comercial','202102')
INSERT [dbo].[Solicitud] ([IdSolicitud], [IdAlumno], [FechaSolicitud],[CodRegistrante],[Carrera],[Periodo]) VALUES (9,84,getdate(),N'SISTEMA','Matemática','201901')
INSERT [dbo].[Solicitud] ([IdSolicitud], [IdAlumno], [FechaSolicitud],[CodRegistrante],[Carrera],[Periodo]) VALUES (10,99,getdate(),N'SISTEMA','Ingeniería de Telecomunicaciones','202001')
INSERT [dbo].[Solicitud] ([IdSolicitud], [IdAlumno], [FechaSolicitud],[CodRegistrante],[Carrera],[Periodo]) VALUES (11,105,getdate(),N'SISTEMA','Marketing','202002')
go



Create procedure sp_insert_alumno
(
@IdAlumno int output,
@Nombres varchar(3000),
@Apellidos varchar(3000)
)
as
begin

		if NOT EXISTS(select * from [dbo].[Alumno] where IdAlumno = @IdAlumno )
		begin 
		
		declare @Correlative int ;
		set @Correlative = ( select Max(IdAlumno) + 1 from Alumno )

				INSERT INTO [dbo].[Alumno]
						   ([IdAlumno]
						   ,[Nombres]
						   ,[Apellidos])
					 VALUES
						   (@Correlative,
							@Nombres,
							@Apellidos)

		set @IdAlumno = @Correlative 

		end
		else
		begin 

				UPDATE [dbo].[Alumno]
				SET  [Nombres] = @Nombres,
					 [Apellidos] = @Apellidos 
				WHERE 
				[IdAlumno] = @IdAlumno

		end
end

go

Create procedure sp_get_alumno
(
@IdAlumno int,
@Nombres varchar(3000),
@Apellidos varchar(3000)
)
as
begin

		select [IdAlumno]
			   ,[Nombres]
			   ,[Apellidos]
		from [dbo].[Alumno]
		where 
		(IdAlumno = @IdAlumno or @IdAlumno = 0) and 
		(Nombres like '%' + @Nombres + '%' or @Nombres = '' ) and 
		(Apellidos like '%' +  @Apellidos  + '%' or @Apellidos = '') 
			  
end

go

create procedure sp_delete_alumno
(
@IdAlumno int
)
as
begin 

	delete from [dbo].[Alumno] where IdAlumno = @IdAlumno 

end 

go

 
Create procedure sp_insert_solicitud
(
@IdSolicitud int output,
@IdAlumno int , 
@FechaSolicitud datetime,
@CodRegistrante varchar(3000),
@Carrera varchar(3000),
@Periodo varchar(3000)
)
as
begin

		if NOT EXISTS(select * from [dbo].[Solicitud] where IdSolicitud = @IdSolicitud )
		begin 
		
		declare @Correlative int ;
		set @Correlative = ( select Max(IdSolicitud) + 1 from [Solicitud] )

				INSERT INTO [dbo].[Solicitud]
						   (IdSolicitud,
							IdAlumno,
							FechaSolicitud,
							CodRegistrante,
							Carrera,
							Periodo)
					 VALUES
						   (@Correlative,
							@IdAlumno,
							@FechaSolicitud,
							@CodRegistrante,
							@Carrera,
							@Periodo)

		set @IdSolicitud = @Correlative 

		end
		else
		begin  
				UPDATE [dbo].[Solicitud]
				SET  
					 IdAlumno = @IdAlumno,
					 FechaSolicitud = @FechaSolicitud,
					 CodRegistrante = @CodRegistrante,
					 Carrera = @Carrera ,
					 Periodo = @Periodo
				WHERE 
				IdSolicitud = @IdSolicitud

		end
end

go
 

Create procedure sp_get_solicitud
( 
@IdSolicitud int ,
@IdAlumno int , 
@FechaSolicitud datetime,
@CodRegistrante varchar(3000),
@Carrera varchar(3000),
@Periodo varchar(3000)
)
as
begin

		select  IdSolicitud,
				IdAlumno,
				FechaSolicitud,
				CodRegistrante,
				Carrera,
				Periodo
		from [dbo].[Solicitud]
		where 
		(IdSolicitud = @IdSolicitud or @IdSolicitud = 0) and 
		(IdAlumno = @IdAlumno or @IdAlumno = 0) and 
		--(FechaSolicitud like '%' + @FechaSolicitud + '%' or @FechaSolicitud = '' ) and 
		(CodRegistrante like '%' + @CodRegistrante + '%' or @CodRegistrante = '' ) and 
		(Carrera like '%' + @Carrera + '%' or @Carrera = '' ) and 
		(Periodo like '%' + @Periodo + '%' or @Periodo = '' ) 
			  
end

go

create procedure sp_delete_solicitud
(
@IdSolicitud int
)
as
begin 

	delete from [dbo].[Solicitud] where IdSolicitud = @IdSolicitud 

end 

go



--select a.*,s.* from Alumno a inner join Solicitud s on a.IdAlumno = s.IdAlumno



