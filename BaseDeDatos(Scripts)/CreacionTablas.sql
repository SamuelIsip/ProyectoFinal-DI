/*BORRAR TABLAS*/
DROP TABLE PR_EX CASCADE CONSTRAINTS;
DROP TABLE EXAMEN CASCADE CONSTRAINTS;
DROP TABLE PREGUNTAS CASCADE CONSTRAINTS;
DROP TABLE CEV CASCADE CONSTRAINTS;
DROP TABLE RA CASCADE CONSTRAINTS;
DROP TABLE PROFESORES CASCADE CONSTRAINTS;
/*-----------------------------------------*/

CREATE TABLE RA(
    COD_RA NUMBER(3) GENERATED ALWAYS
  AS IDENTITY PRIMARY KEY,
    NOMBRE VARCHAR2(100),
    NOTA Number(5,2)
);

CREATE TABLE CEV (
    COD_CEV NUMBER GENERATED ALWAYS
  AS IDENTITY PRIMARY KEY,
    COD_RA NUMBER(3) NOT NULL REFERENCES RA ON DELETE CASCADE,
    NOMBRE VARCHAR2(100),
    NOTA NUMBER(5,2)
);

CREATE TABLE PREGUNTAS(
    COD_P NUMBER GENERATED ALWAYS
  AS IDENTITY PRIMARY KEY,
    COD_CEV NUMBER(3) NOT NULL REFERENCES CEV ON DELETE CASCADE,
    TIPO VARCHAR2(20) CHECK (TIPO IN('CORTA','DESARROLLO','TEST')),
    ENUNCIADO VARCHAR2(300),
    RESPUESTA VARCHAR2(600),
    OBSERV VARCHAR2(100)
);

CREATE TABLE EXAMEN(
    COD_EX NUMBER(3) PRIMARY KEY,
    FECHA VARCHAR(20)
);

CREATE TABLE PR_EX(
    COD_PR NUMBER(3) NOT NULL REFERENCES PREGUNTAS ON DELETE CASCADE,
    COD_EX NUMBER(3) NOT NULL REFERENCES EXAMEN ON DELETE CASCADE,
    PRIMARY KEY(COD_PR, COD_EX)
);

CREATE TABLE PROFESORES(
    USUARIO VARCHAR2(50),
    CONTRA  VARCHAR2(50),
    PRIMARY KEY(USUARIO)
);