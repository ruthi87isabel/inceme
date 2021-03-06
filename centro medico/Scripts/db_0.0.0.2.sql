if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fklineasalarmaalarma]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LINEASALARMA] DROP CONSTRAINT fklineasalarmaalarma
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fklineasalarmamalarma]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LINEASALARMAM] DROP CONSTRAINT fklineasalarmamalarma
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_lineasanaliticas]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LINEASANALITICAS] DROP CONSTRAINT fk_lineasanaliticas
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_lineasfacturas]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LINEASFACTURAS] DROP CONSTRAINT fk_lineasfacturas
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fklpresupuestoconcepto]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LPRESUPUESTOS] DROP CONSTRAINT fklpresupuestoconcepto
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_DERIVACIONES_DERIVACIONES_DESTINOS]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[DERIVACIONES] DROP CONSTRAINT FK_DERIVACIONES_DERIVACIONES_DESTINOS
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_recetasdiagnostico]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[RECETAS] DROP CONSTRAINT fk_recetasdiagnostico
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fkfacturasempresa]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[FACTURAS] DROP CONSTRAINT fkfacturasempresa
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fkfrasmeijideempresa]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[FRASMEIJIDE] DROP CONSTRAINT fkfrasmeijideempresa
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_lempresasempresa]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LEMPRESAS] DROP CONSTRAINT fk_lempresasempresa
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_lmutuasempresasempresas]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LMUTUASEMPRESAS] DROP CONSTRAINT fk_lmutuasempresasempresas
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fkpresupuestoempresa]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PRESUPUESTOS] DROP CONSTRAINT fkpresupuestoempresa
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fklineasfacturas]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LINEASFACTURAS] DROP CONSTRAINT fklineasfacturas
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_citas]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CITAS] DROP CONSTRAINT fk_citas
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_facturasformapago]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[FACTURAS] DROP CONSTRAINT fk_facturasformapago
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_frasmeijideformapago]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[FRASMEIJIDE] DROP CONSTRAINT fk_frasmeijideformapago
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_gastosformapago]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[GASTOS] DROP CONSTRAINT fk_gastosformapago
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pk_lhistorialeshistorial]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LHISTORIALES] DROP CONSTRAINT pk_lhistorialeshistorial
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_datoscomparativalcomparativa]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[DATOSCOMPARATIVA] DROP CONSTRAINT fk_datoscomparativalcomparativa
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fklineasalarmammedicamento]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LINEASALARMAM] DROP CONSTRAINT fklineasalarmammedicamento
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_recetamedicamento]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[RECETAS] DROP CONSTRAINT fk_recetamedicamento
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fkaltasmedico]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ALTAS] DROP CONSTRAINT fkaltasmedico
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fkasistenciasmedico]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ASISTENCIAS] DROP CONSTRAINT fkasistenciasmedico
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fkbajasmedico]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[BAJAS] DROP CONSTRAINT fkbajasmedico
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fkmedico]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CITAS] DROP CONSTRAINT fkmedico
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fkdr1frasmeijide]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[FRASMEIJIDE] DROP CONSTRAINT fkdr1frasmeijide
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fkdr2frasmeijide]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[FRASMEIJIDE] DROP CONSTRAINT fkdr2frasmeijide
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fkhistorialesmedico]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[HISTORIALES] DROP CONSTRAINT fkhistorialesmedico
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fkrecetasmedico]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[RECETAS] DROP CONSTRAINT fkrecetasmedico
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_comparativasmodelo]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[COMPARATIVAS] DROP CONSTRAINT fk_comparativasmodelo
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_modelosdatoscomparativas]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[MODELOSDATOS] DROP CONSTRAINT fk_modelosdatoscomparativas
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_datoscomparativamodelodato]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[DATOSCOMPARATIVA] DROP CONSTRAINT fk_datoscomparativamodelodato
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fkfacturasmutua]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[FACTURAS] DROP CONSTRAINT fkfacturasmutua
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fkpresupuestomutua]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PRESUPUESTOS] DROP CONSTRAINT fkpresupuestomutua
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_analiticapaciente]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ANALITICAS] DROP CONSTRAINT fk_analiticapaciente
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_audiometrias]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[AUDIOMETRIAS] DROP CONSTRAINT fk_audiometrias
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_comparativaspaciente]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[COMPARATIVAS] DROP CONSTRAINT fk_comparativaspaciente
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_derivacionespaciente]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[DERIVACIONES] DROP CONSTRAINT fk_derivacionespaciente
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fkfacturaspaciente]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[FACTURAS] DROP CONSTRAINT fkfacturaspaciente
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_ficheros]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[FICHEROS] DROP CONSTRAINT fk_ficheros
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fkhistorialespaciente]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[HISTORIALES] DROP CONSTRAINT fkhistorialespaciente
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fkimagenespaciente]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[IMAGENES] DROP CONSTRAINT fkimagenespaciente
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_informacionprimariapaciente]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[INFORMACIONPRIMARIA] DROP CONSTRAINT fk_informacionprimariapaciente
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_lempresaspacientes]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LEMPRESAS] DROP CONSTRAINT fk_lempresaspacientes
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fklineasalarmapaciente]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LINEASALARMA] DROP CONSTRAINT fklineasalarmapaciente
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_lmutuas_pacientes]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LMUTUAS] DROP CONSTRAINT fk_lmutuas_pacientes
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fkpresupuestopaciente]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PRESUPUESTOS] DROP CONSTRAINT fkpresupuestopaciente
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fkrecetaspaciente]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[RECETAS] DROP CONSTRAINT fkrecetaspaciente
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_RECIBOS_PACIENTES]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[RECIBOS] DROP CONSTRAINT FK_RECIBOS_PACIENTES
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_PERMISOS_USUARIO_PERMISOS]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PERMISOS_USUARIO] DROP CONSTRAINT FK_PERMISOS_USUARIO_PERMISOS
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_lplantillaplantilla]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LPLANTILLAANALITICAS] DROP CONSTRAINT fk_lplantillaplantilla
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fklpresupuestopresupuesto]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LPRESUPUESTOS] DROP CONSTRAINT fklpresupuestopresupuesto
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fkarticulosproveedor]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ARTICULOS] DROP CONSTRAINT fkarticulosproveedor
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fk_frasmeijiderecibo]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[FRASMEIJIDE] DROP CONSTRAINT fk_frasmeijiderecibo
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_PERMISOS_USUARIO_USUARIOS]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PERMISOS_USUARIO] DROP CONSTRAINT FK_PERMISOS_USUARIO_USUARIOS
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CleanDB]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[CleanDB]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SETADMIN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[SETADMIN]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SelectCurrentRows]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[SelectCurrentRows]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ALARMAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ALARMAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ALTAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ALTAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ANALITICAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ANALITICAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ARGOS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ARGOS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ARTICULOS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ARTICULOS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ASISTENCIAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ASISTENCIAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[AUDIOMETRIAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[AUDIOMETRIAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BAJAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[BAJAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BANCOS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[BANCOS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CITAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CITAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CLINICAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CLINICAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[COMPARATIVAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[COMPARATIVAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CONCEPTOSANALITICA]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CONCEPTOSANALITICA]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CONCEPTOSFACTURABLES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CONCEPTOSFACTURABLES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CONCEPTOSFRA]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CONCEPTOSFRA]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DATOSCOMPARATIVA]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DATOSCOMPARATIVA]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DERIVACIONES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DERIVACIONES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DERIVACIONES_DESTINOS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DERIVACIONES_DESTINOS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DIAGNOSTICOS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DIAGNOSTICOS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[EMPRESAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[EMPRESAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FACTURAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[FACTURAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FICHEROS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[FICHEROS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FICHEROSGLOBAL]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[FICHEROSGLOBAL]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FORMASPAGO]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[FORMASPAGO]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FRASMEIJIDE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[FRASMEIJIDE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GASTOS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[GASTOS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HFRASMEIJIDE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HFRASMEIJIDE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HISTORIALES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HISTORIALES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[IMAGENES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[IMAGENES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[INDICACIONES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[INDICACIONES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[INFORMACIONPRIMARIA]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[INFORMACIONPRIMARIA]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LCOMPARATIVAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LCOMPARATIVAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LEMPRESAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LEMPRESAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LHISTORIALES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LHISTORIALES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LINEASALARMA]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LINEASALARMA]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LINEASALARMAM]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LINEASALARMAM]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LINEASANALITICAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LINEASANALITICAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LINEASFACTURAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LINEASFACTURAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LINEASINDICACIONES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LINEASINDICACIONES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LMUTUAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LMUTUAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LMUTUASEMPRESAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LMUTUASEMPRESAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LPLANTILLAANALITICAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LPLANTILLAANALITICAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LPRESUPUESTOS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LPRESUPUESTOS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MEDICAMENTOS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MEDICAMENTOS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MEDICOS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MEDICOS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MODELOSCOMPARATIVA]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MODELOSCOMPARATIVA]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MODELOSDATOS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MODELOSDATOS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MUTUAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MUTUAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PACIENTES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PACIENTES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PAISES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PAISES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PARTES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PARTES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PERMISOS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PERMISOS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PERMISOS_USUARIO]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PERMISOS_USUARIO]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PLANTILLAANALITICAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PLANTILLAANALITICAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PLANTILLAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PLANTILLAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PLANTILLA_HISTORIALES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PLANTILLA_HISTORIALES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PRESUPUESTOS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PRESUPUESTOS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROVEEDORES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PROVEEDORES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROVINCIAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PROVINCIAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[RECETAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[RECETAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[RECIBOS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[RECIBOS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SERIES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[SERIES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USUARIOS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[USUARIOS]
GO

CREATE TABLE [dbo].[ALARMAS] (
	[CALARMA] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[ALARMA] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NIVEL] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DESCRIPCION] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[ALTAS] (
	[IDALTA] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[REFPARTE] [int] NULL ,
	[FECHAALTA] [datetime] NULL ,
	[RESULTADORM] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CAUSA] [varchar] (2) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EMISION] [datetime] NULL ,
	[REFMEDICO] [int] NULL ,
	[MEDICO] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EXTERNA] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[ANALITICAS] (
	[NUMERO] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[DESCRIPCION] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[IMPORTE] [real] NULL ,
	[REFPACIENTE] [int] NULL ,
	[PACIENTE] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ESTADO] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FECHA] [datetime] NULL ,
	[NOTAS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFFRA] [int] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[ARGOS] (
	[CODIGO] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ARTICULOS] (
	[CARTICULO] [int] NOT NULL ,
	[DESCRIPCION] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFPROVEEDOR] [int] NULL ,
	[STOCK] [int] NULL ,
	[STOCKMIN] [int] NULL ,
	[FECHA] [datetime] NULL ,
	[NOTAS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[ASISTENCIAS] (
	[IDASISTENCIA] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[REFPARTE] [int] NULL ,
	[FECHAACCIDENTE] [datetime] NULL ,
	[FECHAASISTENCIA] [datetime] NULL ,
	[OBSERVACIONES] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFMEDICO] [int] NULL ,
	[FECHAEMISION] [datetime] NULL ,
	[MEDICO] [varchar] (60) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[AUDIOMETRIAS] (
	[CODIGO] [int] NOT NULL ,
	[REFPACIENTE] [int] NOT NULL ,
	[OD250] [real] NOT NULL ,
	[OD500] [real] NOT NULL ,
	[OD1000] [real] NOT NULL ,
	[OD2000] [real] NOT NULL ,
	[OD3000] [real] NOT NULL ,
	[OD4000] [real] NOT NULL ,
	[OD6000] [real] NOT NULL ,
	[OD8000] [real] NOT NULL ,
	[OI8000] [real] NOT NULL ,
	[OI250] [real] NOT NULL ,
	[OI500] [real] NOT NULL ,
	[OI1000] [real] NOT NULL ,
	[OI2000] [real] NOT NULL ,
	[OI3000] [real] NOT NULL ,
	[OI4000] [real] NOT NULL ,
	[OI6000] [real] NOT NULL ,
	[FECHA] [datetime] NULL ,
	[NOTAS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[BAJAS] (
	[IDBAJA] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[REFPARTE] [int] NULL ,
	[CAUSA] [varchar] (2) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[GRAVEDAD] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[RECAIDA] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FECHAAT] [datetime] NULL ,
	[FECHABAJA] [datetime] NULL ,
	[DIAGNOSTICO] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CIE9MC] [varchar] (5) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EMISION] [datetime] NULL ,
	[REFMEDICO] [int] NULL ,
	[MEDICO] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[LIMITECF] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[BANCOS] (
	[NOMBRE] [varchar] (60) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DIRECCION] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[LOCALIDAD] [varchar] (60) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PROVINCIA] [varchar] (60) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CP] [varchar] (6) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TLFNO1] [varchar] (12) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TLFNO2] [varchar] (12) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FAX] [varchar] (12) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ENTIDAD] [varchar] (4) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[OFICINA] [varchar] (4) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[NOTAS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EMAIL] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[WEB] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ID] [varchar] (8) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[CITAS] (
	[IDCITA] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[REFPACIENTE] [int] NULL ,
	[FECHA] [datetime] NULL ,
	[HORA] [datetime] NULL ,
	[CONFIRMADA] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NOTAS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFMEDICO] [int] NULL ,
	[PACIENTE] [varchar] (60) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[IMPORTEDR] [decimal](18, 2) NULL ,
	[IMPORTECL] [decimal](18, 2) NULL ,
	[CONTINUA] [varchar] (7) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FALTA] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[BANCO] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PAGADA] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFRECIBO] [int] NULL ,
	[ATENDIDO] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFFRA] [int] NULL ,
	[REFFORMAPAGO] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[HORAFIN] [datetime] NULL ,
	[FECHACOBRO] [datetime] NULL ,
	[REFPROCEDENCIA] [int] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[CLINICAS] (
	[CODIGO] [varchar] (12) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[NOMBRE] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DIRECCION] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CP] [varchar] (5) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[POBLACION] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PROVINCIA] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TLFNO1] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TLFNO2] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FAX] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MAIL] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[WEB] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PERSONACION] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[COMPARATIVAS] (
	[CODIGO] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[REFPACIENTE] [int] NULL ,
	[DESCRIPCION] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FECHA] [datetime] NULL ,
	[NOTAS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFMODELOCOMPARATIVA] [varchar] (12) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[CONCEPTOSANALITICA] (
	[CODIGO] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[CONCEPTO] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[IMPORTE] [real] NOT NULL ,
	[NOTAS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[CONCEPTOSFACTURABLES] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[REFPACIENTE] [int] NULL ,
	[REFCONCEPTO] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DESCRIPCION] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[IMPORTE] [real] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CONCEPTOSFRA] (
	[CODIGO] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[DESCRIPCION] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[IMPORTE] [real] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DATOSCOMPARATIVA] (
	[ID] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[REFLCOMPARATIVA] [int] NULL ,
	[DFLOAT] [real] NULL ,
	[DBOOLEAN] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DVARCHAR] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFMODELODATO] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DERIVACIONES] (
	[CODIGO] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[FECHA] [datetime] NOT NULL ,
	[REFDESTINO] [varchar] (12) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DESTINO] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MOTIVO] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NOTAS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFPACIENTE] [int] NOT NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[DERIVACIONES_DESTINOS] (
	[NOMBRE] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DIRECCION] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[POBLACION] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PROVINCIA] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CP] [varchar] (5) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TLFNO1] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TLFNO2] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FAX] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MAIL] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[WEB] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PERSONACION] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NOTAS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CIF] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CODIGO] [varchar] (12) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[DIAGNOSTICOS] (
	[IDDIAGNOSTICO] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[DIAGNOSTICO] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[OBSERVACIONES] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NIVEL] [varchar] (6) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[SUBNIVEL] [varchar] (6) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[CIE] [varchar] (13) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FAVORITO] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[CIE10] [varchar] (12) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[EMPRESAS] (
	[NOMBRE] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DIRECCION] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[POBLACION] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PROVINCIA] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CP] [varchar] (5) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TLFNO1] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TLFNO2] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FAX] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MAIL] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[WEB] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PERSONACON] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NOTAS] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CNAE] [varchar] (5) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ACTIVIDAD] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CEMPRESA] [int] NOT NULL ,
	[REFMUTUA] [int] NULL ,
	[CIF] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NSS] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FECHA] [datetime] NULL ,
	[ENTIDAD] [varchar] (4) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[OFICINA] [varchar] (4) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DC] [varchar] (2) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CUENTA] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TITULAR] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[FACTURAS] (
	[IDFACTURA] [int] NOT NULL ,
	[NUMEROFACTURA] [int] NOT NULL ,
	[REFPACIENTE] [int] NULL ,
	[FECHA] [datetime] NULL ,
	[HORA] [datetime] NULL ,
	[HISTORIAL] [int] NULL ,
	[REFEMPRESA] [int] NULL ,
	[REFMUTUA] [int] NULL ,
	[FACCIDENTE] [datetime] NULL ,
	[FBAJA] [datetime] NULL ,
	[FALTA] [datetime] NULL ,
	[FEMISION] [datetime] NULL ,
	[TOTAL] [decimal](18, 2) NULL ,
	[IRPF] [decimal](18, 2) NULL ,
	[DIAGNOSTICO] [varchar] (60) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PAGADA] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[MUTUA] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[RECIBO] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[DIRECCION] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[LOCALIDAD] [varchar] (35) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PROVINCIA] [varchar] (35) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CP] [varchar] (6) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFRECIBO] [int] NULL ,
	[PACIENTE] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFCITA] [int] NULL ,
	[FECHACOBRO] [datetime] NULL ,
	[PORCENTAJEIRPF] [real] NOT NULL ,
	[REFFORMAPAGO] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DNI] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EMPRESA] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[FACTURAR] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[NUMERO] [varchar] (12) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFSERIE] [varchar] (6) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TIPOIVA] [real] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[FICHEROS] (
	[CODIGO] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[REFPACIENTE] [int] NULL ,
	[FECHA] [datetime] NULL ,
	[FECHAMODIFICACION] [datetime] NULL ,
	[FICHERO] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NOTAS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DESCRIPCION] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[FICHEROSGLOBAL] (
	[ID] [int] NOT NULL ,
	[REFREGISTRO] [int] NOT NULL ,
	[FICHERO] [varchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[DESCRIPCION] [varchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[FECHA] [datetime] NOT NULL ,
	[SECCION] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[FORMASPAGO] (
	[CODIGO] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[DESCRIPCION] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[FRASMEIJIDE] (
	[NUMEROFACTURA] [int] NOT NULL ,
	[REFPACIENTE] [int] NULL ,
	[FECHA] [datetime] NULL ,
	[HORA] [datetime] NULL ,
	[REFEMPRESA] [int] NULL ,
	[REFMUTUA] [int] NULL ,
	[FACCIDENTE] [datetime] NULL ,
	[FBAJA] [datetime] NULL ,
	[FALTA] [datetime] NULL ,
	[FEMISION] [datetime] NULL ,
	[TOTAL] [decimal](18, 2) NULL ,
	[IRPF] [decimal](18, 2) NULL ,
	[DIAGNOSTICO] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DR1] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DR2] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DR1IMPORTE] [decimal](18, 2) NULL ,
	[DR2IMPORTE] [decimal](18, 2) NULL ,
	[RADIOGRAFIA] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[RADIOGRAFIAIMPORTE] [decimal](18, 2) NULL ,
	[EKG] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EKGIMPORTE] [decimal](18, 2) NULL ,
	[ECOGRAFIA] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ECOGRAFIAIMPORTE] [decimal](18, 2) NULL ,
	[ANALISIS] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ANALISISIMPORTE] [decimal](18, 2) NULL ,
	[MATERIAL] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MATERIALIMPORTE] [decimal](18, 2) NULL ,
	[URGENCIAS] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[URGENCIASIMPORTE] [decimal](18, 2) NULL ,
	[CONCEPTO1] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CONCEPTO1IMPORTE] [decimal](18, 2) NULL ,
	[CONCEPTO2] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CONCEPTO2IMPORTE] [decimal](18, 2) NULL ,
	[PAGADA] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFDR1] [int] NULL ,
	[REFDR2] [int] NULL ,
	[ANNO] [varchar] (2) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[MUTUA] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FECHACOBRO] [datetime] NULL ,
	[PACIENTE] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DOMICILIOPACIENTE] [varchar] (60) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[LOCALIDADPACIENTE] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CPPACIENTE] [varchar] (5) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PROVINCIAPACIENTE] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[RECIBO] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[REFCITA] [int] NULL ,
	[REFRECIBO] [int] NULL ,
	[REFFORMAPAGO] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[GASTOS] (
	[IDGASTO] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[CONCEPTO] [varchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[IMPORTE] [decimal](18, 2) NULL ,
	[FECHA] [datetime] NULL ,
	[REFFORMAPAGO] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[HFRASMEIJIDE] (
	[NUMEROFACTURA] [int] NOT NULL ,
	[FECHA] [datetime] NULL ,
	[HORA] [datetime] NULL ,
	[FACCIDENTE] [datetime] NULL ,
	[FBAJA] [datetime] NULL ,
	[FALTA] [datetime] NULL ,
	[FEMISION] [datetime] NULL ,
	[TOTAL] [decimal](18, 2) NULL ,
	[IRPF] [decimal](18, 2) NULL ,
	[DIAGNOSTICO] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DR1] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DR2] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DR1IMPORTE] [decimal](18, 2) NULL ,
	[DR2IMPORTE] [decimal](18, 2) NULL ,
	[RADIOGRAFIA] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[RADIOGRAFIAIMPORTE] [decimal](18, 2) NULL ,
	[EKG] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EKGIMPORTE] [decimal](18, 2) NULL ,
	[ECOGRAFIA] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ECOGRAFIAIMPORTE] [decimal](18, 2) NULL ,
	[ANALISIS] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ANALISISIMPORTE] [decimal](18, 2) NULL ,
	[MATERIAL] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MATERIALIMPORTE] [decimal](18, 2) NULL ,
	[URGENCIAS] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[URGENCIASIMPORTE] [decimal](18, 2) NULL ,
	[CONCEPTO1] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CONCEPTO1IMPORTE] [decimal](18, 2) NULL ,
	[CONCEPTO2] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CONCEPTO2IMPORTE] [decimal](18, 2) NULL ,
	[PAGADA] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFDR1] [int] NULL ,
	[REFDR2] [int] NULL ,
	[PACIENTE] [varchar] (65) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MUTUA] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MDIRECCION] [varchar] (60) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MLOCALIDAD] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MPROVINCIA] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MCP] [varchar] (5) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EMPRESA] [varchar] (60) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ANHO] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[HISTORIALES] (
	[REFPACIENTE] [int] NOT NULL ,
	[REFMEDICO] [int] NOT NULL ,
	[FECHA] [datetime] NULL ,
	[MOTIVO] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ANTECEDENTES] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EXPLORACION] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[COMPLEMENTARIAS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[JUICIO] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TRATAMIENTO] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[HISTORIAL] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[COMENTARIOS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CHISTORIAL] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[OTROS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[HORA] [datetime] NULL ,
	[REFDIAGNOSTICO] [int] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[IMAGENES] (
	[IDIMAGEN] [int] NOT NULL ,
	[REFPACIENTE] [int] NOT NULL ,
	[FECHA] [datetime] NULL ,
	[TEXTO] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[IMAGEN] [image] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[INDICACIONES] (
	[CINDICACIONES] [int] NOT NULL ,
	[NOMBRE] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TEXTO] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[INFORMACIONPRIMARIA] (
	[ID] [int] NOT NULL ,
	[FECHA] [datetime] NULL ,
	[DESCRIPCION] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TEXTO] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFPACIENTE] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[LCOMPARATIVAS] (
	[ID] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[REFCOMPARATIVA] [int] NULL ,
	[FECHA] [datetime] NULL ,
	[HORA] [datetime] NULL ,
	[REFMODELOCOMPARATIVA] varchar(12) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DESCRIPCION] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NOTAS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[LEMPRESAS] (
	[CODIGO] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[REFEMPRESA] [int] NULL ,
	[REFPACIENTE] [int] NULL ,
	[FECHAALTA] [datetime] NULL ,
	[FECHABAJA] [datetime] NULL ,
	[NOTAS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[LHISTORIALES] (
	[ID] [int] NOT NULL ,
	[REFHISTORIAL] [int] NOT NULL ,
	[FECHA] [datetime] NULL ,
	[HORA] [datetime] NULL ,
	[EXPLORACION] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[COMPLEMENTARIAS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[JUICIO] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TRATAMIENTO] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NOTAS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[OTROS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EVOLUCION] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[LINEASALARMA] (
	[IDLINEAALARMA] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[REFPACIENTE] [int] NULL ,
	[REFALARMA] [int] NULL ,
	[DESCRIPCION] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[LINEASALARMAM] (
	[IDLINEAALARMA] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[REFMEDICAMENTO] [varchar] (5) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[REFALARMA] [int] NOT NULL ,
	[DESCRIPCION] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[LINEASANALITICAS] (
	[ID] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[REFANALITICA] [int] NULL ,
	[REFCONCEPTO] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CONCEPTO] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PRECIO] [real] NOT NULL ,
	[RESULTADO] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[LINEASFACTURAS] (
	[IDLINEAFACTURA] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[CONCEPTO] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[IMPORTE] [decimal](18, 2) NULL ,
	[REFFACTURA] [int] NOT NULL ,
	[REFCONCEPTO] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CANTIDAD] [real] NOT NULL ,
	[TIPOIVA] [real] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[LINEASINDICACIONES] (
	[IDLINEASINDICACIONES] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[REFMEDICAMENTO] [varchar] (5) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[REFINDICACION] [int] NOT NULL ,
	[TEXTO] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[LMUTUAS] (
	[CODIGO] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[REFPACIENTE] [int] NULL ,
	[REFMUTUA] [int] NULL ,
	[FECHAALTA] [datetime] NULL ,
	[FECHABAJA] [datetime] NULL ,
	[TIPO] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NOTAS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[LMUTUASEMPRESAS] (
	[CODIGO] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[REFEMPRESA] [int] NULL ,
	[FECHAALTA] [datetime] NULL ,
	[FECHABAJA] [datetime] NULL ,
	[TIPO] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFMUTUA] [int] NULL ,
	[NOTAS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[LPLANTILLAANALITICAS] (
	[ID] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[REFPLANTILLA] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[REFCONCEPTO] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PRECIO] [real] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[LPRESUPUESTOS] (
	[IDPRESUPUESTO] [int] NOT NULL ,
	[CONCEPTO] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[IMPORTE] [decimal](18, 2) NULL ,
	[REFPRESUPUESTO] [int] NOT NULL ,
	[REFCONCEPTO] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CANTIDAD] [real] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MEDICAMENTOS] (
	[CMEDICAMENTO] [varchar] (5) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[DESCRIPCION] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[POSOLOGIA] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CANTIDADES] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[INDICACION] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FAVORITOS] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[MEDICOS] (
	[NOMBRE] [varchar] (25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[APELLIDO1] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[APELLIDO2] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DOMICILIO] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TLFNO] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MOVIL] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[LOCALIDAD] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CP] [varchar] (5) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DNI] [varchar] (8) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PROVINCIA] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[COLEGIADO] [varchar] (12) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CMEDICO] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[ESPECIALIDAD] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[OBSERVACIONES] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[MODELOSCOMPARATIVA] (
	[CODIGO] [varchar] (12) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[MODELO] [varchar] (120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MODELOSDATOS] (
	[CODIGO] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[NOMBREDATO] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TIPODATO] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFMODELOCOMPARATIVA] [varchar] (12) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MUTUAS] (
	[NOMBRE] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DIRECCION] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[POBLACION] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PROVINCIA] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CP] [varchar] (5) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TLFNO1] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TLFNO2] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FAX] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MAIL] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[WEB] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PERSONACON] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NOTAS] [varchar] (8000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CMUTUA] [int] NOT NULL ,
	[CIF] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ESPECIALIDAD] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PARTELSR] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PARTEMTR] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PACIENTES] (
	[NOMBRE] [varchar] (25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[APELLIDO1] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[APELLIDO2] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DOMICILIO] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TLFNO] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MOVIL] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PROFESION] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[LOCALIDAD] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CP] [varchar] (5) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFEMPRESA] [int] NULL ,
	[DNI] [varchar] (8) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FECHAN] [datetime] NULL ,
	[OBSERVACIONES] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PROVINCIA] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NSS] [varchar] (12) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PUESTO] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REGIMEN] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TARJETASANITARIA] [varchar] (12) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFMUTUA] [int] NULL ,
	[CPACIENTE] [int] NOT NULL ,
	[SEXO] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FECHAALTA] [datetime] NULL ,
	[TUTOR] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PAGOBANCO] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ENTIDAD] [varchar] (4) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[OFICINA] [varchar] (4) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DC] [varchar] (2) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TITULAR] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CUENTA] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DEFUNCION] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NIE] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PASAPORTE] [varchar] (25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFPAIS] [int] NOT NULL ,
	[FOTO] [image] NULL ,
	[FOTOGRAFIA] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[SOCIO] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ACTIVO] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFFORMAPAGO] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FECHABAJA] [datetime] NULL ,
	[CONOCIO] [varchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[PAISES] (
	[CODIGO] [int] NOT NULL ,
	[NOMBRE] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NOTAS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[PARTES] (
	[IDPARTE] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[REFPACIENTE] [int] NULL ,
	[PACIENTE] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TARJETA] [varchar] (12) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NSS] [varchar] (12) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DNI] [varchar] (8) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PDOMICILIO] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PLOCALIDAD] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PCP] [varchar] (5) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PPROVINCIA] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PTLFNO] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PUESTO] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REGIMEN] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[SITUACION] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFEMPRESA] [int] NULL ,
	[EMPRESA] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EDOMICILIO] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ELOCALIDAD] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ECP] [varchar] (5) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EPROVINCIA] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ETLFNO] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ACTIVIDAD] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CNAE] [varchar] (5) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFMUTUA] [int] NULL ,
	[MUTUA] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[COLEGIADO] [varchar] (5) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ENSS] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ECIF] [varchar] (12) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FECHA] [datetime] NULL ,
	[TIPO] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFFRA] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PERMISOS] (
	[CODIGO] [int] NOT NULL ,
	[PERMISO] [char] (12) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PERMISOS_USUARIO] (
	[CODIGO] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[ITEM] [char] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFUSUARIO] [int] NULL ,
	[REFPERMISO] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PLANTILLAANALITICAS] (
	[CODIGO] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[DESCRIPCION] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PLANTILLAS] (
	[CODIGO] [int] NOT NULL ,
	[DESCRIPCION] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[SECCION] [varchar] (2) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[TEXTO] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[PLANTILLA_HISTORIALES] (
	[CODIGO] [varchar] (12) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[MOTIVO] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ANTECEDENTES] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EXPLORACION] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[COMPLEMENTARIAS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[JUICIO] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TRATAMIENTO] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[HISTORIAL] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[COMENTARIOS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[OTROS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DESCRIPCION] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[PRESUPUESTOS] (
	[NUMERO] [int] NOT NULL ,
	[REFPACIENTE] [int] NULL ,
	[FECHA] [datetime] NULL ,
	[REFEMPRESA] [int] NULL ,
	[REFMUTUA] [int] NULL ,
	[FEMISION] [datetime] NULL ,
	[TOTAL] [decimal](18, 2) NULL ,
	[MUTUA] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[DIRECCION] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[LOCALIDAD] [varchar] (35) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PROVINCIA] [varchar] (35) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CP] [varchar] (6) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PACIENTE] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DNI] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EMPRESA] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PROVEEDORES] (
	[NOMBRE] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DIRECCION] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[POBLACION] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PROVINCIA] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CP] [varchar] (5) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TLFNO1] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TLFNO2] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FAX] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MAIL] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[WEB] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PERSONACON] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NOTAS] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CPROVEEDOR] [int] NOT NULL ,
	[CIF] [varchar] (9) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PROVINCIAS] (
	[PROVINCIA] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CPROVINCIA] [int] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[RECETAS] (
	[IDRECETA] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[FECHA] [datetime] NULL ,
	[REFPACIENTE] [int] NULL ,
	[TRATAMIENTO] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFMEDICO] [int] NULL ,
	[REFDIAGNOSTICO] [int] NULL ,
	[REFMEDICAMENTO] [varchar] (5) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[HORA] [datetime] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[RECIBOS] (
	[FECHAEMISION] [datetime] NULL ,
	[COBRADO] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EMITIDO] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFCITA] [int] NULL ,
	[REFFACTURA] [int] NULL ,
	[IMPORTE] [decimal](18, 2) NULL ,
	[REFPACIENTE] [int] NULL ,
	[FECHAVENCIMIENTO] [datetime] NULL ,
	[NOMBRE] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DIRECCION] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NOTAS] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NUMERO] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[CUENTABANCO] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ENTIDAD] [varchar] (4) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[OFICINA] [varchar] (4) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DC] [varchar] (2) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CUENTA] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CONCEPTO] [varchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FECHACOBRO] [datetime] NULL ,
	[N19] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFFORMAPAGO] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TIPO] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFEMPRESA] [int] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[SERIES] (
	[CODIGO] [varchar] (6) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[CONTADOR] [int] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[USUARIOS] (
	[CODIGO] [int] NOT NULL ,
	[USUARIO] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[CONTRASENA] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NIVEL] [varchar] (60) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[ADMINISTRADOR] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[NOMBRECOMPLETO] [varchar] (90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[REFMEDICO] [int] NULL ,
	[FECHACLAVE] [datetime] NOT NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ALARMAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_ALARMAS] PRIMARY KEY  CLUSTERED 
	(
		[CALARMA]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ALTAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_ALTAS] PRIMARY KEY  CLUSTERED 
	(
		[IDALTA]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ANALITICAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_ANALITICAS] PRIMARY KEY  CLUSTERED 
	(
		[NUMERO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ARTICULOS] WITH NOCHECK ADD 
	CONSTRAINT [PK_ARTICULOS] PRIMARY KEY  CLUSTERED 
	(
		[CARTICULO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ASISTENCIAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_ASISTENCIAS] PRIMARY KEY  CLUSTERED 
	(
		[IDASISTENCIA]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[AUDIOMETRIAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_AUDIOMETRIAS] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[BAJAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_BAJAS] PRIMARY KEY  CLUSTERED 
	(
		[IDBAJA]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[BANCOS] WITH NOCHECK ADD 
	CONSTRAINT [PK_BANCOS] PRIMARY KEY  CLUSTERED 
	(
		[ENTIDAD],
		[OFICINA]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CITAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_CITAS] PRIMARY KEY  CLUSTERED 
	(
		[IDCITA]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CLINICAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_CLINICAS] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[COMPARATIVAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_COMPARATIVAS] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CONCEPTOSANALITICA] WITH NOCHECK ADD 
	CONSTRAINT [PK_CONCEPTOSANALITICA] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CONCEPTOSFACTURABLES] WITH NOCHECK ADD 
	CONSTRAINT [PK_CONCEPTOSFACTURABLES] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CONCEPTOSFRA] WITH NOCHECK ADD 
	CONSTRAINT [PK_CONCEPTOSFRA] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[DATOSCOMPARATIVA] WITH NOCHECK ADD 
	CONSTRAINT [PK_DATOSCOMPARATIVA] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[DERIVACIONES] WITH NOCHECK ADD 
	CONSTRAINT [PK_DERIVACIONES] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[DERIVACIONES_DESTINOS] WITH NOCHECK ADD 
	CONSTRAINT [PK_DERIVACIONES_DESTINOS] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[DIAGNOSTICOS] WITH NOCHECK ADD 
	CONSTRAINT [PK_DIAGNOSTICOS] PRIMARY KEY  CLUSTERED 
	(
		[IDDIAGNOSTICO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[EMPRESAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_EMPRESAS] PRIMARY KEY  CLUSTERED 
	(
		[CEMPRESA]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[FACTURAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_FACTURAS] PRIMARY KEY  CLUSTERED 
	(
		[IDFACTURA]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[FICHEROS] WITH NOCHECK ADD 
	CONSTRAINT [PK_FICHEROS] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[FICHEROSGLOBAL] WITH NOCHECK ADD 
	CONSTRAINT [PK_FICHEROSGLOBAL] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[FORMASPAGO] WITH NOCHECK ADD 
	CONSTRAINT [PK_FORMASPAGO] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[FRASMEIJIDE] WITH NOCHECK ADD 
	CONSTRAINT [PK_FRASMEIJIDE] PRIMARY KEY  CLUSTERED 
	(
		[NUMEROFACTURA],
		[ANNO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[GASTOS] WITH NOCHECK ADD 
	CONSTRAINT [PK_GASTOS] PRIMARY KEY  CLUSTERED 
	(
		[IDGASTO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[HISTORIALES] WITH NOCHECK ADD 
	CONSTRAINT [PK_HISTORIALES] PRIMARY KEY  CLUSTERED 
	(
		[CHISTORIAL]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[IMAGENES] WITH NOCHECK ADD 
	CONSTRAINT [PK_IMAGENES] PRIMARY KEY  CLUSTERED 
	(
		[IDIMAGEN]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[INDICACIONES] WITH NOCHECK ADD 
	CONSTRAINT [PK_INDICACIONES] PRIMARY KEY  CLUSTERED 
	(
		[CINDICACIONES]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[INFORMACIONPRIMARIA] WITH NOCHECK ADD 
	CONSTRAINT [PK_INFORMACIONPRIMARIA] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LCOMPARATIVAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_LCOMPARATIVAS] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LEMPRESAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_LEMPRESAS] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LHISTORIALES] WITH NOCHECK ADD 
	CONSTRAINT [PK_LHISTORIALES] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LINEASALARMA] WITH NOCHECK ADD 
	CONSTRAINT [PK_LINEASALARMA] PRIMARY KEY  CLUSTERED 
	(
		[IDLINEAALARMA]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LINEASALARMAM] WITH NOCHECK ADD 
	CONSTRAINT [PK_LINEASALARMAM] PRIMARY KEY  CLUSTERED 
	(
		[IDLINEAALARMA]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LINEASANALITICAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_LINEASANALITICAS] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LINEASFACTURAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_LINEASFACTURAS] PRIMARY KEY  CLUSTERED 
	(
		[IDLINEAFACTURA]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LINEASINDICACIONES] WITH NOCHECK ADD 
	CONSTRAINT [PK_LINEASINDICACIONES] PRIMARY KEY  CLUSTERED 
	(
		[IDLINEASINDICACIONES]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LMUTUAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_LMUTUAS] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LMUTUASEMPRESAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_LMUTUASEMPRESAS] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LPLANTILLAANALITICAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_LPLANTILLAANALITICAS] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LPRESUPUESTOS] WITH NOCHECK ADD 
	CONSTRAINT [PK_LPRESUPUESTOS] PRIMARY KEY  CLUSTERED 
	(
		[IDPRESUPUESTO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[MEDICAMENTOS] WITH NOCHECK ADD 
	CONSTRAINT [PK_MEDICAMENTOS] PRIMARY KEY  CLUSTERED 
	(
		[CMEDICAMENTO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[MEDICOS] WITH NOCHECK ADD 
	CONSTRAINT [PK_MEDICOS] PRIMARY KEY  CLUSTERED 
	(
		[CMEDICO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[MODELOSCOMPARATIVA] WITH NOCHECK ADD 
	CONSTRAINT [PK_MODELOSCOMPARATIVA] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[MODELOSDATOS] WITH NOCHECK ADD 
	CONSTRAINT [PK_MODELOSDATOS] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[MUTUAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_MUTUAS] PRIMARY KEY  CLUSTERED 
	(
		[CMUTUA]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PACIENTES] WITH NOCHECK ADD 
	CONSTRAINT [PK_PACIENTES] PRIMARY KEY  CLUSTERED 
	(
		[CPACIENTE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PAISES] WITH NOCHECK ADD 
	CONSTRAINT [PK_PAISES] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PARTES] WITH NOCHECK ADD 
	CONSTRAINT [PK_PARTES] PRIMARY KEY  CLUSTERED 
	(
		[IDPARTE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PERMISOS] WITH NOCHECK ADD 
	CONSTRAINT [PK_PERMISOS] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PERMISOS_USUARIO] WITH NOCHECK ADD 
	CONSTRAINT [PK_PERMISOS_USUARIO] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PLANTILLAANALITICAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_PLANTILLAANALITICAS] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PLANTILLAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_PLANTILLAS] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PLANTILLA_HISTORIALES] WITH NOCHECK ADD 
	CONSTRAINT [PK_PLANTILLA_HISTORIALES] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PRESUPUESTOS] WITH NOCHECK ADD 
	CONSTRAINT [PK_PRESUPUESTOS] PRIMARY KEY  CLUSTERED 
	(
		[NUMERO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PROVEEDORES] WITH NOCHECK ADD 
	CONSTRAINT [PK_PROVEEDORES] PRIMARY KEY  CLUSTERED 
	(
		[CPROVEEDOR]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PROVINCIAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_PROVINCIAS] PRIMARY KEY  CLUSTERED 
	(
		[CPROVINCIA]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[RECETAS] WITH NOCHECK ADD 
	CONSTRAINT [PK_RECETAS] PRIMARY KEY  CLUSTERED 
	(
		[IDRECETA]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[RECIBOS] WITH NOCHECK ADD 
	CONSTRAINT [PK_RECIBOS] PRIMARY KEY  CLUSTERED 
	(
		[NUMERO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[SERIES] WITH NOCHECK ADD 
	CONSTRAINT [PK_SERIES] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[USUARIOS] WITH NOCHECK ADD 
	CONSTRAINT [PK_USUARIOS] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ALTAS] ADD 
	CONSTRAINT [DF__ALTAS__EXTERNA__77BFCB91] DEFAULT ('N') FOR [EXTERNA]
GO

ALTER TABLE [dbo].[ANALITICAS] ADD 
	CONSTRAINT [DF__ANALITICA__IMPOR__79A81403] DEFAULT (0) FOR [IMPORTE]
GO

ALTER TABLE [dbo].[AUDIOMETRIAS] ADD 
	CONSTRAINT [DF__AUDIOMETR__OD250__7E6CC920] DEFAULT (0) FOR [OD250],
	CONSTRAINT [DF__AUDIOMETR__OD500__7F60ED59] DEFAULT (0) FOR [OD500],
	CONSTRAINT [DF__AUDIOMETR__OD100__00551192] DEFAULT (0) FOR [OD1000],
	CONSTRAINT [DF__AUDIOMETR__OD200__014935CB] DEFAULT (0) FOR [OD2000],
	CONSTRAINT [DF__AUDIOMETR__OD300__023D5A04] DEFAULT (0) FOR [OD3000],
	CONSTRAINT [DF__AUDIOMETR__OD400__03317E3D] DEFAULT (0) FOR [OD4000],
	CONSTRAINT [DF__AUDIOMETR__OD600__0425A276] DEFAULT (0) FOR [OD6000],
	CONSTRAINT [DF__AUDIOMETR__OD800__0519C6AF] DEFAULT (0) FOR [OD8000],
	CONSTRAINT [DF__AUDIOMETR__OI800__060DEAE8] DEFAULT (0) FOR [OI8000],
	CONSTRAINT [DF__AUDIOMETR__OI250__07020F21] DEFAULT (0) FOR [OI250],
	CONSTRAINT [DF__AUDIOMETR__OI500__07F6335A] DEFAULT (0) FOR [OI500],
	CONSTRAINT [DF__AUDIOMETR__OI100__08EA5793] DEFAULT (0) FOR [OI1000],
	CONSTRAINT [DF__AUDIOMETR__OI200__09DE7BCC] DEFAULT (0) FOR [OI2000],
	CONSTRAINT [DF__AUDIOMETR__OI300__0AD2A005] DEFAULT (0) FOR [OI3000],
	CONSTRAINT [DF__AUDIOMETR__OI400__0BC6C43E] DEFAULT (0) FOR [OI4000],
	CONSTRAINT [DF__AUDIOMETR__OI600__0CBAE877] DEFAULT (0) FOR [OI6000]
GO

ALTER TABLE [dbo].[CITAS] ADD 
	CONSTRAINT [DF__CITAS__CONFIRMAD__108B795B] DEFAULT ('S') FOR [CONFIRMADA],
	CONSTRAINT [DF__CITAS__BANCO__117F9D94] DEFAULT ('N') FOR [BANCO],
	CONSTRAINT [DF__CITAS__PAGADA__1273C1CD] DEFAULT ('N') FOR [PAGADA],
	CONSTRAINT [DF__CITAS__ATENDIDO__1367E606] DEFAULT ('N') FOR [ATENDIDO],
	CONSTRAINT [DF__CITAS__REFPROCED__145C0A3F] DEFAULT ((-1)) FOR [REFPROCEDENCIA]
GO

ALTER TABLE [dbo].[CONCEPTOSANALITICA] ADD 
	CONSTRAINT [DF__CONCEPTOS__IMPOR__173876EA] DEFAULT (0) FOR [IMPORTE]
GO

ALTER TABLE [dbo].[CONCEPTOSFACTURABLES] ADD 
	CONSTRAINT [DF__CONCEPTOS__IMPOR__1920BF5C] DEFAULT (0) FOR [IMPORTE]
GO

ALTER TABLE [dbo].[DIAGNOSTICOS] ADD 
	CONSTRAINT [DF__DIAGNOSTI__FAVOR__1ED998B2] DEFAULT ('N') FOR [FAVORITO]
GO

ALTER TABLE [dbo].[EMPRESAS] ADD 
	CONSTRAINT [DF__EMPRESAS__FECHA__20C1E124] DEFAULT (getdate()) FOR [FECHA]
GO

ALTER TABLE [dbo].[FACTURAS] ADD 
	CONSTRAINT [DF__FACTURAS__PAGADA__22AA2996] DEFAULT ('N') FOR [PAGADA],
	CONSTRAINT [DF__FACTURAS__MUTUA__239E4DCF] DEFAULT ('N') FOR [MUTUA],
	CONSTRAINT [DF__FACTURAS__RECIBO__24927208] DEFAULT ('N') FOR [RECIBO],
	CONSTRAINT [DF__FACTURAS__PORCEN__25869641] DEFAULT (0) FOR [PORCENTAJEIRPF],
	CONSTRAINT [DF__FACTURAS__FACTUR__267ABA7A] DEFAULT ('P') FOR [FACTURAR],
	CONSTRAINT [DF__FACTURAS__TIPOIV__276EDEB3] DEFAULT (0) FOR [TIPOIVA]
GO

ALTER TABLE [dbo].[FICHEROSGLOBAL] ADD 
	CONSTRAINT [DF__FICHEROSG__FECHA__2A4B4B5E] DEFAULT ('CURRENT_DATE') FOR [FECHA]
GO

ALTER TABLE [dbo].[FRASMEIJIDE] ADD 
	CONSTRAINT [DF__FRASMEIJI__MUTUA__2D27B809] DEFAULT ('N') FOR [MUTUA],
	CONSTRAINT [DF__FRASMEIJI__RECIB__2E1BDC42] DEFAULT ('N') FOR [RECIBO]
GO

ALTER TABLE [dbo].[LINEASANALITICAS] ADD 
	CONSTRAINT [DF__LINEASANA__PRECI__3A81B327] DEFAULT (0) FOR [PRECIO]
GO

ALTER TABLE [dbo].[LINEASFACTURAS] ADD 
	CONSTRAINT [DF__LINEASFAC__CANTI__3C69FB99] DEFAULT (1) FOR [CANTIDAD],
	CONSTRAINT [DF__LINEASFAC__TIPOI__3D5E1FD2] DEFAULT (0) FOR [TIPOIVA]
GO

ALTER TABLE [dbo].[LMUTUAS] ADD 
	CONSTRAINT [DF__LMUTUAS__TIPO__403A8C7D] DEFAULT ('A') FOR [TIPO]
GO

ALTER TABLE [dbo].[LMUTUASEMPRESAS] ADD 
	CONSTRAINT [DF__LMUTUASEMP__TIPO__4222D4EF] DEFAULT ('M') FOR [TIPO]
GO

ALTER TABLE [dbo].[LPLANTILLAANALITICAS] ADD 
	CONSTRAINT [DF__LPLANTILL__PRECI__440B1D61] DEFAULT (0) FOR [PRECIO]
GO

ALTER TABLE [dbo].[LPRESUPUESTOS] ADD 
	CONSTRAINT [DF__LPRESUPUE__CANTI__45F365D3] DEFAULT (1) FOR [CANTIDAD]
GO

ALTER TABLE [dbo].[MEDICAMENTOS] ADD 
	CONSTRAINT [DF__MEDICAMEN__FAVOR__47DBAE45] DEFAULT ('S') FOR [FAVORITOS]
GO

ALTER TABLE [dbo].[MODELOSDATOS] ADD 
	CONSTRAINT [DF__MODELOSDA__TIPOD__4BAC3F29] DEFAULT ('F') FOR [TIPODATO]
GO

ALTER TABLE [dbo].[PACIENTES] ADD 
	CONSTRAINT [DF__PACIENTES__PAGOB__4E88ABD4] DEFAULT ('N') FOR [PAGOBANCO],
	CONSTRAINT [DF__PACIENTES__DEFUN__4F7CD00D] DEFAULT ('N') FOR [DEFUNCION],
	CONSTRAINT [DF__PACIENTES__SOCIO__5165187F] DEFAULT ('N') FOR [SOCIO],
	CONSTRAINT [DF__PACIENTES__ACTIV__52593CB8] DEFAULT ('S') FOR [ACTIVO]
GO

ALTER TABLE [dbo].[PARTES] ADD 
	CONSTRAINT [DF__PARTES__REFFRA__5535A963] DEFAULT (0) FOR [REFFRA]
GO

ALTER TABLE [dbo].[PLANTILLAS] ADD 
	CONSTRAINT [DF__PLANTILLA__SECCI__5812160E] DEFAULT ('GN') FOR [SECCION]
GO

ALTER TABLE [dbo].[PRESUPUESTOS] ADD 
	CONSTRAINT [DF__PRESUPUES__MUTUA__5AEE82B9] DEFAULT ('N') FOR [MUTUA]
GO

ALTER TABLE [dbo].[RECIBOS] ADD 
	CONSTRAINT [DF__RECIBOS__COBRADO__5FB337D6] DEFAULT ('N') FOR [COBRADO],
	CONSTRAINT [DF__RECIBOS__EMITIDO__60A75C0F] DEFAULT ('N') FOR [EMITIDO],
	CONSTRAINT [DF__RECIBOS__N19__619B8048] DEFAULT ('N') FOR [N19],
	CONSTRAINT [DF__RECIBOS__TIPO__628FA481] DEFAULT ('P') FOR [TIPO]
GO

ALTER TABLE [dbo].[SERIES] ADD 
	CONSTRAINT [DF__SERIES__CONTADOR__6477ECF3] DEFAULT (0) FOR [CONTADOR]
GO

ALTER TABLE [dbo].[USUARIOS] ADD 
	CONSTRAINT [DF__USUARIOS__ADMINI__66603565] DEFAULT ('N') FOR [ADMINISTRADOR]
GO

ALTER TABLE [dbo].[ALTAS] ADD 
	CONSTRAINT [fkaltasmedico] FOREIGN KEY 
	(
		[REFMEDICO]
	) REFERENCES [dbo].[MEDICOS] (
		[CMEDICO]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[ANALITICAS] ADD 
	CONSTRAINT [fk_analiticapaciente] FOREIGN KEY 
	(
		[REFPACIENTE]
	) REFERENCES [dbo].[PACIENTES] (
		[CPACIENTE]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[ARTICULOS] ADD 
	CONSTRAINT [fkarticulosproveedor] FOREIGN KEY 
	(
		[REFPROVEEDOR]
	) REFERENCES [dbo].[PROVEEDORES] (
		[CPROVEEDOR]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[ASISTENCIAS] ADD 
	CONSTRAINT [fkasistenciasmedico] FOREIGN KEY 
	(
		[REFMEDICO]
	) REFERENCES [dbo].[MEDICOS] (
		[CMEDICO]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[AUDIOMETRIAS] ADD 
	CONSTRAINT [fk_audiometrias] FOREIGN KEY 
	(
		[REFPACIENTE]
	) REFERENCES [dbo].[PACIENTES] (
		[CPACIENTE]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[BAJAS] ADD 
	CONSTRAINT [fkbajasmedico] FOREIGN KEY 
	(
		[REFMEDICO]
	) REFERENCES [dbo].[MEDICOS] (
		[CMEDICO]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[CITAS] ADD 
	CONSTRAINT [fk_citas] FOREIGN KEY 
	(
		[REFFORMAPAGO]
	) REFERENCES [dbo].[FORMASPAGO] (
		[CODIGO]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	CONSTRAINT [fkmedico] FOREIGN KEY 
	(
		[REFMEDICO]
	) REFERENCES [dbo].[MEDICOS] (
		[CMEDICO]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[COMPARATIVAS] ADD 
	CONSTRAINT [fk_comparativasmodelo] FOREIGN KEY 
	(
		[REFMODELOCOMPARATIVA]
	) REFERENCES [dbo].[MODELOSCOMPARATIVA] (
		[CODIGO]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	CONSTRAINT [fk_comparativaspaciente] FOREIGN KEY 
	(
		[REFPACIENTE]
	) REFERENCES [dbo].[PACIENTES] (
		[CPACIENTE]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[LCOMPARATIVAS] ADD
CONSTRAINT 	FK_LCOMPARATIVAS_MODELOSCOMPARATIVA FOREIGN KEY
	(
		REFMODELOCOMPARATIVA
	) REFERENCES dbo.MODELOSCOMPARATIVA
	(
		CODIGO
	) ON UPDATE  NO ACTION ON DELETE  NO ACTION 
GO

ALTER TABLE [dbo].[DATOSCOMPARATIVA] ADD 
	CONSTRAINT [fk_datoscomparativalcomparativa] FOREIGN KEY 
	(
		[REFLCOMPARATIVA]
	) REFERENCES [dbo].[LCOMPARATIVAS] (
		[ID]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	CONSTRAINT [fk_datoscomparativamodelodato] FOREIGN KEY 
	(
		[REFMODELODATO]
	) REFERENCES [dbo].[MODELOSDATOS] (
		[CODIGO]
	) ON DELETE CASCADE  ON UPDATE CASCADE	 
GO

ALTER TABLE [dbo].[DERIVACIONES] ADD 
	CONSTRAINT [FK_DERIVACIONES_DERIVACIONES_DESTINOS] FOREIGN KEY 
	(
		[REFDESTINO]
	) REFERENCES [dbo].[DERIVACIONES_DESTINOS] (
		[CODIGO]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	CONSTRAINT [fk_derivacionespaciente] FOREIGN KEY 
	(
		[REFPACIENTE]
	) REFERENCES [dbo].[PACIENTES] (
		[CPACIENTE]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[FACTURAS] ADD 
	CONSTRAINT [fk_facturasformapago] FOREIGN KEY 
	(
		[REFFORMAPAGO]
	) REFERENCES [dbo].[FORMASPAGO] (
		[CODIGO]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	CONSTRAINT [fkfacturasempresa] FOREIGN KEY 
	(
		[REFEMPRESA]
	) REFERENCES [dbo].[EMPRESAS] (
		[CEMPRESA]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	CONSTRAINT [fkfacturasmutua] FOREIGN KEY 
	(
		[REFMUTUA]
	) REFERENCES [dbo].[MUTUAS] (
		[CMUTUA]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	CONSTRAINT [fkfacturaspaciente] FOREIGN KEY 
	(
		[REFPACIENTE]
	) REFERENCES [dbo].[PACIENTES] (
		[CPACIENTE]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[FICHEROS] ADD 
	CONSTRAINT [fk_ficheros] FOREIGN KEY 
	(
		[REFPACIENTE]
	) REFERENCES [dbo].[PACIENTES] (
		[CPACIENTE]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[FRASMEIJIDE] ADD 
	CONSTRAINT [fk_frasmeijideformapago] FOREIGN KEY 
	(
		[REFFORMAPAGO]
	) REFERENCES [dbo].[FORMASPAGO] (
		[CODIGO]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	CONSTRAINT [fk_frasmeijiderecibo] FOREIGN KEY 
	(
		[REFRECIBO]
	) REFERENCES [dbo].[RECIBOS] (
		[NUMERO]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	CONSTRAINT [fkdr1frasmeijide] FOREIGN KEY 
	(
		[REFDR1]
	) REFERENCES [dbo].[MEDICOS] (
		[CMEDICO]
	),
	CONSTRAINT [fkdr2frasmeijide] FOREIGN KEY 
	(
		[REFDR2]
	) REFERENCES [dbo].[MEDICOS] (
		[CMEDICO]
	),
	CONSTRAINT [fkfrasmeijideempresa] FOREIGN KEY 
	(
		[REFEMPRESA]
	) REFERENCES [dbo].[EMPRESAS] (
		[CEMPRESA]
	)
GO

ALTER TABLE [dbo].[GASTOS] ADD 
	CONSTRAINT [fk_gastosformapago] FOREIGN KEY 
	(
		[REFFORMAPAGO]
	) REFERENCES [dbo].[FORMASPAGO] (
		[CODIGO]
	)
GO

ALTER TABLE [dbo].[HISTORIALES] ADD 
	CONSTRAINT [fkhistorialesmedico] FOREIGN KEY 
	(
		[REFMEDICO]
	) REFERENCES [dbo].[MEDICOS] (
		[CMEDICO]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	CONSTRAINT [fkhistorialespaciente] FOREIGN KEY 
	(
		[REFPACIENTE]
	) REFERENCES [dbo].[PACIENTES] (
		[CPACIENTE]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[IMAGENES] ADD 
	CONSTRAINT [fkimagenespaciente] FOREIGN KEY 
	(
		[REFPACIENTE]
	) REFERENCES [dbo].[PACIENTES] (
		[CPACIENTE]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[INFORMACIONPRIMARIA] ADD 
	CONSTRAINT [fk_informacionprimariapaciente] FOREIGN KEY 
	(
		[REFPACIENTE]
	) REFERENCES [dbo].[PACIENTES] (
		[CPACIENTE]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[LEMPRESAS] ADD 
	CONSTRAINT [fk_lempresasempresa] FOREIGN KEY 
	(
		[REFEMPRESA]
	) REFERENCES [dbo].[EMPRESAS] (
		[CEMPRESA]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	CONSTRAINT [fk_lempresaspacientes] FOREIGN KEY 
	(
		[REFPACIENTE]
	) REFERENCES [dbo].[PACIENTES] (
		[CPACIENTE]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[LHISTORIALES] ADD 
	CONSTRAINT [pk_lhistorialeshistorial] FOREIGN KEY 
	(
		[REFHISTORIAL]
	) REFERENCES [dbo].[HISTORIALES] (
		[CHISTORIAL]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[LINEASALARMA] ADD 
	CONSTRAINT [fklineasalarmaalarma] FOREIGN KEY 
	(
		[REFALARMA]
	) REFERENCES [dbo].[ALARMAS] (
		[CALARMA]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	CONSTRAINT [fklineasalarmapaciente] FOREIGN KEY 
	(
		[REFPACIENTE]
	) REFERENCES [dbo].[PACIENTES] (
		[CPACIENTE]
	) ON DELETE CASCADE  ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[LINEASALARMAM] ADD 
	CONSTRAINT [fklineasalarmamalarma] FOREIGN KEY 
	(
		[REFALARMA]
	) REFERENCES [dbo].[ALARMAS] (
		[CALARMA]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	CONSTRAINT [fklineasalarmammedicamento] FOREIGN KEY 
	(
		[REFMEDICAMENTO]
	) REFERENCES [dbo].[MEDICAMENTOS] (
		[CMEDICAMENTO]
	)
GO

ALTER TABLE [dbo].[LINEASANALITICAS] ADD 
	CONSTRAINT [fk_lineasanaliticas] FOREIGN KEY 
	(
		[REFANALITICA]
	) REFERENCES [dbo].[ANALITICAS] (
		[NUMERO]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[LINEASFACTURAS] ADD 
	CONSTRAINT [fk_lineasfacturas] FOREIGN KEY 
	(
		[REFCONCEPTO]
	) REFERENCES [dbo].[CONCEPTOSFRA] (
		[CODIGO]
	),
	CONSTRAINT [fklineasfacturas] FOREIGN KEY 
	(
		[REFFACTURA]
	) REFERENCES [dbo].[FACTURAS] (
		[IDFACTURA]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[LMUTUAS] ADD 
	CONSTRAINT [fk_lmutuas_pacientes] FOREIGN KEY 
	(
		[REFPACIENTE]
	) REFERENCES [dbo].[PACIENTES] (
		[CPACIENTE]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[LMUTUASEMPRESAS] ADD 
	CONSTRAINT [fk_lmutuasempresasempresas] FOREIGN KEY 
	(
		[REFEMPRESA]
	) REFERENCES [dbo].[EMPRESAS] (
		[CEMPRESA]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[LPLANTILLAANALITICAS] ADD 
	CONSTRAINT [fk_lplantillaplantilla] FOREIGN KEY 
	(
		[REFPLANTILLA]
	) REFERENCES [dbo].[PLANTILLAANALITICAS] (
		[CODIGO]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[LPRESUPUESTOS] ADD 
	CONSTRAINT [fklpresupuestoconcepto] FOREIGN KEY 
	(
		[REFCONCEPTO]
	) REFERENCES [dbo].[CONCEPTOSFRA] (
		[CODIGO]
	),
	CONSTRAINT [fklpresupuestopresupuesto] FOREIGN KEY 
	(
		[REFPRESUPUESTO]
	) REFERENCES [dbo].[PRESUPUESTOS] (
		[NUMERO]
	)
GO

ALTER TABLE [dbo].[MODELOSDATOS] ADD 
	CONSTRAINT [fk_modelosdatoscomparativas] FOREIGN KEY 
	(
		[REFMODELOCOMPARATIVA]
	) REFERENCES [dbo].[MODELOSCOMPARATIVA] (
		[CODIGO]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[PERMISOS_USUARIO] ADD 
	CONSTRAINT [FK_PERMISOS_USUARIO_PERMISOS] FOREIGN KEY 
	(
		[REFPERMISO]
	) REFERENCES [dbo].[PERMISOS] (
		[CODIGO]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	CONSTRAINT [FK_PERMISOS_USUARIO_USUARIOS] FOREIGN KEY 
	(
		[REFUSUARIO]
	) REFERENCES [dbo].[USUARIOS] (
		[CODIGO]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[PRESUPUESTOS] ADD 
	CONSTRAINT [fkpresupuestoempresa] FOREIGN KEY 
	(
		[REFEMPRESA]
	) REFERENCES [dbo].[EMPRESAS] (
		[CEMPRESA]
	),
	CONSTRAINT [fkpresupuestomutua] FOREIGN KEY 
	(
		[REFMUTUA]
	) REFERENCES [dbo].[MUTUAS] (
		[CMUTUA]
	),
	CONSTRAINT [fkpresupuestopaciente] FOREIGN KEY 
	(
		[REFPACIENTE]
	) REFERENCES [dbo].[PACIENTES] (
		[CPACIENTE]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[RECETAS] ADD 
	CONSTRAINT [fk_recetamedicamento] FOREIGN KEY 
	(
		[REFMEDICAMENTO]
	) REFERENCES [dbo].[MEDICAMENTOS] (
		[CMEDICAMENTO]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	CONSTRAINT [fk_recetasdiagnostico] FOREIGN KEY 
	(
		[REFDIAGNOSTICO]
	) REFERENCES [dbo].[DIAGNOSTICOS] (
		[IDDIAGNOSTICO]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	CONSTRAINT [fkrecetasmedico] FOREIGN KEY 
	(
		[REFMEDICO]
	) REFERENCES [dbo].[MEDICOS] (
		[CMEDICO]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	CONSTRAINT [fkrecetaspaciente] FOREIGN KEY 
	(
		[REFPACIENTE]
	) REFERENCES [dbo].[PACIENTES] (
		[CPACIENTE]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[RECIBOS] ADD 
	CONSTRAINT [FK_RECIBOS_PACIENTES] FOREIGN KEY 
	(
		[REFPACIENTE]
	) REFERENCES [dbo].[PACIENTES] (
		[CPACIENTE]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


CREATE PROCEDURE dbo.CleanDB

AS

DELETE FROM ARGOS
DELETE FROM Medicos
DELETE FROM Altas
DELETE FROM Bancos
DELETE FROM ConceptosAnalitica
DELETE FROM ConceptosFacturables
DELETE FROM FicherosGlobal
DELETE FROM HFrasMeijide
DELETE FROM Indicaciones
DELETE FROM LineasIndicaciones
DELETE FROM Partes
DELETE FROM Plantilla_Historiales
DELETE FROM Plantillas
DELETE FROM Provincias
DELETE FROM Series
DELETE FROM Usuarios
DELETE FROM Paises
DELETE FROM LComparativas
DELETE FROM Bajas
DELETE FROM Asistencias
DELETE FROM Diagnosticos
DELETE FROM Mutuas
DELETE FROM FormasPago
DELETE FROM Gastos
DELETE FROM Proveedores
DELETE FROM Articulos
DELETE FROM PlantillaAnaliticas
DELETE FROM LPlantillaAnaliticas
DELETE FROM Pacientes
DELETE FROM Historiales
DELETE FROM LHistoriales
DELETE FROM Analiticas
DELETE FROM LineasAnaliticas
DELETE FROM LMutuas
DELETE FROM InformacionPrimaria
DELETE FROM Ficheros
DELETE FROM AudioMetrias
DELETE FROM Derivaciones_Destinos
DELETE FROM Derivaciones
DELETE FROM Imagenes
DELETE FROM Empresas
DELETE FROM LEmpresas
DELETE FROM LMutuasEmpresas
DELETE FROM Facturas
DELETE FROM ConceptosFra
DELETE FROM LineasFacturas
DELETE FROM Presupuestos
DELETE FROM LPresupuestos
DELETE FROM Recibos
DELETE FROM Citas
DELETE FROM FrasMeijide
DELETE FROM ModelosComparativa
DELETE FROM Comparativas
DELETE FROM ModelosDatos
DELETE FROM DatosComparativa
DELETE FROM Medicamentos
DELETE FROM Recetas
DELETE FROM Alarmas
DELETE FROM LineasAlarma
DELETE FROM LineasAlarmaM
DELETE FROM PERMISOS

RETURN

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


CREATE PROCEDURE dbo.SETADMIN
AS

Declare @user as int
Set @user = 500
--Select @user =Max(codigo) from Usuarios

--if (@user is NULL)
--SET @user = 1
-- else
-- SET @user = @user + 1

--SELECT @user

INSERT INTO USUARIOS
(USUARIO, CONTRASENA, ADMINISTRADOR, FECHACLAVE, NIVEL, CODIGO)
VALUES ('admin', 'admin', 'S', GETDATE(), '', @user)

INSERT INTO PERMISOS_USUARIO VALUES ('Gastos', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Medicos', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Mutuas', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Proveedores',@user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Articulos',@user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Bancos', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Pacientes', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Empresas', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Facturas', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Citas', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Bajas', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Asistencia', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Analiticas', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Recibos', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Generar Recibos', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Imprimir Remesas', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Ficheros',@user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Rev. Comp.',@user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Recetas', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Historiales', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Info Primaria', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Alarmas', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Diagnostico', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Medicamentos', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Indicaciones', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Formas Pago', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Paises', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Plantilla de Texto', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Conceptos', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Plantillas Analiticas', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Modelos', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Plantillas Historial', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Clinicas Externas', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Configuracion', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Copia', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Anadir Factura', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('Etiquetas', @user, 3)
INSERT INTO PERMISOS_USUARIO VALUES ('LFacturas', @user, 2)
INSERT INTO PERMISOS_USUARIO VALUES ('LPartes', @user, 2)
INSERT INTO PERMISOS_USUARIO VALUES ('LRecetas', @user, 2)
INSERT INTO PERMISOS_USUARIO VALUES ('LFaltas', @user, 2)
INSERT INTO PERMISOS_USUARIO VALUES ('LCitas', @user, 2)
INSERT INTO PERMISOS_USUARIO VALUES ('Libro', @user, 3)

RETURN

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO



CREATE PROCEDURE SelectCurrentRows
(
	@table		varchar(50),
	@where	varchar(256) ,
	@order		varchar(256)
	

) 
AS BEGIN

DECLARE @query VARCHAR(1000)

 SELECT @query = 'Select * From ' +@table+ ' ' + @where + ' ' + @order

EXEC(@query)

END
GO
--AÑADIDO DONDE SE CREA LA TABLA 
-- SE AÑADE UN CAMPO EN LCOMPARATIVAS (REFMODELOSCOMPARATIVA) Y SU FOREIGN KEY


--ACTUALIZAR "REFMODELOCOMPARATIVA" DE "LCOMPARATIVAS" CON EL VALOR POR DEFECTO ESTABLECIDO EN SU CORRESPONDIENTE "COMPARATIVA".
--ESTO VA EN EL IMPORTER y/o en el INSTALADOR


--AÑADIDO EN LA PARTE DONDE SE CREA LA TABLA 
/* 
BEGIN ANNADIR UPDATE/DELETE 
Enen Cascada en la relacion LAlarmas - Paciente, 
y asi evitar el error que ocurria al eliminar un paciente con Alarmas*/




/* BEGIN ROLES Y PERMISOS*/

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[ROLES]') AND type in (N'U'))
BEGIN
CREATE TABLE [ROLES](
	[ID_ROLE] [int] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Fixed] [bit] NOT NULL CONSTRAINT [DF_ROLES_Fixed]  DEFAULT ((0)),
 CONSTRAINT [PK_ROLES] PRIMARY KEY CLUSTERED 
(
	[ID_ROLE] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[ROLESITEMS]') AND type in (N'U'))
BEGIN
CREATE TABLE [ROLESITEMS](
	[ID_ROLESITEM] [int] NOT NULL,
	[Nombre] [nvarchar](100) NULL,
 CONSTRAINT [PK_ROLESITEMS] PRIMARY KEY CLUSTERED 
(
	[ID_ROLESITEM] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[ROLESPERMISOS]') AND type in (N'U'))
BEGIN
CREATE TABLE [ROLESPERMISOS](
	[ID_ROLES] [int] NOT NULL,
	[ID_PERMISO] [int] NOT NULL,
	[ID_ROLESITEM] [int] NOT NULL,
	[Notas] [nvarchar](100) NULL,
 CONSTRAINT [PK_ROLESPERMISOS] PRIMARY KEY CLUSTERED 
(
	[ID_ROLES] ASC,
	[ID_PERMISO] ASC,
	[ID_ROLESITEM] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[ROLESUSUARIOS]') AND type in (N'U'))
BEGIN
CREATE TABLE [ROLESUSUARIOS](
	[ID_ROLES] [int] NOT NULL,
	[ID_USUARIO] [int] NOT NULL,
	[Nota] [nchar](10) NULL,
 CONSTRAINT [PK_ROLESUSUARIOS] PRIMARY KEY CLUSTERED 
(
	[ID_ROLES] ASC,
	[ID_USUARIO] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ROLESPERMISOS_PERMISOS]') AND parent_object_id = OBJECT_ID(N'[dbo].[ROLESPERMISOS]'))
ALTER TABLE [dbo].[ROLESPERMISOS]  WITH CHECK ADD  CONSTRAINT [FK_ROLESPERMISOS_PERMISOS] FOREIGN KEY([ID_PERMISO])
REFERENCES [PERMISOS] ([CODIGO])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ROLESPERMISOS_ROLES]') AND parent_object_id = OBJECT_ID(N'[dbo].[ROLESPERMISOS]'))
ALTER TABLE [dbo].[ROLESPERMISOS]  WITH CHECK ADD  CONSTRAINT [FK_ROLESPERMISOS_ROLES] FOREIGN KEY([ID_ROLES])
REFERENCES [ROLES] ([ID_ROLE])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ROLESPERMISOS_ROLESITEMS]') AND parent_object_id = OBJECT_ID(N'[dbo].[ROLESPERMISOS]'))
ALTER TABLE [dbo].[ROLESPERMISOS]  WITH CHECK ADD  CONSTRAINT [FK_ROLESPERMISOS_ROLESITEMS] FOREIGN KEY([ID_ROLESITEM])
REFERENCES [ROLESITEMS] ([ID_ROLESITEM])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ROLESUSUARIOS_ROLES]') AND parent_object_id = OBJECT_ID(N'[dbo].[ROLESUSUARIOS]'))
ALTER TABLE [dbo].[ROLESUSUARIOS]  WITH CHECK ADD  CONSTRAINT [FK_ROLESUSUARIOS_ROLES] FOREIGN KEY([ID_ROLES])
REFERENCES [ROLES] ([ID_ROLE])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ROLESUSUARIOS_USUARIOS]') AND parent_object_id = OBJECT_ID(N'[dbo].[ROLESUSUARIOS]'))
ALTER TABLE [dbo].[ROLESUSUARIOS]  WITH CHECK ADD  CONSTRAINT [FK_ROLESUSUARIOS_USUARIOS] FOREIGN KEY([ID_USUARIO])
REFERENCES [USUARIOS] ([CODIGO])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

/* END ROLES Y PERMISOS*/


/* BEGIN Crear Variables Globales */
 
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
 
GO
 
GO
CREATE TABLE dbo.VariablesGlobales
	(
	Clave varchar(500) NOT NULL,
	Valor varchar(500) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.VariablesGlobales ADD CONSTRAINT
	DF_VariablesGlobales_Clave DEFAULT '' FOR Clave
GO
ALTER TABLE dbo.VariablesGlobales ADD CONSTRAINT
	DF_VariablesGlobales_Valor DEFAULT '' FOR Valor
 
GO
 
GO
ALTER TABLE dbo.VariablesGlobales ADD CONSTRAINT
	PK_VariablesGlobales PRIMARY KEY CLUSTERED 
	(
	Clave
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]


 
/* END Crear Variables Globales */
GO
/*BEGIN ADD CAMPOS EMAIL, WEB Y CODIGO PROPIO A LA TABLA PACIENTES*/
 
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
 
GO
 
GO
ALTER TABLE dbo.PACIENTES ADD
	WEB varchar(250) NOT NULL CONSTRAINT DF_PACIENTES_WEB DEFAULT '',
	EMAIL varchar(250) NOT NULL CONSTRAINT DF_PACIENTES_EMAIL DEFAULT '',
	CODIGOPROPIO varchar(50) NOT NULL CONSTRAINT DF_PACIENTES_CODIGOPROPIO DEFAULT ''

 
GO

/*END ADD CAMPOS EMAIL, WEB Y CODIGO PROPIO A LA TABLA PACIENTES*/
