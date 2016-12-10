-- Generado por Oracle SQL Developer Data Modeler 4.1.5.907
--   en:        2016-11-28 15:50:02 CLST
--   sitio:      Oracle Database 11g
--   tipo:      Oracle Database 11g




CREATE TABLE aeronave
  (
    matricula                      VARCHAR2 (6) NOT NULL ,
    fecha_inspeccion_anual         DATE NOT NULL ,
    ano_fabricacion                INTEGER NOT NULL ,
    tipo_aeronave_id_tipo_aeronave INTEGER NOT NULL ,
    fabricante_id_fabricante       INTEGER NOT NULL ,
    modelo_id_modelo               INTEGER NOT NULL ,
    estado_id_estado               INTEGER NOT NULL ,
    horas_vuelo                    INTEGER ,
    minutos_vuelo                  INTEGER
  ) ;
ALTER TABLE aeronave ADD CONSTRAINT aeronave_PK PRIMARY KEY ( matricula ) ;


CREATE
  TABLE componente
  (
    id_componente          INTEGER NOT NULL ,
    nombre_componente      VARCHAR2 (50) NOT NULL ,
    descripcion            VARCHAR2 (150) NOT NULL ,
    proveedor_id_proveedor INTEGER NOT NULL ,
    aeronave_matricula     VARCHAR2 (6) NOT NULL ,
    horasvuelo INTERVAL DAY(2) TO SECOND(6) ,
    fecha_ingreso DATE NOT NULL
  ) ;
ALTER TABLE componente ADD CONSTRAINT componente_PK PRIMARY KEY ( id_componente
) ;


CREATE TABLE comuna
  (
    id_comuna              INTEGER NOT NULL ,
    nombre_comuna          VARCHAR2 (50) NOT NULL ,
    provincia_id_provincia INTEGER NOT NULL
  ) ;
ALTER TABLE comuna ADD CONSTRAINT comuna_PK PRIMARY KEY ( id_comuna ) ;


CREATE TABLE cond_tipo_cond
  (
    condicion_id_condicion INTEGER NOT NULL ,
    tipo_cond_id_tipo      INTEGER NOT NULL
  ) ;
ALTER TABLE cond_tipo_cond ADD CONSTRAINT cond_tipo_cond_PK PRIMARY KEY ( condicion_id_condicion, tipo_cond_id_tipo ) ;


CREATE TABLE condicion
  (
    id_condicion     INTEGER NOT NULL ,
    nombre_condicion VARCHAR2 (50) NOT NULL ,
    descripcion      VARCHAR2 (150) NOT NULL
  ) ;
ALTER TABLE condicion ADD CONSTRAINT condicion_PK PRIMARY KEY ( id_condicion ) ;


CREATE TABLE destino
  (
    id_destino       INTEGER NOT NULL ,
    nombre_destino   VARCHAR2 (100) NOT NULL ,
    comuna_id_comuna INTEGER NOT NULL
  ) ;
ALTER TABLE destino ADD CONSTRAINT destino_PK PRIMARY KEY ( id_destino ) ;


CREATE TABLE detalle_mantenimiento
  (
    fecha_ingreso                  DATE NOT NULL ,
    fecha_termino                  DATE NOT NULL ,
    taller_mecanico_id_taller      INTEGER NOT NULL ,
    mantenimiento_id_mantenimiento INTEGER NOT NULL ,
    aeronave_matricula             VARCHAR2 (6) NOT NULL
  ) ;
ALTER TABLE detalle_mantenimiento ADD CONSTRAINT detalle_mantenimiento_PK PRIMARY KEY ( mantenimiento_id_mantenimiento, taller_mecanico_id_taller, aeronave_matricula ) ;


CREATE TABLE estado
  (
    id_estado     INTEGER NOT NULL ,
    nombre_estado VARCHAR2 (50) NOT NULL
  ) ;
ALTER TABLE estado ADD CONSTRAINT estado_PK PRIMARY KEY ( id_estado ) ;


CREATE TABLE fabricante
  (
    id_fabricante     INTEGER NOT NULL ,
    nombre_fabricante VARCHAR2 (50) NOT NULL
  ) ;
ALTER TABLE fabricante ADD CONSTRAINT fabricante_PK PRIMARY KEY ( id_fabricante ) ;


