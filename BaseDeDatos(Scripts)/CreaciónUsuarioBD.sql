/* ------------------------------------ */
/*CREACIÓN DE USUARIO CON PRIVILEGIOS*/
alter session set"_ORACLE_SCRIPT"=true;
create user di2 identified by di2;
grant all privileges to di2;
/* ------------------------------------ */