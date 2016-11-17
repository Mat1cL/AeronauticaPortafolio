create or replace PROCEDURE SP_AERONAVE_ESTADO AS 
CURSOR avionesListos
IS
select matricula,fecha_ingreso,fecha_termino,nombre_taller, horas_vuelo MANTENIMIENTO
    from aeronave a, detalle_mantenimiento dm, mantenimiento m, estado e, taller_mecanico tm
    WHERE a.matricula = dm.aeronave_matricula AND
    a.estado_id_estado = e.id_estado AND
    dm.MANTENIMIENTO_ID_MANTENIMIENTO = m.ID_MANTENIMIENTO AND
    dm.taller_mecanico_id_taller = tm.id_taller AND
    dm.FECHA_TERMINO <= SYSDATE;
    avionesListosREC avionesListos%ROWTYPE;
BEGIN
OPEN avionesListos;
LOOP
FETCH avionesListos INTO avionesListosREC;
EXIT WHEN avionesListos%NOTFOUND;
UPDATE aeronave set estado_id_estado = 1
WHERE avionesListosREC.matricula = aeronave.matricula;
INSERT INTO mantenimiento_historico
VALUES avionesListosREC;
DELETE FROM detalle_mantenimiento
WHERE FECHA_TERMINO <= SYSDATE;
END LOOP;
COMMIT;
EXCEPTION WHEN OTHERS THEN
DBMS_OUTPUT.PUT_LINE(SQLERRM);
END SP_AERONAVE_ESTADO;



create or replace PROCEDURE SP_FICHA_MEDICA_EXPIRADA AS
CURSOR pilotosExpirados
IS
select id_ficha_medica,rut_piloto, fecha_vencimiento, descripcion
    from piloto p, ficha_medica fm, estado e
    WHERE p.rut_piloto = fm.piloto_rut_piloto
    AND p.estado_id_estado = e.id_estado
    AND  fm.FECHA_VENCIMIENTO <= SYSDATE;
pilotosExpiradosREC pilotosExpirados%ROWTYPE;
BEGIN
OPEN pilotosExpirados;
LOOP
FETCH pilotosExpirados INTO pilotosExpiradosREC;
EXIT WHEN pilotosExpirados%NOTFOUND;
UPDATE piloto set estado_id_estado = 3
WHERE pilotosExpiradosREC.rut_piloto = piloto.rut_piloto;
INSERT INTO ficha_medica_historico values pilotosExpiradosREC;
DELETE FROM ficha_medica
WHERE FECHA_VENCIMIENTO <= SYSDATE;
END LOOP;
COMMIT;
EXCEPTION WHEN OTHERS THEN
DBMS_OUTPUT.PUT_LINE(SQLERRM);
END SP_FICHA_MEDICA_EXPIRADA ;



create or replace PROCEDURE SP_LICENCIA_EXPIRADA AS 
CURSOR licenciaExpirada
IS
select NUMERO_LICENCIA,descripcion,rut_piloto, TIPO_LICENCIA_ID_TIPO_LICENCIA, fecha_EXPIRACION
    from piloto p, LICENCIA L, estado e
    WHERE p.rut_piloto = L.piloto_rut_piloto
    AND p.estado_id_estado = e.id_estado
    AND L.FECHA_EXPIRACION <= SYSDATE;
licenciaExpiradaREC licenciaExpirada%ROWTYPE;
BEGIN
OPEN licenciaExpirada;
LOOP
FETCH licenciaExpirada INTO licenciaExpiradaREC;
EXIT WHEN licenciaExpirada%NOTFOUND;
INSERT INTO licencia_historica values licenciaExpiradaREC;
DELETE FROM licencia
WHERE FECHA_EXPIRACION <= SYSDATE;
END LOOP;
COMMIT;
EXCEPTION WHEN OTHERS THEN
DBMS_OUTPUT.PUT_LINE(SQLERRM);
END SP_LICENCIA_EXPIRADA;



create or replace PROCEDURE SP_PILOTO_INACTIVO AS
CURSOR pilotosInactivos
IS
select DISTINCT rut_piloto_pvr,rut_piloto, fecha_destino_real
from plan_vuelo_real pvr, piloto p,
(SELECT MAX(fecha_destino_real) from plan_vuelo_real)
WHERE TO_CHAR(fecha_destino_real,'dd/MM/yyyy HH24:MI:SS') <= TO_CHAR (SYSTIMESTAMP+30, 'dd/MM/yyyy HH24:MI:SS')
AND NOT EXISTS (select rut_copiloto from plan_vuelo_real prv where pvr.rut_piloto_pvr = prv.rut_copiloto)
AND p.rut_piloto = pvr.rut_piloto_pvr
UNION ALL
select DISTINCT rut_copiloto,rut_piloto, fecha_destino_real
from plan_vuelo_real pvr, piloto p,
(SELECT MAX(fecha_destino_real) from plan_vuelo_real)
WHERE TO_CHAR(fecha_destino_real,'dd/MM/yyyy HH24:MI:SS') <= TO_CHAR (SYSTIMESTAMP+30, 'dd/MM/yyyy HH24:MI:SS')
AND NOT EXISTS (select rut_piloto_pvr from plan_vuelo_real prv where pvr.rut_copiloto = prv.rut_piloto_pvr)
AND p.rut_piloto = pvr.rut_copiloto;
pilotosInactivosREC pilotosInactivos%ROWTYPE;
BEGIN
OPEN pilotosInactivos;
LOOP
FETCH pilotosInactivos INTO pilotosInactivosREC;
EXIT WHEN pilotosInactivos%NOTFOUND;
UPDATE piloto set estado_id_estado = 4
WHERE pilotosInactivosREC.rut_piloto_pvr = piloto.rut_piloto;
END LOOP;
COMMIT;
EXCEPTION WHEN OTHERS THEN
DBMS_OUTPUT.PUT_LINE(SQLERRM);
END SP_PILOTO_INACTIVO;

//NICO