CREATE TABLE ficha_medica
  (
    id_ficha_medica   INTEGER NOT NULL ,
    fecha_vencimiento DATE NOT NULL ,
    descripcion       VARCHAR2 (200) NOT NULL ,
    piloto_rut_piloto VARCHAR2 (15) NOT NULL
  ) ;
CREATE UNIQUE INDEX ficha_medica__IDX ON ficha_medica
  (
    piloto_rut_piloto ASC
  )
  ;
ALTER TABLE ficha_medica ADD CONSTRAINT ficha_medica_PK PRIMARY KEY ( id_ficha_medica ) ;


CREATE TABLE ficha_medica_historico
  (
    id_ficha_medica   INTEGER NOT NULL ,
    rut_piloto        VARCHAR2 (15) NOT NULL ,
    fecha_vencimiento DATE NOT NULL ,
    descripcion       VARCHAR2 (200) NOT NULL
  ) ;


CREATE TABLE licencia
  (
    numero_licencia                INTEGER NOT NULL ,
    descripcion                    VARCHAR2 (150) NOT NULL ,
    fecha_expiracion               DATE NOT NULL ,
    piloto_rut_piloto              VARCHAR2 (15) NOT NULL ,
    tipo_licencia_id_tipo_licencia INTEGER NOT NULL ,
    horas_de_vuelo                 INTEGER ,
    minutos_de_vuelo               INTEGER
  ) ;
ALTER TABLE licencia ADD CONSTRAINT licencia_PK PRIMARY KEY ( numero_licencia ) ;


CREATE TABLE licencia_historica
  (
    numero_licencia                INTEGER NOT NULL ,
    descripcion                    VARCHAR2 (200) NOT NULL ,
    piloto_rut_piloto              VARCHAR2 (15) NOT NULL ,
    tipo_licencia_id_tipo_licencia INTEGER NOT NULL ,
    fecha_expiracion               DATE NOT NULL
  ) ;


CREATE TABLE mantenimiento
  (
    id_mantenimiento INTEGER NOT NULL ,
    horas_vuelo      VARCHAR2 (100) NOT NULL
  ) ;
ALTER TABLE mantenimiento ADD CONSTRAINT mantenimiento_PK PRIMARY KEY ( id_mantenimiento ) ;


CREATE TABLE mantenimiento_historico
  (
    matricula     VARCHAR2 (6) NOT NULL ,
    fecha_ingreso DATE NOT NULL ,
    fecha_termino DATE NOT NULL ,
    nombre_taller VARCHAR2 (50) NOT NULL ,
    horas_vuelo   VARCHAR2 (100) NOT NULL
  ) ;


CREATE TABLE mision
  (
    id_mision     INTEGER NOT NULL ,
    nombre_mision VARCHAR2 (50) NOT NULL ,
    descripcion   VARCHAR2 (200) NOT NULL
  ) ;
ALTER TABLE mision ADD CONSTRAINT mision_PK PRIMARY KEY ( id_mision ) ;


CREATE TABLE modelo
  (
    id_modelo     INTEGER NOT NULL ,
    nombre_modelo VARCHAR2 (50) NOT NULL ,
    horas_vuelo   INTEGER NOT NULL
  ) ;
ALTER TABLE modelo ADD CONSTRAINT modelo_PK PRIMARY KEY ( id_modelo ) ;


CREATE TABLE origen
  (
    id_origen        INTEGER NOT NULL ,
    nombre_origen    VARCHAR2 (150) NOT NULL ,
    comuna_id_comuna INTEGER NOT NULL
  ) ;
ALTER TABLE origen ADD CONSTRAINT origen_PK PRIMARY KEY ( id_origen ) ;


CREATE TABLE pais
  (
    id_pais     INTEGER NOT NULL ,
    nombre_pais VARCHAR2 (50) NOT NULL
  ) ;
ALTER TABLE pais ADD CONSTRAINT pais_PK PRIMARY KEY ( id_pais ) ;


CREATE TABLE piloto
  (
    rut_piloto       VARCHAR2 (15) NOT NULL ,
    nombre_piloto    VARCHAR2 (50) NOT NULL ,
    apellido_paterno VARCHAR2 (50) NOT NULL ,
    apellido_materno VARCHAR2 (50) NOT NULL ,
    fecha_nacimiento DATE NOT NULL ,
    correo           VARCHAR2 (50) NOT NULL ,
    direccion        VARCHAR2 (150) NOT NULL ,
    tel_fijo         VARCHAR2 (20) ,
    tel_cel          VARCHAR2 (20) NOT NULL ,
    sexo_id_sexo     INTEGER NOT NULL ,
    comuna_id_comuna INTEGER NOT NULL ,
    estado_id_estado INTEGER NOT NULL
  ) ;
ALTER TABLE piloto ADD CONSTRAINT piloto_PK PRIMARY KEY ( rut_piloto ) ;


CREATE TABLE plan_vuelo
  (
    id_vuelo               INTEGER NOT NULL ,
    descripcion            VARCHAR2 (200) NOT NULL ,
    fecha_origen_estimada  TIMESTAMP NOT NULL ,
    fecha_destino_estimada TIMESTAMP NOT NULL ,
    condicion_id_condicion INTEGER NOT NULL ,
    mision_id_mision       INTEGER NOT NULL ,
    piloto_rut_piloto      VARCHAR2 (15) NOT NULL ,
    rut_copiloto           VARCHAR2 (15) NOT NULL ,
    licencia_piloto        INTEGER NOT NULL ,
    licencia_copiloto      INTEGER NOT NULL ,
    ruta                   VARCHAR2 (300) NOT NULL ,
    destino_id_destino     INTEGER NOT NULL ,
    origen_id_origen       INTEGER NOT NULL ,
    aeronave_matricula     VARCHAR2 (6) NOT NULL
  ) ;
ALTER TABLE plan_vuelo ADD CONSTRAINT plan_vuelo_PK PRIMARY KEY ( id_vuelo ) ;


CREATE TABLE plan_vuelo_real
  (
    id_plan_vuelo_real     INTEGER NOT NULL ,
    descripcion            VARCHAR2 (100) NOT NULL ,
    fecha_origen_real      TIMESTAMP NOT NULL ,
    fecha_destino_real     TIMESTAMP NOT NULL ,
    tiempo_taxeo_salida    TIMESTAMP NOT NULL ,
    tiempo_taxeo_llegada   TIMESTAMP NOT NULL ,
    rut_piloto_pvr         VARCHAR2 (15) NOT NULL ,
    rut_copiloto           VARCHAR2 (15) NOT NULL ,
    licencia_piloto        INTEGER NOT NULL ,
    licencia_copiloto      INTEGER NOT NULL ,
    hora_vuelo_piloto      INTEGER NOT NULL ,
    hora_vuelo_copiloto    INTEGER NOT NULL ,
    minuto_vuelo_piloto    INTEGER NOT NULL ,
    minuto_vuelo_copiloto  INTEGER NOT NULL ,
    ruta                   VARCHAR2 (300) NOT NULL ,
    origen_id_origen       INTEGER NOT NULL ,
    destino_id_destino     INTEGER NOT NULL ,
    aeronave_matricula     VARCHAR2 (6) NOT NULL ,
    mision_id_mision       INTEGER NOT NULL ,
    condicion_id_condicion INTEGER NOT NULL ,
    plan_vuelo_id_vuelo    INTEGER NOT NULL
  ) ;
CREATE UNIQUE INDEX plan_vuelo_real__IDX ON plan_vuelo_real
  (
    plan_vuelo_id_vuelo ASC
  )
  ;
ALTER TABLE plan_vuelo_real ADD CONSTRAINT plan_vuelo_real_PK PRIMARY KEY ( id_plan_vuelo_real ) ;


CREATE TABLE proveedor
  (
    id_proveedor     INTEGER NOT NULL ,
    nombre_proveedor VARCHAR2 (50) NOT NULL ,
    direccion        VARCHAR2 (150) NOT NULL
  ) ;
ALTER TABLE proveedor ADD CONSTRAINT proveedor_PK PRIMARY KEY ( id_proveedor ) ;


CREATE TABLE provincia
  (
    id_provincia     INTEGER NOT NULL ,
    nombre_provincia VARCHAR2 (50) NOT NULL ,
    region_id_region INTEGER NOT NULL
  ) ;
ALTER TABLE provincia ADD CONSTRAINT provincia_PK PRIMARY KEY ( id_provincia ) ;


CREATE TABLE region
  (
    id_region     INTEGER NOT NULL ,
    nombre_region VARCHAR2 (50) NOT NULL ,
    pais_id_pais  INTEGER NOT NULL
  ) ;
ALTER TABLE region ADD CONSTRAINT region_PK PRIMARY KEY ( id_region ) ;


CREATE TABLE sexo
  (
    id_sexo     INTEGER NOT NULL ,
    nombre_sexo VARCHAR2 (50) NOT NULL
  ) ;
ALTER TABLE sexo ADD CONSTRAINT sexo_PK PRIMARY KEY ( id_sexo ) ;


CREATE TABLE taller_mecanico
  (
    id_taller     INTEGER NOT NULL ,
    nombre_taller VARCHAR2 (50) NOT NULL ,
    descripcion   VARCHAR2 (150) NOT NULL
  ) ;
ALTER TABLE taller_mecanico ADD CONSTRAINT taller_mecanico_PK PRIMARY KEY ( id_taller ) ;


CREATE TABLE tipo_aeronave
  (
    id_tipo_aeronave     INTEGER NOT NULL ,
    nombre_tipo_aeronave VARCHAR2 (50) NOT NULL
  ) ;
ALTER TABLE tipo_aeronave ADD CONSTRAINT tipo_aeronave_PK PRIMARY KEY ( id_tipo_aeronave ) ;


CREATE TABLE tipo_condicion
  (
    id_tipo_condicion     INTEGER NOT NULL ,
    nombre_tipo_condicion VARCHAR2 (50) NOT NULL
  ) ;
ALTER TABLE tipo_condicion ADD CONSTRAINT tipo_condicion_PK PRIMARY KEY ( id_tipo_condicion ) ;


CREATE TABLE tipo_licencia
  (
    id_tipo_licencia     INTEGER NOT NULL ,
    nombre_tipo_licencia VARCHAR2 (100) NOT NULL ,
    descripcion          VARCHAR2 (200) NOT NULL
  ) ;
ALTER TABLE tipo_licencia ADD CONSTRAINT tipo_licencia_PK PRIMARY KEY ( id_tipo_licencia ) ;


CREATE TABLE tipo_usuario
  (
    id_tipo_usuario     INTEGER NOT NULL ,
    nombre_tipo_usuario VARCHAR2 (50) NOT NULL
  ) ;
ALTER TABLE tipo_usuario ADD CONSTRAINT tipo_usuario_PK PRIMARY KEY ( id_tipo_usuario ) ;


CREATE TABLE usuario
  (
    rut                          VARCHAR2 (15) NOT NULL ,
    contrasena                   VARCHAR2 (50) NOT NULL ,
    tipo_usuario_id_tipo_usuario INTEGER NOT NULL
  ) ;
ALTER TABLE usuario ADD CONSTRAINT usuario_PK PRIMARY KEY ( rut ) ;


CREATE TABLE usuario_mision
  (
    usuario_rut      VARCHAR2 (15) NOT NULL ,
    mision_id_mision INTEGER NOT NULL
  ) ;
ALTER TABLE usuario_mision ADD CONSTRAINT usuario_mision_PK PRIMARY KEY ( usuario_rut, mision_id_mision ) ;


CREATE TABLE usuario_plan_vuelo
  (
    usuario_rut         VARCHAR2 (15) NOT NULL ,
    plan_vuelo_id_vuelo INTEGER NOT NULL
  ) ;
ALTER TABLE usuario_plan_vuelo ADD CONSTRAINT usuario_plan_vuelo_PK PRIMARY KEY ( usuario_rut, plan_vuelo_id_vuelo ) ;


ALTER TABLE cond_tipo_cond ADD CONSTRAINT FK_ASS_10 FOREIGN KEY ( condicion_id_condicion ) REFERENCES condicion ( id_condicion ) ;

ALTER TABLE cond_tipo_cond ADD CONSTRAINT FK_ASS_11 FOREIGN KEY ( tipo_cond_id_tipo ) REFERENCES tipo_condicion ( id_tipo_condicion ) ;

ALTER TABLE usuario_mision ADD CONSTRAINT FK_ASS_35 FOREIGN KEY ( usuario_rut ) REFERENCES usuario ( rut ) ;

ALTER TABLE usuario_mision ADD CONSTRAINT FK_ASS_36 FOREIGN KEY ( mision_id_mision ) REFERENCES mision ( id_mision ) ;

ALTER TABLE usuario_plan_vuelo ADD CONSTRAINT FK_ASS_37 FOREIGN KEY ( usuario_rut ) REFERENCES usuario ( rut ) ;

ALTER TABLE usuario_plan_vuelo ADD CONSTRAINT FK_ASS_38 FOREIGN KEY ( plan_vuelo_id_vuelo ) REFERENCES plan_vuelo ( id_vuelo ) ;

ALTER TABLE aeronave ADD CONSTRAINT aeronave_estado_FK FOREIGN KEY ( estado_id_estado ) REFERENCES estado ( id_estado ) ;

ALTER TABLE aeronave ADD CONSTRAINT aeronave_fabricante_FK FOREIGN KEY ( fabricante_id_fabricante ) REFERENCES fabricante ( id_fabricante ) ;

ALTER TABLE aeronave ADD CONSTRAINT aeronave_modelo_FK FOREIGN KEY ( modelo_id_modelo ) REFERENCES modelo ( id_modelo ) ;

ALTER TABLE aeronave ADD CONSTRAINT aeronave_tipo_aeronave_FK FOREIGN KEY ( tipo_aeronave_id_tipo_aeronave ) REFERENCES tipo_aeronave ( id_tipo_aeronave ) ;

ALTER TABLE componente ADD CONSTRAINT componente_aeronave_FK FOREIGN KEY ( aeronave_matricula ) REFERENCES aeronave ( matricula ) ;

ALTER TABLE componente ADD CONSTRAINT componente_proveedor_FK FOREIGN KEY ( proveedor_id_proveedor ) REFERENCES proveedor ( id_proveedor ) ;

ALTER TABLE comuna ADD CONSTRAINT comuna_provincia_FK FOREIGN KEY ( provincia_id_provincia ) REFERENCES provincia ( id_provincia ) ;

ALTER TABLE destino ADD CONSTRAINT destino_comuna_FK FOREIGN KEY ( comuna_id_comuna ) REFERENCES comuna ( id_comuna ) ;

ALTER TABLE detalle_mantenimiento ADD CONSTRAINT det_mant_aeronave_FK FOREIGN KEY ( aeronave_matricula ) REFERENCES aeronave ( matricula ) ;

ALTER TABLE detalle_mantenimiento ADD CONSTRAINT det_mant_mant_FK FOREIGN KEY ( mantenimiento_id_mantenimiento ) REFERENCES mantenimiento ( id_mantenimiento ) ;

ALTER TABLE detalle_mantenimiento ADD CONSTRAINT det_mant_taller_FK FOREIGN KEY ( taller_mecanico_id_taller ) REFERENCES taller_mecanico ( id_taller ) ;

ALTER TABLE ficha_medica ADD CONSTRAINT ficha_medica_piloto_FK FOREIGN KEY ( piloto_rut_piloto ) REFERENCES piloto ( rut_piloto ) ;

ALTER TABLE licencia ADD CONSTRAINT licencia_piloto_FK FOREIGN KEY ( piloto_rut_piloto ) REFERENCES piloto ( rut_piloto ) ;

ALTER TABLE licencia ADD CONSTRAINT licencia_tipo_licencia_FK FOREIGN KEY ( tipo_licencia_id_tipo_licencia ) REFERENCES tipo_licencia ( id_tipo_licencia ) ;

ALTER TABLE origen ADD CONSTRAINT origen_comuna_FK FOREIGN KEY ( comuna_id_comuna ) REFERENCES comuna ( id_comuna ) ;

ALTER TABLE piloto ADD CONSTRAINT piloto_comuna_FK FOREIGN KEY ( comuna_id_comuna ) REFERENCES comuna ( id_comuna ) ;

ALTER TABLE piloto ADD CONSTRAINT piloto_estado_FK FOREIGN KEY ( estado_id_estado ) REFERENCES estado ( id_estado ) ;

ALTER TABLE piloto ADD CONSTRAINT piloto_sexo_FK FOREIGN KEY ( sexo_id_sexo ) REFERENCES sexo ( id_sexo ) ;

ALTER TABLE plan_vuelo ADD CONSTRAINT plan_vuelo_aeronave_FK FOREIGN KEY ( aeronave_matricula ) REFERENCES aeronave ( matricula ) ;

ALTER TABLE plan_vuelo ADD CONSTRAINT plan_vuelo_condicion_FK FOREIGN KEY ( condicion_id_condicion ) REFERENCES condicion ( id_condicion ) ;

ALTER TABLE plan_vuelo ADD CONSTRAINT plan_vuelo_destino_FK FOREIGN KEY ( destino_id_destino ) REFERENCES destino ( id_destino ) ;

ALTER TABLE plan_vuelo ADD CONSTRAINT plan_vuelo_mision_FK FOREIGN KEY ( mision_id_mision ) REFERENCES mision ( id_mision ) ;

ALTER TABLE plan_vuelo ADD CONSTRAINT plan_vuelo_origen_FK FOREIGN KEY ( origen_id_origen ) REFERENCES origen ( id_origen ) ;

ALTER TABLE plan_vuelo ADD CONSTRAINT plan_vuelo_piloto_FK FOREIGN KEY ( piloto_rut_piloto ) REFERENCES piloto ( rut_piloto ) ;

ALTER TABLE plan_vuelo_real ADD CONSTRAINT plan_vuelo_real_aeronave_FK FOREIGN KEY ( aeronave_matricula ) REFERENCES aeronave ( matricula ) ;

ALTER TABLE plan_vuelo_real ADD CONSTRAINT plan_vuelo_real_condicion_FK FOREIGN KEY ( condicion_id_condicion ) REFERENCES condicion ( id_condicion ) ;

ALTER TABLE plan_vuelo_real ADD CONSTRAINT plan_vuelo_real_destino_FK FOREIGN KEY ( destino_id_destino ) REFERENCES destino ( id_destino ) ;

ALTER TABLE plan_vuelo_real ADD CONSTRAINT plan_vuelo_real_mision_FK FOREIGN KEY ( mision_id_mision ) REFERENCES mision ( id_mision ) ;

ALTER TABLE plan_vuelo_real ADD CONSTRAINT plan_vuelo_real_origen_FK FOREIGN KEY ( origen_id_origen ) REFERENCES origen ( id_origen ) ;

ALTER TABLE plan_vuelo_real ADD CONSTRAINT plan_vuelo_real_plan_vuelo_FK FOREIGN KEY ( plan_vuelo_id_vuelo ) REFERENCES plan_vuelo ( id_vuelo ) ;

ALTER TABLE provincia ADD CONSTRAINT provincia_region_FK FOREIGN KEY ( region_id_region ) REFERENCES region ( id_region ) ;

ALTER TABLE region ADD CONSTRAINT region_pais_FK FOREIGN KEY ( pais_id_pais ) REFERENCES pais ( id_pais ) ;

ALTER TABLE usuario ADD CONSTRAINT usuario_tipo_usuario_FK FOREIGN KEY ( tipo_usuario_id_tipo_usuario ) REFERENCES tipo_usuario ( id_tipo_usuario ) ;


-- Informe de Resumen de Oracle SQL Developer Data Modeler: 
-- 
-- CREATE TABLE                            34
-- CREATE INDEX                             2
-- ALTER TABLE                             70
-- CREATE VIEW                              0
-- ALTER VIEW                               0
-- CREATE PACKAGE                           0
-- CREATE PACKAGE BODY                      0
-- CREATE PROCEDURE                         0
-- CREATE FUNCTION                          0
-- CREATE TRIGGER                           0
-- ALTER TRIGGER                            0
-- CREATE COLLECTION TYPE                   0
-- CREATE STRUCTURED TYPE                   0
-- CREATE STRUCTURED TYPE BODY              0
-- CREATE CLUSTER                           0
-- CREATE CONTEXT                           0
-- CREATE DATABASE                          0
-- CREATE DIMENSION                         0
-- CREATE DIRECTORY                         0
-- CREATE DISK GROUP                        0
-- CREATE ROLE                              0
-- CREATE ROLLBACK SEGMENT                  0
-- CREATE SEQUENCE                          0
-- CREATE MATERIALIZED VIEW                 0
-- CREATE SYNONYM                           0
-- CREATE TABLESPACE                        0
-- CREATE USER                              0
-- 
-- DROP TABLESPACE                          0
-- DROP DATABASE                            0
-- 
-- REDACTION POLICY                         0
-- 
-- ORDS DROP SCHEMA                         0
-- ORDS ENABLE SCHEMA                       0
-- ORDS ENABLE OBJECT                       0
-- 
-- ERRORS                                   0
-- WARNINGS                                 0
